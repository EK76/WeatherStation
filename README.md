
## Kenne's Weather Station.

I started this Visual Studio C# project in spring 2024.
Purpose for this project is to measure temperature, humidity and pressure
with help of two sensors (DHT11 and BMP180) and Raspberry PI 5.

The sensors values are stored to MySQL database from which the Kenne's Weather Station
application reads the values and show results on a computer screen, for example as diagrams.

The programming code that measure temperature, humidity and pressure
on Raspberry PI 5 is pyhton.

<details>
<summary>Show python code</summary>

```
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

sensor =  adafruit_dht(board.D26)

config = {
  'host':'ServerPC',
  'user':'ken',
  'password':'*******',
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
       delay = 600
       sleep(5)

       temperature = sensor.temperature
       humidity = sensor.humidity
       while True:      
          
          if humidity is not None and temperature is not None or humidity < 101:
            print("Part 1!")
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
```

</details>

In order to use this application, you must create following database and tables 
according to the directive below.

```
create database weatherstation;
use weatherstation;

create table settings (
   id int not null auto_increment,
   color varchar(100),
   delay int,
   primary key(id)
);

create table weatherdata (
    id int not null auto_increment,
    outtemp decimal(3,1),
    outhum decimal(4,1),
    pressure decimal(6,2),
    date_created datetime (current_timestamp);,
    primary key(id)
);

create table weathererrorlog (
    id int not null auto_increment,
    outtemp decimal(3,1),
    outhum decimal(4,1),
    pressure decimal(6,2),
    date_created datetime (current_timestamp);,
    primary key(id)
);

```
### After creation of database and tables are done.
- Edit configdb.txt file with the correct info about your MySQL credentials.
- Compaile or publish the project with Visual Studio 2022 to test it.

#### How to clone this repository with git.
  
  `https://github.com/EK76/WeatherStation.git`

  ### Pictures that show how the application looks like.

![image](https://github.com/user-attachments/assets/01d002e4-b189-48a3-bcea-1bdc485c766d)

![pic1](https://github.com/user-attachments/assets/2c27e1d7-bb88-4326-8feb-b193035f79b2)

**If you discover any fault or inaccurate information, feel free to contact me trough
epost address: ken.ekholm@live.com**
