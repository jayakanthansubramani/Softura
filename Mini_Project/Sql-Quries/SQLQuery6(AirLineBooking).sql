use AirlineBooking
go

create table Passenger_profile(
	id int NOT NULL,
	password varchar(30) NOT NULL,
    firstName varchar(40) NOT NULL,
	lastName varchar(40) NOT NULL,
    ph_no varchar(30) NOT NULL,
	email_id varchar(30) NOT NULL,
    CONSTRAINT PK_Passenger PRIMARY KEY (id)
);

select *from Passenger_profile

create table Flight(
flight_id int NOT NULL,
airline_name varchar(30) NOT NULL,
from_location varchar(30) NOT NULL,
to_location varchar(30) NOT NULL,
departure_time DATETIME NOT NULL,
arrival_time DATETIME NOT NULL,
duration int NOT NULL,
total_seats int NOT NULL,
CONSTRAINT PK_Flight PRIMARY KEY (flight_id)
);

select * from Flight

create table FLIGHT_DETAILS (
flight_id int,
flight_departure_date DATETIME NOT NULL,
price int NOT NULL,
available_seats int NOT NULL,
CONSTRAINT FK_FlightDetails FOREIGN KEY (flight_id)
REFERENCES Flight(flight_id)
);
ALTER TABLE FLIGHT_DETAILS
ADD CONSTRAINT PK_FlightDeparture PRIMARY KEY (flight_departure_date);
select *from FLIGHT_DETAILS

create table TICKET_INFO(
ticket_id int NOT NULL,
profile_id int,
flight_id int,
flight_departure_date DATETIME,
status varchar(20) NOT NULL,
CONSTRAINT FK_ProfileId FOREIGN KEY (profile_id)
REFERENCES Passenger_profile(id),
CONSTRAINT FK_FlightId FOREIGN KEY (flight_id)
REFERENCES Flight(flight_id),
CONSTRAINT FK_FlightDepartureDate FOREIGN KEY (flight_departure_date)
REFERENCES FLIGHT_DETAILS(flight_departure_date)
);

select * from TICKET_INFO

create table CREDIT_CARD_DETAILS(
profile_id int,
card_number varchar(20) NOT NULL,
card_type varchar(30) NOT NULL,
expiration_month varchar(8) NOT NULL,
expiration_year varchar(8) NOT NULL,
CONSTRAINT FK_Profile_id FOREIGN KEY (profile_id)
REFERENCES Passenger_profile(id),
); 

select * from CREDIT_CARD_DETAILS