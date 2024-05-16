CREATE TABLE Servicess
(
    Id INT PRIMARY KEY IDENTITY,
    ServiceName NVARCHAR(50),
    Price DECIMAL(18,2),
    Cost DECIMAL(18,2)
);

CREATE TABLE Customers
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    PhoneNumber NVARCHAR(20),
    ServiceId INT,
    FOREIGN KEY (ServiceId) REFERENCES Servicess(Id)
);

CREATE TABLE Appointments
(
    Id INT PRIMARY KEY IDENTITY,
    CustomerId INT,
    AppointmentTime DATETIME,
    FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
);
