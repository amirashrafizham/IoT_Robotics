from sense_hat import SenseHat
import time
import sys

sense = SenseHat()

while True:
    acceleration = sense.get_accelerometer_raw()
    gyro = sense.get_orientation()
    mag = sense.get_compass_raw()

    x = acceleration['x']
    y = acceleration['y']
    z = acceleration['z']

    x = round(x,2)
    y = round(y,2)
    z = round(z,2)

    pitch = round(gyro["pitch"],2)
    roll = round(gyro["roll"],2)
    yaw = round(gyro["yaw"],2)

    mag_x = round(mag["x"],2)
    mag_y = round(mag["y"],2)
    mag_z = round(mag["z"],2)

    print("Accelerometer: ")
    print("x={0}, y={1}, z={2}".format(x,y,z))
    print(" ")
    print("Gyroscope: ")
    print("pitch={0}, roll={1}, yaw={2}".format(pitch,roll,yaw))
    print(" ")
    print("Magnetometer: ")
    print("x={0}, y={1}, z={2}".format(mag_x,mag_y,mag_z))
    print("-------------------------------------------")



    time.sleep(3)




