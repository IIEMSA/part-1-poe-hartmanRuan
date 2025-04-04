Use master
if EXISTS (SELECT * FROM sys.databases WHERE name = 'EventEase')
DROP DATABASE EventEase
CREATE DATABASE EventEase

USE EventEase

--Table Creation
CREATE TABLE Venue(
Venue_ID INT NOT NULL,
Venue_Name VARCHAR (50) NOT NULL,
Location VARCHAR (100) NOT NULL,
Capacity INT NOT NULL,
ImageURL VARCHAR (255) NOT NULL,
PRIMARY KEY (Venue_ID)
);

CREATE TABLE Event(
Event_ID INT NOT NULL,
Event_Name VARCHAR (50) NOT NULL,
Event_Date DATE NOT NULL,
Description VARCHAR (100) NOT NULL,
Venue_ID INT NOT NULL,
PRIMARY KEY (Event_ID),
FOREIGN KEY (Venue_ID) REFERENCES Venue(Venue_ID)
);

CREATE TABLE Booking(
Booking_ID INT NOT NULL,
Event_ID INT NOT NULL,
Venue_ID INT NOT NULL,
Booking_Date DATE NOT NULL,
PRIMARY KEY (Booking_ID),
FOREIGN KEY (Event_ID) REFERENCES Event(Event_ID),
FOREIGN KEY (Venue_ID) REFERENCES Venue(Venue_ID)
);

--Table Insertion
INSERT INTO Venue (Venue_ID, Venue_Name , Location, Capacity, ImageURL)
VALUES (1, 'Silverstar Casino' , 'Muldersdrift', 162, 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/b3/f7/7e/silverstar-casino.jpg?w=1000&h=-1&s=1'),
(2, 'Madikwe Game Reserve' , 'Groot-Marico', 30, 'https://media-cdn.tripadvisor.com/media/photo-s/18/be/d0/b4/the-main-deck-at-madikwe.jpg'),
(3, 'Kariega Game Reserve' , 'Port-Edward', 60, 'https://www.kariega.co.za/system/images/W1siZiIsIjIwMjQvMDMvMjIvMTQvNTcvMzEvNmIzMDAyNDYtZmUwNC00ZThlLWEwOWMtZGRhNjE2ZjQxNDg2L0thcmllZ2EgUml2ZXIgTG9kZ2UucG5nIl1d/Kariega%20River%20Lodge.png')

INSERT INTO Event (Event_ID, Event_Name, Event_Date, Description, Venue_ID)
Values (1, 'FNB Year-End-Party', '2025/04/10', 'FNB BANK is hosting a party for all of their employees', 1),
(2, 'Engen Managers Dinner', '2025/05/11', 'Engen Branch managers come together to celebrate another year of excellence', 2),
(3, 'Hartac Accounting Celebration', '2025/08/29', 'The Hartac Accounting group is celebrating the companies 50th year of existance', 3)

INSERT INTO Booking (Booking_ID, Event_ID, Venue_ID, Booking_Date)
VALUES (1, 1, 3, '2025/04/09'),
(2,2,2, '2025/05/10'),
(3,3,1, '2025/08/28' )


--Table Manipulation
SELECT * FROM Venue
SELECT * FROM Event
SELECT * FROM Booking