
/*DO NOT DELETE ANYTHONG AFTER THIS LINE*/


CREATE DATABASE school;
GO
USE school;
GO


EXEC sp_configure 'CONTAINED DATABASE AUTHENTICATION', 1
GO
RECONFIGURE
GO


USE master
GO
ALTER DATABASE school SET CONTAINMENT = PARTIAL
GO

USE school

CREATE TABLE Category(
id INT PRIMARY KEY IDENTITY(1,1),
category NVARCHAR(20),
UNIQUE(category));
GO

CREATE TABLE Paint(
id INT PRIMARY KEY IDENTITY(1,1),
paint NVARCHAR(10),
UNIQUE (paint));
GO

CREATE TABLE Colors(
id INT PRIMARY KEY IDENTITY(1,1),
color NVARCHAR(15));
GO

CREATE TABLE Wood(
id INT PRIMARY KEY IDENTITY(1,1),
wood NVARCHAR(15));
GO

CREATE TABLE Frames(
id INT PRIMARY KEY IDENTITY(1,1),
color_id INT,
wood_id INT,
FOREIGN KEY (color_id) REFERENCES Colors(id) ON DELETE CASCADE,
FOREIGN KEY (wood_id) REFERENCES Wood(id) ON DELETE CASCADE,
UNIQUE(color_id, wood_id));
GO

CREATE TABLE Clients(
id INT PRIMARY KEY IDENTITY(1,1),
fio NVARCHAR(50),
adress NVARCHAR(50),
tel VARCHAR(12),
email VARCHAR(50),
username VARCHAR(50),
client_password VARCHAR(50),
UNIQUE(username),
UNIQUE (email));
GO

CREATE TABLE Delivery(
id INT PRIMARY KEY IDENTITY(1,1),
adress NVARCHAR(50),
UNIQUE (adress));
GO

CREATE TABLE Couriers(
id INT PRIMARY KEY IDENTITY(1,1),
fio NVARCHAR(50),
delivery_id INT,
FOREIGN KEY (delivery_id) REFERENCES Delivery(id),
UNIQUE (delivery_id));
GO

CREATE TABLE Orders(
id INT PRIMARY KEY IDENTITY(1,1),
client_id INT,
category_id INT,
paint_id INT,
frame_id INT,
courier_id INT,
FOREIGN KEY (client_id) REFERENCES Clients(id) ON DELETE CASCADE,
FOREIGN KEY (category_id) REFERENCES Category(id),
FOREIGN KEY (paint_id) REFERENCES Paint(id),
FOREIGN KEY (frame_id) REFERENCES Frames(id),
FOREIGN KEY (courier_id) REFERENCES Couriers(id),
);
GO

CREATE PROCEDURE usp_GetErrorInfo  
AS  
SELECT  
    ERROR_NUMBER() AS ErrorNumber  
    ,ERROR_SEVERITY() AS ErrorSeverity  
    ,ERROR_STATE() AS ErrorState  
    ,ERROR_PROCEDURE() AS ErrorProcedure  
    ,ERROR_LINE() AS ErrorLine  
    ,ERROR_MESSAGE() AS ErrorMessage;  
GO  
  

/*TRIGGERS*/

CREATE OR ALTER TRIGGER on_insert_colors ON Colors
AFTER INSERT
AS
BEGIN

	DECLARE @wood_id INT;

	DECLARE wood_cursor CURSOR FOR 
		SELECT id FROM Wood;
	OPEN wood_cursor;
	FETCH NEXT FROM wood_cursor INTO @wood_id; 
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO Frames VALUES ((SELECT id FROM inserted), @wood_id);
		FETCH NEXT FROM wood_cursor INTO @wood_id; 
	END;
	CLOSE wood_cursor;
	DEALLOCATE wood_cursor;
END;
GO

