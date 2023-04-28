// Benyamin Deilamizade 
// Version 2.0
// Temperature system using KY-028 sensor and 12v Fan
// map(resistor max, min , 20 , 220);  
#include <Arduino.h>
#include <WiFi.h>
#include <PubSubClient.h>
#define ANALOG_PIN 34
#define DIGITAL_PIN 32
#define SERIES_RESISTOR 10000
#define THERMISTOR_NOMINAL 10000
#define TEMPERATURE_NOMINAL 25
#define B_COEEFFICIENT 3950
#define TEMPERATURE_THRESHOLD 30.0 // 100.0
#define TEMPERATURE_LOW_THRESHOLD 27.0
#define FAN_PIN 27
const int unsigned long FAN_INTERVAL = 10000;
const int unsigned long REFRESH_INTERVAL = 1000;

const char* ssid = "Daki4-pixel6";
const char* password =  "mmmpiidau";
const char* mqttServer = "mqtt.yordanmitev.me";
const int mqttPort = 1883;
const char* mqttUser = "3dPrinterUsr";
const char* mqttPassword = "somepassword";

WiFiClient espClient;
PubSubClient client(espClient);

enum FanStates
{
  FAN_OFF,
  FAN_ON
};

FanStates fan = FAN_OFF;
unsigned long previouseMillis = 0;
unsigned long fan_previous_milis = 0;
void tryToConccet()
{
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.println("Connecting to WiFi..");
  }
 
  Serial.println("Connected to the WiFi network");
 
  client.setServer(mqttServer, mqttPort);
 
  while (!client.connected()) {
    Serial.println("Connecting to MQTT...");
 
    if (client.connect("ESP32Client", mqttUser, mqttPassword )) {
 
      Serial.println("connected");
 
    } else {
 
      Serial.print("failed with state ");
      Serial.print(client.state());
      delay(2000);
 
    }
  }
}
void setup()
{
  Serial.begin(9600);
  WiFi.begin(ssid, password);
  tryToConccet();
  pinMode(FAN_PIN, OUTPUT);
  pinMode(ANALOG_PIN, INPUT);
}

float calculateTemp()
{

  int analog_value = analogRead(ANALOG_PIN);
  float resistance = SERIES_RESISTOR * ((4095.0 / analog_value) - 1.0);
  float temperature = -1.0 / ((log(resistance / THERMISTOR_NOMINAL) / B_COEEFFICIENT) + (1.0 / (TEMPERATURE_NOMINAL + 273.15))) + 273.15;
  return temperature;
}

void printTemperature()
{
  unsigned long currentMillis = millis();
  if (currentMillis - previouseMillis >= REFRESH_INTERVAL)
  {
    previouseMillis = currentMillis;
    float temperature = calculateTemp();
    Serial.print("Temperature: ");
    Serial.print(temperature);
    Serial.print(" degrees Celsius");
    Serial.println("-------------------------------------");
  }
}

  void loop()
  {
    unsigned long currentMillis = millis();

    printTemperature();

    String temperatureString = String(calculateTemp());
    client.publish("3dPrinter/1/heater/", temperatureString.c_str());

    if (currentMillis - fan_previous_milis >= FAN_INTERVAL)
    {
      fan_previous_milis = currentMillis;

      float temperature = calculateTemp();

      if (temperature >= TEMPERATURE_THRESHOLD && fan == FAN_OFF)
      {
        fan = FAN_ON;
        digitalWrite(FAN_PIN, HIGH);
      }
      else if (temperature <= TEMPERATURE_LOW_THRESHOLD && fan == FAN_ON)
      {
        fan = FAN_OFF;
        digitalWrite(FAN_PIN, LOW);
      }
    }
  }
