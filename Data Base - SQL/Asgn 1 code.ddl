-- Create the Address table
CREATE TABLE Address (
    Add_ID INT PRIMARY KEY,
    HouseNum VARCHAR(255),
    POBox VARCHAR(255),
    StreetName VARCHAR(255),
    City VARCHAR(255),
    State VARCHAR(2),
    Zipcode VARCHAR(10)
);

-- Create the Phone table
CREATE TABLE Phone (
    Ph_ID INT PRIMARY KEY,
    Per_ID INT,
    AreaCode VARCHAR(5),
    Exchange VARCHAR(5),
    Extension VARCHAR(10),
    CType VARCHAR(20),
    FOREIGN KEY (Per_ID) REFERENCES Person(Per_ID)
);

-- Create the Person table
CREATE TABLE Person (
    Per_ID INT PRIMARY KEY,
    Fname VARCHAR(255),
    Lname VARCHAR(255),
    DOB DATE,
    Gender VARCHAR(10),
    Add_ID INT,
    FOREIGN KEY (Add_ID) REFERENCES Address(Add_ID)
);

-- Create the Pet table
CREATE TABLE Pet (
    Pet_ID INT PRIMARY KEY,
    Breed VARCHAR(255),
    Height DECIMAL(5, 2),
    Weight DECIMAL(5, 2),
    Gender VARCHAR(10),
    Species VARCHAR(255),
    Name VARCHAR(255)
);

-- Create the Ownership table
CREATE TABLE Ownership (
    Own_ID INT PRIMARY KEY,
    Per_ID INT,
    Pet_ID INT,
    FOREIGN KEY (Per_ID) REFERENCES Person(Per_ID),
    FOREIGN KEY (Pet_ID) REFERENCES Pet(Pet_ID)
);
