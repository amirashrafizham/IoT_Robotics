from sense_hat import SenseHat
import time
import sys


sense = SenseHat()
sense.clear()


try:
    while True:

        sense.show_message("DAQ")
        temp= sense.get_temperature()
        temp = round(temp,1)
        print("Temperature [C]: ",temp)

        humidity = sense.get_humidity()
        humidity = round(humidity,1)
        print("Humidity [%]:",humidity)

        pressure = sense.get_pressure()
        pressure = round(pressure,1)
        print("Pressure [hPa]: ",pressure) 

        print("---------------------------")
        #sense.show_message(str(temp)+"C "+str(humidity)+"% "+str(pressure)+"bar ")
         

except KeyboardInterrupt:
    pass


sense.clear()

