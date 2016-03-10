# this script turns on the LED when button is pressed and turns it off when button is released

import time as t

# in VS
import gpio as GPIO
# on Rasp
# import RPi.GPIO as GPIO


print("Script started")

_pin_output_led_red = 14
_pin_input_button = 15

GPIO.setmode(GPIO.BCM)

GPIO.setup(_pin_output_led_red, GPIO.OUT)
GPIO.setup(_pin_input_button, GPIO.IN, GPIO.PUD_UP)

while True:
    if GPIO.input(_pin_input_button) == False:
        print("Button pressed")
        GPIO.output(_pin_output_led_red, GPIO.HIGH)
    else:
        print("Button released")
        GPIO.output(_pin_output_led_red, GPIO.LOW)
    t.sleep(0.01)
