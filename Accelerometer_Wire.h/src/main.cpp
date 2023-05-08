#include <Wire.h>
#include <HardwareSerial.h>
#include <math.h>
#include <WiFi.h>
#include <PubSubClient.h>

// MMA7455 I2C address
#define MMA7455_ADDR 0x1D

// MMA7455 registers
#define MMA7455_XOUTL 0x00
#define MMA7455_XOUTH 0x01
#define MMA7455_YOUTL 0x02
#define MMA7455_YOUTH 0x03
#define MMA7455_ZOUTL 0x04
#define MMA7455_ZOUTH 0x05
#define MMA7455_MODE 0x16

// Offset calibration values
#define X_OFFSET 1014
#define Y_OFFSET 998
#define Z_OFFSET 0

float x_scale = 1.0 / 128.0;
float y_scale = 1.0 / 128.0;
float z_scale = 1.0 / 64.0;

String x_str, y_str, z_str;

const int INTERVAL = 500;
unsigned long previous_time, current_time;

const char *ssid = "Daki4-pixel6";
const char *password = "mmmpiidau";
const char *mqttServer = "mqtt.yordanmitev.me";
const int mqttPort = 1883;
const char *mqttUser = "3dPrinterUsr";
const char *mqttPassword = "somepassword";

WiFiClient espClient;
PubSubClient client(espClient);

void tryToConccet()
{
  while (WiFi.status() != WL_CONNECTED)
  {
    delay(500);
    Serial.println("Connecting to WiFi..");
  }

  Serial.println("Connected to the WiFi network");

  client.setServer(mqttServer, mqttPort);

  while (!client.connected())
  {
    Serial.println("Connecting to MQTT...");

    if (client.connect("ESP32Client", mqttUser, mqttPassword))
    {

      Serial.println("connected");
    }
    else
    {

      Serial.print("failed with state ");
      Serial.print(client.state());
      delay(2000);
    }
  }
}

void setup()
{
  Serial.begin(9600);
  Wire.begin();

  // Set MMA7455 to measurement mode
  Wire.beginTransmission(MMA7455_ADDR);
  Wire.write(MMA7455_MODE);
  Wire.write(0x01);
  Wire.endTransmission();

  WiFi.begin(ssid, password);
  tryToConccet();
}

// float read_and_convert_raw_values_to_Gs(float x_out, float y_out, float z_out)
// {

//   int16_t x, y, z;

//   // Read acceleration data
//   Wire.beginTransmission(MMA7455_ADDR);
//   Wire.write(MMA7455_XOUTL);
//   Wire.endTransmission();
//   Wire.requestFrom(MMA7455_ADDR, 6);

//   if (Wire.available() == 6) {
//     x = (int16_t)((Wire.read() & 0xFF) | (Wire.read() << 8));
//     y = (int16_t)((Wire.read() & 0xFF) | (Wire.read() << 8));
//     z = (int16_t)((Wire.read() & 0xFF) | (Wire.read() << 8));
//   }

//   x_out = (float)(x - X_OFFSET) * x_scale;
//   y_out = (float)(y - Y_OFFSET) * y_scale;
//   z_out = (float)(z - Z_OFFSET) * z_scale;
//   return x_out, y_out, z_out;
// }

void printValues(float x_out, float y_out, float z_out)
{
  if (current_time - previous_time >= INTERVAL)
  {
    Serial.print("X: ");
    Serial.print(x_out, 2);
    Serial.print(" Y: ");
    Serial.print(y_out, 2);
    Serial.print(" Z: ");
    Serial.println(z_out, 2);
    Serial.println("----");
    if (x_out < 0.03 && x_out > -0.01 && y_out < 0.05 && y_out > -0.01 && z_out > 1.08 && z_out < 1.15)
    {
      Serial.println("printer is leveled");
    }
    else
    {
      Serial.println("printer is not leveled");
    }
    previous_time = current_time;
  }
}

void loop()
{
  current_time = millis();
  float x_out, y_out, z_out;
  // read_and_convert_raw_values_to_Gs(x_out, y_out, z_out);
  int16_t x, y, z;

  // Read acceleration data
  Wire.beginTransmission(MMA7455_ADDR);
  Wire.write(MMA7455_XOUTL);
  Wire.endTransmission();
  Wire.requestFrom(MMA7455_ADDR, 6);

  if (Wire.available() == 6)
  {
    x = (int16_t)((Wire.read() & 0xFF) | (Wire.read() << 8));
    y = (int16_t)((Wire.read() & 0xFF) | (Wire.read() << 8));
    z = (int16_t)((Wire.read() & 0xFF) | (Wire.read() << 8));
  }

  x_out = (float)(x - X_OFFSET) * x_scale;
  y_out = (float)(y - Y_OFFSET) * y_scale;
  z_out = (float)(z - Z_OFFSET) * z_scale;

  printValues(x_out, y_out, z_out);

  x_str = String(x_out, 3);
  y_str = String(y_out, 3);
  z_str = String(z_out, 3);

  // Serial.print("X: ");
  // Serial.print(x_out, 2);
  // Serial.print(" Y: ");
  // Serial.print(y_out, 2);
  // Serial.print(" Z: ");
  // Serial.println(z_out, 2);
  // Serial.println("----");

  client.publish("3dPrinter/1/accelerometer/", (x_str + y_str + z_str).c_str());
}