CREATE OR ALTER TRIGGER on_insert_wood ON Wood
AFTER INSERT
AS
BEGIN

	DECLARE @color_id INT;

	DECLARE color_cursor CURSOR FOR 
		SELECT id FROM Colors;
	OPEN color_cursor;
	FETCH NEXT FROM color_cursor INTO @color_id; 
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO Frames VALUES (@color_id,(SELECT id FROM inserted));
		FETCH NEXT FROM color_cursor INTO @color_id; 
	END;
	CLOSE color_cursor;
	DEALLOCATE color_cursor;
END;
GO



/*FUNCTIONS*/

CREATE OR ALTER FUNCTION frames_view_function()
RETURNS TABLE
AS
RETURN
	(SELECT Frames.id, Colors.color, Wood.wood FROM Colors INNER JOIN Frames ON Frames.color_id = Colors.id INNER JOIN Wood ON Frames.wood_id = Wood.id)
GO

CREATE OR ALTER FUNCTION id_by_name(@category NVARCHAR(50), @paint NVARCHAR(50), @color NVARCHAR(50), @wood NVARCHAR(50), @adress NVARCHAR(50))
RETURNS TABLE
AS
RETURN (SELECT Category.id AS category, Paint.id AS paint, Frames.id AS frame, Delivery.id AS adress FROM Category
		INNER JOIN Paint ON paint LIKE '%' + @paint + '%'
		INNER JOIN Frames ON color_id = (SELECT id FROM Colors WHERE color LIKE '%' + @color + '%') AND wood_id = (SELECT id FROM Wood WHERE wood LIKE '%' + @wood + '%')
		INNER JOIN Delivery ON adress LIKE '%' + @adress + '%' WHERE Category.category LIKE '%' + @category + '%')
GO


CREATE OR ALTER VIEW frames_view AS
SELECT * FROM frames_view_function();
GO


CREATE OR ALTER FUNCTION orders_view_function()
RETURNS TABLE
AS
RETURN
	(SELECT Clients.fio AS client_fio, Clients.adress AS client_adress, Clients.tel AS client_tel, Category.category, Paint.paint, Couriers.fio AS courier_fio, Colors.color, Wood.wood, Orders.id FROM Clients 
	INNER JOIN Orders ON Orders.client_id = Clients.id 
	INNER JOIN Category ON Orders.category_id = Category.id
	INNER JOIN Paint ON Orders.paint_id = Paint.id
	INNER JOIN Couriers ON Orders.courier_id = Couriers.id
	INNER JOIN Colors ON (SELECT color_id FROM Frames WHERE id = Orders.frame_id) = Colors.id
	INNER JOIN Wood ON (SELECT wood_id FROM Frames WHERE id = Orders.frame_id) = Wood.id);
	
GO
CREATE OR ALTER VIEW order_view AS 
SELECT * FROM orders_view_function();
GO

/*CLIENT INTERFACE*/
CREATE OR ALTER FUNCTION client_exists_id (@client_id INT)
RETURNS INT
AS
BEGIN
IF (SELECT COUNT(id) FROM Clients WHERE id = @client_id) > 0
RETURN 1
RETURN 0
END;
GO

CREATE OR ALTER FUNCTION client_exists_email (@client_email VARCHAR(50))
RETURNS INT
AS
BEGIN
IF (SELECT COUNT(id) FROM Clients WHERE email = @client_email) > 0
RETURN 1
RETURN 0
END;
GO

CREATE OR ALTER VIEW available_adreses
AS SELECT * FROM Delivery WHERE id IN (SELECT delivery_id FROM Couriers);
GO

CREATE OR ALTER VIEW unavailable_adreses
AS SELECT * FROM Delivery WHERE id NOT IN (SELECT delivery_id FROM Couriers);
GO


CREATE OR ALTER PROCEDURE make_order
	@client_id INT,
	@category_id INT,
	@paint_id INT,
	@frame_id INT,
	@delivery_id INT
AS
BEGIN
BEGIN TRY
	INSERT INTO Orders VALUES (@client_id, @category_id, @paint_id, @frame_id, (SELECT id FROM Couriers WHERE delivery_id = @delivery_id));
