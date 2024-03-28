USE CoronaManagementSystem;

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    IdentityCard NVARCHAR(20) UNIQUE NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Street NVARCHAR(50) NOT NULL,
    Number NVARCHAR(10) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Phone NVARCHAR(15) NOT NULL,
    CellPhone NVARCHAR(15) NOT NULL,
    Photo VARBINARY(MAX)
);

CREATE TABLE SickWithCorona (
    SickID INT PRIMARY KEY IDENTITY,
    UserID INT,
    PositiveResultDate DATE,
    RecoveryDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE VaccineManufacturers (
    ManufacturerID INT PRIMARY KEY IDENTITY,
    ManufacturerName NVARCHAR(50) NOT NULL
);

CREATE TABLE VaccinationDetails (
    VaccinationID INT PRIMARY KEY IDENTITY,
    UserID INT,
    VaccineDate DATE,
    VaccineManufacturerID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (VaccineManufacturerID) REFERENCES VaccineManufacturers(ManufacturerID)
);


