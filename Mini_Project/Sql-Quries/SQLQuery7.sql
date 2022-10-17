use AirlineBooking
go

ALTER TABLE Passenger_profile
ALTER COLUMN id nchar(10);

create  DATABASE AirWing;

create Database Airline
use Airline
go
create table regtb(
  uid int primary key identity(1,1),
  FirstName nchar(80) NOT NULL,
  LastName nchar(80)NOT NULL,
  email nchar(80)NOT NULL,
  phonenumber nchar(80)NOT NULL,
  login nchar(80)NOT NULL,
  password nchar(80)NOT NULL,
  
  );

  create table Flight(
flight_id int,
airline_name varchar(30) NOT NULL,
from_location varchar(30) NOT NULL,
to_location varchar(30) NOT NULL,
departure_time DATETIME NOT NULL,
arrival_time DATETIME NOT NULL,
duration int NOT NULL,
total_seats int NOT NULL,
CONSTRAINT PK_FlightId PRIMARY KEY (flight_id)
);

INSERT INTO Flight
VALUES (101,'Air Asia','Chennai','Mumbai',CAST('2022-10-17 10:30:30' AS DateTime),CAST('2022-10-17 12:30:30' AS DateTime) ,2,230);

select * from Flight

INSERT INTO Flight
VALUES (102,'Indigo','Chennai','Kerala',CAST('2022-10-18 09:30:30' AS DateTime),CAST('2022-10-18 10:30:30' AS DateTime) ,2,150);

INSERT INTO Flight
VALUES (103,'Air India','Dehli','Mumbai',CAST('2022-11-24 08:30:25' AS DateTime),CAST('2022-11-24 11:30:30' AS DateTime) ,3,145);

INSERT INTO Flight
VALUES (104,'Lufthansa','Mumbai','Germany',CAST('2022-11-20 07:30:25 AM' AS DateTime),CAST('2022-11-21 10:30:30 AM' AS DateTime) ,22,145);

INSERT INTO Flight
VALUES (105,'Emirates','Chennai','Dubai',CAST('2022-12-12 11:30:25 AM' AS DateTime),CAST('2022-11-21 04:30:09 PM' AS DateTime) ,4,50);

INSERT INTO Flight
VALUES (106,'Sngapore Airlines','Vizag','Singapore',CAST('2022-12-18 12:30:05 PM' AS DateTime),CAST('2022-11-18 07:30:10 PM' AS DateTime) ,7,50);

INSERT INTO Flight
VALUES (107,'british airways','Chennai','London',CAST('2022-11-02 05:30:25 AM' AS DateTime),CAST('2022-11-21 03:30:09 PM' AS DateTime) ,10,15);

use Airline
go
select *from Flight