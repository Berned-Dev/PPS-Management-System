DROP TABLE EMPLOYEE;
DROP TABLE CLIENT;
DROP TABLE COMPANY;
DROP TABLE PHASE;
DROP TABLE PROJECT

CREATE TABLE EMPLOYEE (
Employee_ID varchar(55) NOT NULL,
FirstName varchar(55) NOT NULL,
LastName varchar(55) NOT NULL,
Username char(10) NOT NULL,
Password char(10) NOT NULL,
CONSTRAINT Employee_ID_PK PRIMARY KEY (Employee_ID)
);

CREATE TABLE CLIENT (
Client_ID char(13) NOT NULL,
FirstName varchar(55) NOT NULL,
LastName varchar(55) NOT NULL,
Telephone_Number char(10) NOT NULL,
CONSTRAINT Client_ID_PK PRIMARY KEY (Client_ID)
);

CREATE TABLE COMPANY (
Company_ID int NOT NULL,
Company_Name varchar(55) NOT NULL,
Company_Address varchar(55) NOT NULL,
CONSTRAINT Company_ID_PK PRIMARY KEY (Company_ID)
);

CREATE TABLE PHASE (
Project_ID int NOT NULL,
Project_Phase varchar(35),
CONSTRAINTS Project_ID_PK PRIMARY KEY (Project_ID)
);

CREATE TABLE PROJECT (
Project_ID int NOT NULL,
Employee_ID varchar(55), 
Client_ID char(13), 
Company_ID int NOT NULL, 
Project_Phase varchar(35),
Project_Date date,
Project_Price money,
PRIMARY KEY (Project_ID),
FOREIGN KEY (Employee_ID) REFERENCES EMPLOYEE(Employee_ID),
FOREIGN KEY (Client_ID) REFERENCES CLIENT(Client_ID),
FOREIGN KEY (Company_ID) REFERENCES COMPANY(Company_ID)
);
