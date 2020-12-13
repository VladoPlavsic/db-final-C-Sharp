/*
USE school;
GRANT ALTER ON role::Couriers TO Admins;
GRANT ALTER ANY USER TO Admins;
EXEC sp_addrolemember db_securityadmin, 'polina';
*/
/*INSERT INTO Clients VALUES (N'Горбачева Полина Русланова', N'Вавилова улица', '+76558798545', 'gorbacheva-polina01@mail.ru','client1', 'password1');
*/
SELECT * FROM Orders;
SELECT * FROM Delivery;
SELECT * FROM Clients;