USE school
GO
PRINT('Category');


INSERT INTO Category VALUES (N'�������');
INSERT INTO Category VALUES (N'�����');
INSERT INTO Category VALUES (N'�����');
INSERT INTO Category VALUES (N'�������');

PRINT('Clients');

INSERT INTO Clients VALUES (N'��������� ������ ���������', N'�������� �����', '+76558798545', 'gorbacheva-polina01@mail.ru','client1', 'password1');
INSERT INTO Clients VALUES (N'�������� ������� ��������', N'������������� ��������', '+79046002212', 'prohorov01@mail.ru', 'client2','password2');
INSERT INTO Clients VALUES (N'�������� ��������� ���������', N'��������� 4-� �����', '+79597164424','polyak033@mail.ru', 'client3','password3');
INSERT INTO Clients VALUES (N'������ ������ ���������', N'�������� �����', '+79728290334','misha.poi@yandex.ru', 'client4','password4');
INSERT INTO Clients VALUES (N'������� ������� ������������', N'����������� ����������', '+79277024684', 'jutighhh@mail.ru', 'client5','password5');
INSERT INTO Clients VALUES (N'������� ������� ����������', N'����������� �����', '+79399495538','loombira@gmail.com','client6', 'password6');
INSERT INTO Clients VALUES (N'������� ����� ����������', N'�������� ������', '+79357532222', 'vlado021@mail.ru', 'client7','password7');
INSERT INTO Clients VALUES (N'��������� ��� ��������', N'������������� �����', '+79718086176', 'mishka.r2@mail.ru', 'client8','password8');
INSERT INTO Clients VALUES (N'��������� ��������� Ը�������', N'����������� �����', '+79399108532', 'pavlova.n@gmail.com', 'client9','password9');
INSERT INTO Clients VALUES (N'�������� ���� ��������', N'������������� ����', '+79930223305', 'uml@mail.ri', 'client10','password10');

PRINT('Paint');

INSERT INTO Paint VALUES(N'��������');
INSERT INTO Paint VALUES(N'�����');
INSERT INTO Paint VALUES(N'�������');
INSERT INTO Paint VALUES(N'�����');
INSERT INTO Paint VALUES(N'�����');

PRINT('Delivery');

INSERT INTO Delivery VALUES(N'���������� �����')
INSERT INTO Delivery VALUES(N'������ ������')
INSERT INTO Delivery VALUES(N'�������� �����')
INSERT INTO Delivery VALUES(N'������� �����')
INSERT INTO Delivery VALUES(N'��������� ������')

PRINT('Couriers');

INSERT INTO Couriers VALUES(N'������� ����', 1)
INSERT INTO Couriers VALUES(N'������ ����� ��', 2)
INSERT INTO Couriers VALUES(N'��� ��� ��', 3)

PRINT('Wood');

INSERT INTO Wood VALUES(N'���');
INSERT INTO Wood VALUES(N'�����');
INSERT INTO Wood VALUES(N'���');

PRINT('Colors');

INSERT INTO Colors VALUES(N'�������');
INSERT INTO Colors VALUES(N'Ƹ����');
INSERT INTO Colors VALUES(N'�������');


/*
PRINT('Orders');

EXEC make_order @client_id = 1, 
	@category_id = 1,
	@paint_id = 2,
	@frame_id = 2,
	@delivery_id = 5;
GO

EXEC make_order @client_id = 1, 
	@category_id = 3,
	@paint_id = 2,
	@frame_id = 2,
	@delivery_id = 2;
GO

EXEC make_order @client_id = 4, 
	@category_id = 3,
	@paint_id = 3,
	@frame_id = 2,
	@delivery_id = 3;
GO

EXEC make_order @client_id = 4, 
	@category_id = 3,
	@paint_id = 2,
	@frame_id = 2,
	@delivery_id = 3;
GO

EXEC make_order @client_id = 4, 
	@category_id = 3,
	@paint_id = 2,
	@frame_id = 1,
	@delivery_id = 5;
GO
*/

