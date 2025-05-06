#!/usr/bin/python
import Adafruit_GPIO as GPIO
import Adafruit_GPIO.SPI as SPI

import mysql.connector, sys, Adafruit_DHT, datetime, time
from mysql.connector import Error
from mysql.connector import errorcode
import bmpsensor
from time import *
import pause
import RPi.GPIO as GPIO
import board
import adafruit_dht

sensor =  adafruit_dht.DHT22(board.D26)

config = {
  'host':'ServerPC',
  'user':'ken',
  'password':'test11',
  'database':'weatherstation'
}

try:
    connection = mysql.connector.connect(**config)
    if connection.is_connected():
       db_Info = connection.get_server_info()
       print("Connected to MySQL Server version ", db_Info)
       cursor = connection.cursor()
       cursor.execute("select database();")
       record = cursor.fetchone()
       cursor.close()
       print("You're connected to database: ", record)

       cursor = connection.cursor()
       cursor.execute("select delay from settings;")
       delay = cursor.fetchone() 
       connection.commit()
       cursor.close()
       delay = int(delay[0])
       delay = delay * 60
       print("Delay ", delay)
       sleep(5)

       temperature = sensor.temperature
       humidity = sensor.humidity
       while True:      

          if humidity is not None and temperature is not None or humidity < 101:
            temperature = sensor.temperature
            humidity = sensor.humidity
            temp, pressure, altitude = bmpsensor.readBmp180()
            print(pressure)
            pressure = pressure / 100
            temperature=(round(temperature,2))
            humidity=(round(humidity,4))
            mysql_insert_query = """INSERT INTO weatherdata(outtemp, outhum, pressure) VALUES ('%s','%s','%s')"""
            cursor = connection.cursor()
            record = (temperature, humidity, pressure)
            cursor.execute(mysql_insert_query, record)
            connection.commit()
            print("Record inserted successfully into table weatherdata", temperature, " ", humidity)
            cursor.close()
            sleep(delay)

          else:
            print("Error")   
            mysql_insert_query = """INSERT INTO weathererrorlog(outtemp, outhum, pressure) VALUES ('%s','%s','%s')"""
            cursor = connection.cursor()
            record = (temperature, humidity, pressure)
            cursor.execute(mysql_insert_query, record)
            connection.commit()
            cursor.close()
            sleep(5)
     
except mysql.connector.Error as error:
    print("Failed to insert record into table {}".format(error))

except KeyboardInterrupt:
    print("Exit!")
    GPIO.cleanup()

finally:
    if (connection.is_connected()):
        connection.close()
        print("MySQL connection is closed")