END TRY
BEGIN CATCH
	EXECUTE usp_GetErrorInfo;
END CATCH;
END;
GO

CREATE OR ALTER FUNCTION clients_order_view_function_id (@client_id INT)
RETURNS TABLE
AS
RETURN (SELECT * FROM order_view WHERE id IN (SELECT id FROM Orders WHERE client_id = @client_id));
GO

CREATE OR ALTER PROCEDURE drop_order 
	@order_id INT,
	@client_id INT
AS 
BEGIN
	DECLARE @count INT;
	SELECT @count = count(id) FROM Orders WHERE id = @order_id AND client_id = @client_id;
IF @count > 0
	DELETE FROM Orders WHERE id = @order_id;
ELSE
	THROW 51000, 'Given order does not exist for current client.', 1;
END;
GO

CREATE OR ALTER FUNCTION get_id_from_username (@username VARCHAR(20))
RETURNS TABLE
AS
RETURN (SELECT id AS client_id FROM Clients WHERE username LIKE '%' + @username + '%');
GO

CREATE OR ALTER PROCEDURE register_client
	@fio NVARCHAR(50),
	@adress NVARCHAR(50),
	@tel VARCHAR(12),
	@email VARCHAR(50),
	@username VARCHAR(50),
	@password VARCHAR(50)
AS
BEGIN
BEGIN TRY
	INSERT INTO Clients VALUES (@fio,@adress, @tel, @email, @username, @password); 
END TRY
BEGIN CATCH
	EXECUTE usp_GetErrorInfo;
END CATCH;
END;
GO

/*COURIER INTERFACE*/

CREATE OR ALTER FUNCTION courier_view_function (@courier_id INT)
RETURNS TABLE
AS 
RETURN (SELECT * FROM order_view WHERE id IN (SELECT id FROM Orders WHERE courier_id = @courier_id));
GO

CREATE OR ALTER PROCEDURE product_delivered
	@order_id INT,
	@courier_id INT
AS
BEGIN
	DECLARE @count INT;
	SELECT @count = count(id) FROM Orders WHERE id = @order_id AND courier_id = @courier_id;
IF @count > 0
	DELETE FROM Orders WHERE id = @order_id;
ELSE
	THROW 51000, 'Given order does not exist.', 1;
END;
GO




CREATE OR ALTER FUNCTION get_category()
RETURNS INTEGER
AS
BEGIN
	IF IS_ROLEMEMBER ('Admins') = 1
		RETURN 0;
	ELSE IF IS_ROLEMEMBER ('Couriers') = 1
		RETURN 1;
	ELSE IF IS_ROLEMEMBER ('Clients') = 1
		RETURN 2;
	RETURN-1;
END;
GO


GO
CREATE OR ALTER TRIGGER courier_insert_trigger ON Couriers
AFTER INSERT
AS
BEGIN

	DECLARE @courier_id VARCHAR(10);
	DECLARE @cmd VARCHAR(100);
	DECLARE @add VARCHAR(100);
	DECLARE @password VARCHAR(10);
	SELECT @courier_id = CONVERT(VARCHAR,id) FROM inserted;
	SET @cmd = 'CREATE USER user_' + @courier_id + ' WITH PASSWORD = ''password''';
	SET @add = 'ALTER ROLE Couriers ADD MEMBER user_' + @courier_id;
	EXEC (@cmd);
	EXEC (@add);
END;
GO

CREATE OR ALTER TRIGGER courier_delete_trigger ON Couriers
AFTER DELETE
AS
BEGIN

	DECLARE @courier_id VARCHAR(10);
	DECLARE @cmd VARCHAR(100);
	SELECT @courier_id = CONVERT(VARCHAR,id) FROM deleted;
	SET @cmd = 'DROP USER user_' + @courier_id;
	EXEC (@cmd);
END;
GO


