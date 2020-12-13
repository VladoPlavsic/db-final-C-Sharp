USE school
GO
PRINT('Category');


INSERT INTO Category VALUES (N'Фиильмы');
INSERT INTO Category VALUES (N'Книги');
INSERT INTO Category VALUES (N'Аниме');
INSERT INTO Category VALUES (N'Фэнтези');

PRINT('Clients');

INSERT INTO Clients VALUES (N'Горбачева Полина Русланова', N'Вавилова улица', '+76558798545', 'gorbacheva-polina01@mail.ru','client1', 'password1');
INSERT INTO Clients VALUES (N'Прохоров Евгений Артёмович', N'Водопроводный переулок', '+79046002212', 'prohorov01@mail.ru', 'client2','password2');
INSERT INTO Clients VALUES (N'Полякова Елизавета Никитична', N'Кабельная 4-я улица', '+79597164424','polyak033@mail.ru', 'client3','password3');
INSERT INTO Clients VALUES (N'Озеров Михаил Андреевич', N'Косыгина улица', '+79728290334','misha.poi@yandex.ru', 'client4','password4');
INSERT INTO Clients VALUES (N'Никулин Георгий Владимирович', N'Кадашёвская набережная', '+79277024684', 'jutighhh@mail.ru', 'client5','password5');
INSERT INTO Clients VALUES (N'Нечаева Евгения Алексеевна', N'Нагатинская пойма', '+79399495538','loombira@gmail.com','client6', 'password6');
INSERT INTO Clients VALUES (N'Наумова Алиса Данииловна', N'Нагорное посёлок', '+79357532222', 'vlado021@mail.ru', 'client7','password7');
INSERT INTO Clients VALUES (N'Медведева Ева Марковна', N'Новозаводская улица', '+79718086176', 'mishka.r2@mail.ru', 'client8','password8');
INSERT INTO Clients VALUES (N'Кузнецова Анастасия Фёдоровна', N'Авангардная улица', '+79399108532', 'pavlova.n@gmail.com', 'client9','password9');
INSERT INTO Clients VALUES (N'Кузнецов Семён Павлович', N'Автозаводский мост', '+79930223305', 'uml@mail.ri', 'client10','password10');

PRINT('Paint');

INSERT INTO Paint VALUES(N'Акварель');
INSERT INTO Paint VALUES(N'Акрил');
INSERT INTO Paint VALUES(N'Темпера');
INSERT INTO Paint VALUES(N'Масло');
INSERT INTO Paint VALUES(N'Гуашь');

PRINT('Delivery');

INSERT INTO Delivery VALUES(N'Тайнинская улица')
INSERT INTO Delivery VALUES(N'Тарный проезд')
INSERT INTO Delivery VALUES(N'Токарная улица')
INSERT INTO Delivery VALUES(N'Ткацкая улица')
INSERT INTO Delivery VALUES(N'Толбухина проезд')

PRINT('Couriers');

INSERT INTO Couriers VALUES(N'Алексей Есин', 1)
INSERT INTO Couriers VALUES(N'Андрей Какой То', 2)
INSERT INTO Couriers VALUES(N'Еще Кто То', 3)

PRINT('Wood');

INSERT INTO Wood VALUES(N'Дуб');
INSERT INTO Wood VALUES(N'Сосна');
INSERT INTO Wood VALUES(N'Ива');

PRINT('Colors');

INSERT INTO Colors VALUES(N'Красный');
INSERT INTO Colors VALUES(N'Жёлтый');
INSERT INTO Colors VALUES(N'Голубой');


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

