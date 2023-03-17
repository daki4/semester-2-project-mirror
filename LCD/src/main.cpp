// include the library code:
#include <Arduino.h>
#include <LiquidCrystal.h>
#include "print.hpp"

// initialize the library by associating any needed LCD interface pin
// with the arduino pin number it is connected to
const int rs = 12, en = 11, d4 = 5, d5 = 4, d6 = 3, d7 = 2;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);


// data handling
void lcd_clear()
{
  lcd.clear();
}

void lcd_setCursor(int x, int y)
{
  lcd.setCursor(x, y);
}

void lcd_print(char *string)
{

  lcd.print(string);
}

// setup
void setup()
{
  lcd.begin(16, 2);
  lcd.print("hello, world!");
}

int lastReading;

// testing data
void loop()
{
  if (milis() - 2000 > lastReading)
  {
    lastReading = milis();
    lcd_clear();
    lcd_setCursor(0, 0);
    lcd_print("SomeTestData");
  }
}
