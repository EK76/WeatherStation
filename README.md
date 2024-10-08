
<svg xmlns="http://www.w3.org/2000/svg" width="400px" height="110px" text-anchor="middle">
  <defs>
    <style>
      @font-face {
        font-family: "Carlito";
        src: url(data:application/font-ttf;charset=utf-8;base64,base64_data);
        font-weight: normal;
        font-style: normal;
      }
      .heading {
        font-family: "Carlito";
        font-size: 36px;
        fill: #3B3838;
        letter-spacing: 4px;
        text-transform: uppercase;
      }
      .sub-heading {
        font-family: "Carlito";
        font-size: 20px;
        fill: #767171;
        letter-spacing: 0.5px;
      }
    </style>
  </defs>



## Kenne's Weather Station.

I started this Visual Studio C# project in spring 2024.
Purpose for this project is to measure, temperature, humidity and pressure
with help of two sensors (DHT11 and BMP180) and Raspberry PI 5.

The sensors values are stored to MySQL database from which the Kenne's Weather Station
application reads the values and show results on a computer screen as for example diagram.

If you discover any fault or inaccurate information, feel free to contact me trough
epost address: ken.ekholm@live.com

![image](https://github.com/user-attachments/assets/01d002e4-b189-48a3-bcea-1bdc485c766d)

![pic1](https://github.com/user-attachments/assets/2c27e1d7-bb88-4326-8feb-b193035f79b2)

In order to use this application, you must create following database and tables 
according to the directive below.

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
