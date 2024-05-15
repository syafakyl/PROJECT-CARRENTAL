create database car_rental;

use car_rental;

create schema car_rental;

CREATE TABLE Customers (
	Id_Customer INT PRIMARY KEY IDENTITY(1,1),
    NIK BIGINT NOT NULL,
    Name NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
	Password NVARCHAR(50) NOT NULL, 
    Phone NVARCHAR(20) NOT NULL,
    Address NVARCHAR(200) NOT NULL
);

CREATE TABLE Admins (
	Id_Admin INT PRIMARY KEY IDENTITY,
	Username NVARCHAR(100) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Brand (
	Brand_Id INT PRIMARY KEY IDENTITY,
	Brand NVARCHAR(50) NOT NULL
);

CREATE TABLE Car (
    Id_Car INT PRIMARY KEY IDENTITY,
    Car_Name NVARCHAR(50) NOT NULL,
    Id_Brand INT NOT NULL,
    Plat_Number NVARCHAR(20) NOT NULL,
    Years INT NOT NULL,
    Cost INT NOT NULL,
    Car_Status NVARCHAR(50) NOT NULL DEFAULT 'Available',
    FOREIGN KEY (Id_Brand) REFERENCES Brand(Brand_Id)
);

CREATE TABLE Rental (
	Id_Rental INT PRIMARY KEY IDENTITY,
	Id_Car INT NOT NULL,
	Id_Customer INT NOT NULL,
	Date_Borrow DATETIME NOT NULL,
	Date_Return DATETIME NOT NULL,
	Total INT NOT NULL,
	FOREIGN KEY (Id_Car) REFERENCES Car(Id_Car),
	FOREIGN KEY (Id_Customer) REFERENCES Customers(Id_Customer)
);

CREATE TABLE Pengembalian (
    Id_Return INT PRIMARY KEY IDENTITY,
    Id_Rental INT NOT NULL,
    Id_Car INT NOT NULL,
    Id_Customer INT NOT NULL,
    Date_Returned DATETIME,
    Additional_Charges INT NOT NULL,
	Total INT NOT NULL,
	Status_Pengembalian NVARCHAR(50) NOT NULL DEFAULT 'Not Return'
    FOREIGN KEY (Id_Rental) REFERENCES Rental(Id_Rental),
    FOREIGN KEY (Id_Customer) REFERENCES Customers(Id_Customer),
    FOREIGN KEY (Id_Car) REFERENCES Car(Id_Car)
);

/*Trigger*/
CREATE TRIGGER TR_CalculateRentalTotal
ON Rental
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @Id_Rental INT, @Date_Borrow DATETIME, @Date_Return DATETIME, @Total INT;

    SELECT @Id_Rental = Id_Rental, @Date_Borrow = Date_Borrow, @Date_Return = Date_Return, @Total = Total
    FROM inserted;

    -- Menghitung selisih hari antara tanggal peminjaman dan pengembalian
    DECLARE @DaysDiff INT;
    SET @DaysDiff = DATEDIFF(DAY, @Date_Borrow, @Date_Return) + 1; -- Jumlah hari dihitung dari tanggal peminjaman hingga tanggal pengembalian, termasuk hari tersebut

    -- Mengupdate total biaya sewa berdasarkan jumlah hari
    IF @DaysDiff > 1
    BEGIN
        UPDATE Rental
        SET Total = @Total * @DaysDiff
        WHERE Id_Rental = @Id_Rental;
    END;
END;

CREATE TRIGGER UpdateCarStatus
ON Rental
AFTER INSERT
AS
BEGIN
    UPDATE Car
    SET Car_Status = 'Unavailable'
    FROM Car
    INNER JOIN inserted ON Car.Id_Car = inserted.Id_Car;
END;

CREATE TRIGGER UpdateCarReturn
ON Pengembalian
AFTER INSERT
AS
BEGIN
    UPDATE Car
    SET Car_Status = 'Available'
    FROM Car
    INNER JOIN inserted ON Car.Id_Car = inserted.Id_Car;
END;

CREATE TRIGGER InsertRentalDataToPengembalian
ON Rental
AFTER UPDATE
AS
BEGIN
    INSERT INTO Pengembalian (Id_Rental, Id_Car, Id_Customer, Date_Returned, Additional_Charges, Total, Status_Pengembalian)
    SELECT
        Id_Rental,
        Id_Car,
		Id_Customer,
        NULL, -- Kolom Date_Returned dikosongkan
        0,    -- Biaya tambahan awal
        Total,
        'Not Return'
    FROM inserted;
END;

/*COBA COBA*/
CREATE TRIGGER TR_Update_Pengembalian
ON Pengembalian
AFTER UPDATE
AS
BEGIN
    DECLARE @Status_Pengembalian NVARCHAR(50), @Id_Rental INT, @Date_Returned DATETIME, @Id_Car INT;

    SELECT @Status_Pengembalian = Status_Pengembalian, @Id_Rental = Id_Rental, @Date_Returned = Date_Returned, @Id_Car = Id_Car
    FROM inserted;

    IF @Status_Pengembalian = 'Return'
    BEGIN
        UPDATE Car
        SET Car_Status = 'Available'
        WHERE Id_Car = @Id_Car;

        UPDATE Pengembalian
        SET Date_Returned = GETDATE()
        WHERE Id_Rental = @Id_Rental;

        EXEC CalculateAdditionalCharges @Id_Rental;
    END;
END;

CREATE PROCEDURE CalculateAdditionalCharges
    @Id_Rental INT
AS
BEGIN
    DECLARE @Date_Returned DATETIME, @Cost INT;

    -- Mengambil nilai total dari Rental dan tanggal pengembalian
    SELECT @Date_Returned = Date_Returned
    FROM Pengembalian
    WHERE Id_Rental = @Id_Rental;

    -- Mengambil biaya mobil dari tabel Car
    SELECT @Cost = Cost
    FROM Car
    WHERE Id_Car = (SELECT Id_Car FROM Rental WHERE Id_Rental = @Id_Rental);

    IF DATEDIFF(DAY, (SELECT Date_Return FROM Rental WHERE Id_Rental = @Id_Rental), @Date_Returned) > 0
    BEGIN
        -- Menghitung tambahan biaya berdasarkan perbedaan hari
        UPDATE Pengembalian
        SET Additional_Charges = @Cost * DATEDIFF(DAY, (SELECT Date_Return FROM Rental WHERE Id_Rental = @Id_Rental), @Date_Returned)
        WHERE Id_Rental = @Id_Rental;
    END;
END;


DROP PROCEDURE CalculateAdditionalCharges;
DROP TRIGGER TR_Update_Pengembalian;
DROP TRIGGER InsertRentalDataToPengembalian;

DROP TABLE dbo.Admins;
DROP TABLE dbo.Customers;
DROP TABLE dbo.Car;
DROP TABLE dbo.Rental;
DROP TABLE dbo.Pengembalian;

SELECT * FROM Admins;
SELECT * FROM Brand;
SELECT * FROM Car;
SELECT * FROM Customers;
SELECT * FROM Rental;
SELECT * FROM Pengembalian;
SELECT * FROM Car WHERE Car_Name = 'Avanza';

SELECT Rental.*
FROM Rental
INNER JOIN Pengembalian ON Rental.Id_Rental = Pengembalian.Id_Rental
WHERE Pengembalian.Status_Pengembalian = 'Not Return';


INSERT INTO Customers (NIK, Name, Email, Password, Phone, Address) VALUES (2220010104, 'Toto James', 'toto@example.com', '123456', '081278785000', 'Depok, Beji');
INSERT INTO Admins (Username, Password, Name) VALUES ('admin', 'admin', 'Rozali Iqbal');
INSERT INTO Brand VALUES ('Honda');
INSERT INTO Car (Car_Name, Id_Brand, Plat_Number, Years, Cost) VALUES ('Brio', 2, 'BG 1717 SUV', 2021, 500000);

DELETE FROM CAR WHERE Id_Car = 4;
DELETE FROM Customers WHERE Id_Customer = 1;
DELETE FROM Rental WHERE Id_Rental = 4;

UPDATE Car 
SET 
    Car_Name = 'Avanza', 
    Id_Brand = 2, 
    Plat_Number = 'B 1717 SUV', 
    Years = 2022, 
    Cost = 550000 
WHERE 
    Id_Car = 1008;

INSERT INTO Rental (Id_Car, Id_Customer, Date_Borrow, Date_Return, Total) VALUES (1021, 3, '2024-05-09 08:00:00', '2024-05-10 08:00:00', 1500000);
INSERT INTO Rental (Id_Car, Id_Customer, Date_Borrow, Date_Return, Total) VALUES (1015, 5, '2024-05-09 08:00:00', '2024-05-13 08:00:00', 500000);
INSERT INTO Rental (Id_Car, Id_Customer, Date_Borrow, Date_Return, Total) 
VALUES (1002, 5, '2024-05-10 08:00:00', '2024-05-15 08:00:00', 1000000);

SELECT * FROM Car WHERE Car_Name = 'HRV' AND Car_Status = 'Available';
SELECT * FROM Car WHERE Car_Name = 'Avanza' AND Car_Status = 'Available';

UPDATE Pengembalian SET Status_Pengembalian = 'Return' WHERE Id_Return = 17;
UPDATE Pengembalian SET Status_Pengembalian = 'Return' WHERE Id_Return = 16;
DELETE FROM Pengembalian WHERE Id_Return = 15;
