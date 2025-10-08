
## Weather Station.

I started this Visual Studio C# project in spring 2024.
Purpose for this project is to measure temperature, humidity and pressure
with help of two sensors (DHT11 and BMP180) and Raspberry PI 5.

![image](https://github.com/user-attachments/assets/bf30352a-59cb-4e20-9109-404ea8a64ff6) DHT22 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ![image](https://github.com/user-attachments/assets/322ec1e0-5bf2-49c0-96a0-3c0c5373fa87) &nbsp;&nbsp;&nbsp;&nbsp; BMP180

DHT22 is temperature and humitidy sensor.<br>
BMP180 is temperature, pressure and altitude sensor.

#### ***My schema***
![image](https://github.com/user-attachments/assets/77bf3104-98cf-4979-9a0b-eb2b505b831e) 

- Sensor DHT22 is connected to Rasepberry PI 5's pin 37 (GPIO 26).
Trough GPIO26 Raspberry PI 5 reads the temperature and humitidy
from sensor.

- Sensor BMP180 is connected to Rasepberry PI 5's pin 3 (GPIO 2,SDA)
and pin 5 (GPIO 3, SCL). Trough these pins Raspberry PI 5 reads the 
pressure fom sensor.

- GPIO 2 SDA (Serial Data Line) , whose pin is used to transmit data between 
the Raspberry Pi5 and the I2C device. 

- GPIO 3 SCL (Serial Clock Line), whose pin is used to provide the clock signal
that synchronizes the communication between the Raspberry Pi and 
the I2C device.

- I2C is a two-wire serial communication protocol using a serial data line (SDA)
  and a serial clock line (SCL).

---
The sensors values are stored to MySQL database from which the Weather Station
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

sensor =  adafruit_dht.DHT22(board.D26)

config = {
  'host':'ServerPC',
  'user':'ken',
  'password':'*****',
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

```
</details>

In order to use this application, you must create following database and tables 
according to the directive below.

As mention MySQL have been chosen as database language for this project.

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

create table delaylog(
  id int not null auto_increment,
  logdate datetime default CURRENT_TIMESTAMP,
  delayvalue varchar(255),
  primary key(id)
);

```
### After creation of database and tables are done.
- Edit configdb.txt file with the correct info about your MySQL credentials with text editor of your choosing.
- Compaile or publish the project with Visual Studio 2022 to test it.

I have also installed MySql.Data plugin from Oracle Corporation trough Visual Studio NuGet Package Manager when I developed this project. 
MySql.Data makes it easier to read from and make changes to MySQL database when using Visual Studio.
  
> [!NOTE]
>  **You can also edit your MySQL credentials with the WeatherStation application.**<br><br>
>  **If configdb.txt file is missing, then WeatherStaion application will redirect you to a page where you can create the file with your MySQL credentials info.**


#### How to clone this repository with git.
  
  `https://github.com/EK76/WeatherStation.git`

### Pictures that show how the application looks like.

![image](https://github.com/user-attachments/assets/01d002e4-b189-48a3-bcea-1bdc485c766d)

![pic1](https://github.com/user-attachments/assets/2c27e1d7-bb88-4326-8feb-b193035f79b2)

**If you discover any fault or inaccurate information, feel free to contact me trough
epost address: ken.ekholm@live.com**
