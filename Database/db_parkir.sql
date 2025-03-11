-- Buat Database
CREATE DATABASE ParkingSystem

-- Tabel User/Operator
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL, -- Admin/Operator/Kasir
    LastLogin DATETIME,
    Status BIT DEFAULT 1
)

-- Tabel Jenis Kendaraan
CREATE TABLE VehicleTypes (
    TypeID INT PRIMARY KEY IDENTITY(1,1),
    TypeName VARCHAR(50) NOT NULL,
    BaseRate DECIMAL(10,2) NOT NULL,
    HourlyRate DECIMAL(10,2) NOT NULL
)

-- Tabel Parkir
CREATE TABLE Parking (
    ParkingID INT PRIMARY KEY IDENTITY(1,1),
    TicketNo VARCHAR(20) UNIQUE NOT NULL,
    PlateNumber VARCHAR(20) NOT NULL,
    VehicleTypeID INT FOREIGN KEY REFERENCES VehicleTypes(TypeID),
    EntryTime DATETIME DEFAULT GETDATE(),
    ExitTime DATETIME NULL,
    EntryPhoto VARCHAR(255),
    ExitPhoto VARCHAR(255),
    EntryOperatorID INT FOREIGN KEY REFERENCES Users(UserID),
    ExitOperatorID INT FOREIGN KEY REFERENCES Users(UserID),
    Status VARCHAR(20) DEFAULT 'Active', -- Active/Completed/Cancelled
    ParkingFee DECIMAL(10,2) DEFAULT 0,
    IsPaid BIT DEFAULT 0
)

-- Tabel Member
CREATE TABLE Members (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    MemberNo VARCHAR(20) UNIQUE NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    PlateNumber VARCHAR(20) NOT NULL,
    VehicleTypeID INT FOREIGN KEY REFERENCES VehicleTypes(TypeID),
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    Status BIT DEFAULT 1
)