CREATE OR ALTER TRIGGER client_insert_trigger ON Clients
AFTER INSERT
AS
BEGIN

	DECLARE @username VARCHAR(50);
	DECLARE @password VARCHAR(50);
	DECLARE @cmd VARCHAR(100);
	DECLARE @add VARCHAR(100);


	SELECT @password = client_password FROM inserted
	SELECT @username = username FROM inserted
	
	SET @cmd = 'CREATE USER ' + @username + ' WITH PASSWORD = ''' + @password + '''';
	SET @add = 'ALTER ROLE Clients ADD MEMBER ' + @username;
	EXEC (@cmd);
	EXEC (@add);
END;
GO

CREATE OR ALTER TRIGGER client_delete_trigger ON Clients
AFTER DELETE
AS
BEGIN

	DECLARE @username VARCHAR(50);
	DECLARE @cmd VARCHAR(100);
	SELECT @username = username FROM deleted;
	SET @cmd = 'DROP USER ' + @username;
	EXEC (@cmd);
END;
GO



/*PROCEDURES*/

USE school;

/*INSERT PROCEDURES*/
GO
CREATE OR ALTER PROCEDURE insert_category
	@category NVARCHAR(20)
AS
BEGIN
	INSERT INTO Category VALUES (@category);
END;
GO

GO
CREATE OR ALTER PROCEDURE insert_paint
	@paint NVARCHAR(20)
AS
BEGIN
	INSERT INTO Paint VALUES (@paint);
END;
GO

GO
CREATE OR ALTER PROCEDURE insert_colors
	@colors NVARCHAR(20)
AS
BEGIN
	INSERT INTO Colors VALUES (@colors);
END;
GO

GO
CREATE OR ALTER PROCEDURE insert_wood
	@wood NVARCHAR(20)
AS
BEGIN
	INSERT INTO Wood VALUES (@wood);
END;
GO

GO
CREATE OR ALTER PROCEDURE insert_courier
	@courier NVARCHAR(20),
	@address NVARCHAR(50)
AS
BEGIN
	INSERT INTO Couriers VALUES (@courier, (SELECT id FROM Delivery WHERE adress LIKE '%' + @address + '%'));
END;
GO

GO
CREATE OR ALTER PROCEDURE insert_delivery
	@address NVARCHAR(20)
AS
BEGIN
	INSERT INTO Delivery VALUES (@address);
END;
GO




/*DELETE PROCEDURES*/
GO
CREATE OR ALTER PROCEDURE delete_category
	@id INT
AS
BEGIN
	DELETE FROM  Category WHERE id = @id;
END;
GO

GO
CREATE OR ALTER PROCEDURE delete_paint
	@id INT
AS
BEGIN
	DELETE FROM  Paint WHERE id = @id;
END;
GO

GO
CREATE OR ALTER PROCEDURE delete_colors
	@id INT
AS
BEGIN
	DELETE FROM  Colors WHERE id = @id;
END;
GO
GO

GO
CREATE OR ALTER PROCEDURE delete_wood
	@id INT
AS
BEGIN
	DELETE FROM  Wood WHERE id = @id;
END;
GO

GO
CREATE OR ALTER PROCEDURE delete_courier
	@id INT
AS
BEGIN
	DELETE FROM  Couriers WHERE id = @id;
END;
GO

GO
CREATE OR ALTER PROCEDURE delete_delivery
	@id INT
AS
BEGIN
	DELETE FROM  Delivery WHERE id = @id;
END;
GO



/*DELETE Clinets PROCEDURE*/
GO
CREATE OR ALTER PROCEDURE delete_client
	@id INT
AS
BEGIN
	DELETE FROM  Clients WHERE id = @id;
END;
GO


GO
CREATE OR ALTER VIEW admin_client_view AS
SELECT id,fio,adress,tel,email,username FROM Clients;
GO




/*CLR FUNCTION*/
EXEC sp_configure 'show advanced options',1;
GO
RECONFIGURE;
GO
EXEC sp_configure 'clr strict security',0;
GO
RECONFIGURE;
GO
EXEC sp_configure 'clr enabled', 1;  RECONFIGURE WITH OVERRIDE;
GO

USE school;
CREATE ASSEMBLY custom_clr FROM 'C:\dev\Polya\Shop\CLRFunction\bin\Debug\CLRFunction.dll';
GO

GO
CREATE OR ALTER FUNCTION custom_clr_function(@email NVARCHAR(50))
RETURNS BIT
AS
EXTERNAL NAME custom_clr.[CLRFunction.CLR].CheckEmail
GO



/*CREATE ROLES*/
CREATE ROLE Clients;
CREATE ROLE Admins;
CREATE ROLE Couriers;



/*Admin PRIVILEGES*/
CREATE USER polina FROM LOGIN polina;
GO

EXEC sp_addrolemember 'Admins', 'polina';
GRANT ALTER ON role::Couriers TO Admins;
GRANT ALTER ANY USER TO Admins;
EXEC sp_addrolemember db_securityadmin, 'polina';

GRANT EXEC ON insert_courier TO Admins;
GRANT EXEC ON delete_courier TO Admins;

GRANT EXEC ON insert_category TO Admins;
GRANT EXEC ON delete_category TO Admins;

GRANT EXEC ON insert_paint TO Admins;
GRANT EXEC ON delete_paint TO Admins;

GRANT EXEC ON insert_colors TO Admins;
GRANT EXEC ON delete_colors TO Admins;

GRANT EXEC ON insert_wood TO Admins;
GRANT EXEC ON delete_wood TO Admins;

GRANT EXEC ON insert_delivery TO Admins;
GRANT EXEC ON delete_delivery TO Admins;

GRANT SELECT ON admin_client_view TO Admins;
GRANT EXEC ON delete_client TO Admins;


GRANT SELECT ON Category TO Admins;
GRANT SELECT ON Colors TO Admins;
GRANT SELECT ON Delivery TO Admins;
GRANT SELECT ON Frames TO Admins;
GRANT SELECT ON Paint TO Admins;
GRANT SELECT ON Wood TO Admins;
GRANT SELECT ON Couriers TO Admins;

GRANT EXEC ON get_category TO Admins;
GRANT SELECT ON unavailable_adreses TO Admins;


/*Client PRIVILEGES*/
GRANT EXEC ON get_category TO Clients;

GRANT SELECT ON available_adreses TO Clients;
GRANT SELECT ON Category TO Clients;
GRANT SELECT ON Colors TO Clients;
GRANT SELECT ON Delivery TO Clients;
GRANT SELECT ON Orders TO Clients;
GRANT SELECT ON Frames TO Clients;
GRANT SELECT ON Paint TO Clients;
GRANT SELECT ON Wood TO Clients;

GRANT SELECT ON id_by_name TO Clients;
GRANT SELECT ON clients_order_view_function_id TO Clients;
GRANT SELECT ON get_id_from_username TO Clients;

GRANT EXECUTE ON custom_clr_function TO Clients;

GRANT EXECUTE ON make_order TO Clients;
GRANT EXECUTE ON drop_order TO Clients;
GRANT EXECUTE ON register_client TO Clients;
GRANT EXECUTE ON client_exists_id TO Clients;
GRANT EXECUTE ON client_exists_email TO Clients;

/*Courier PRIVILEGES*/
GRANT SELECT ON courier_view_function TO Couriers;
GRANT EXEC ON product_delivered TO Couriers;
GRANT EXEC ON get_category TO Couriers;

/*Registration PRIVILEGES*/
CREATE USER register WITH PASSWORD='register';
GRANT ALTER ON role::Clients TO register;
GRANT ALTER ANY USER TO register;
GRANT EXECUTE ON register_client TO register;
GRANT EXECUTE ON custom_clr_function TO register;
EXEC sp_addrolemember db_securityadmin, 'register';


