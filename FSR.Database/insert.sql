USE FSR
--insert flights
INSERT INTO tblFlight (DepatureTime, ArrivalTime, Depature, Destination) VALUES ('2016-3-2', '2016-3-4', 'Kyiv', 'Amsterdam')
INSERT INTO tblFlight (DepatureTime, ArrivalTime, Depature, Destination) VALUES ('2016-6-24', '2016-6-27', 'Amsterdam', 'New York')
INSERT INTO tblFlight (DepatureTime, ArrivalTime, Depature, Destination) VALUES ('2016-8-11', '2016-8-12', 'New York', 'Madrid')

--insert users
INSERT INTO tblUser (Name, Surname, [Login], [Password], [Disabled]) VALUES ('Andriy', 'Shevchenko', 'andriys', 'a8698009bce6d1b8c2128eddefc25aad', 0) --098765
INSERT INTO tblUser (Name, Surname, [Login], [Password], [Disabled]) VALUES ('Ivan', 'Borovyi', 'ivanb', '7ff5b944e481d8e3af2c094dd6463273', 0) --054321
INSERT INTO tblUser (Name, Surname, [Login], [Password], [Disabled]) VALUES ('Oleg', 'Shevchuk', 'olegs', 'd6a9a933c8aafc51e55ac0662b6e4d4a', 1) --012345

--insert seats info
DECLARE @seat_value INT
SET @seat_value = 1
WHILE @seat_value <= 50
BEGIN
	INSERT INTO tblSeat (Number, Flight, Cost) VALUES (@seat_value, 1, 2020 - (20 * @seat_value))
	INSERT INTO tblSeatStatus (UserId, PersonId, SeatId, SeatStatus) VALUES (NULL, NULL, SCOPE_IDENTITY(), 0)
	SET @seat_value = @seat_value + 1;
END

SET @seat_value = 1
WHILE @seat_value <= 50
BEGIN
	INSERT INTO tblSeat (Number, Flight, Cost) VALUES (@seat_value, 2, 2080 - (20 * @seat_value))
	INSERT INTO tblSeatStatus (UserId, PersonId, SeatId, SeatStatus) VALUES (NULL, NULL, SCOPE_IDENTITY(), 0)
	SET @seat_value = @seat_value + 1;
END

SET @seat_value = 1
WHILE @seat_value <= 50
BEGIN
	INSERT INTO tblSeat (Number, Flight, Cost) VALUES (@seat_value, 3, 2000 - (20 * @seat_value))
	INSERT INTO tblSeatStatus (UserId, PersonId, SeatId, SeatStatus) VALUES (NULL, NULL, SCOPE_IDENTITY(), 0)
	SET @seat_value = @seat_value + 1;
END

--make some reservarions
INSERT INTO tblPerson (Name, Surname) VALUES ('Breanna', 'Feingold')
UPDATE tblSeatStatus SET UserId = 1, PersonId = SCOPE_IDENTITY(), SeatStatus = 1 
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 2 AND Flight = 1
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Clarine', 'Kratzer')
UPDATE tblSeatStatus SET UserId = 1, PersonId = SCOPE_IDENTITY(), SeatStatus = 1
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 3 AND Flight = 1
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Eladia', 'Valadez')
UPDATE tblSeatStatus SET UserId = 1, PersonId = SCOPE_IDENTITY(), SeatStatus = 1
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 5 AND Flight = 1
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Malvina', 'Allred')
UPDATE tblSeatStatus SET UserId = 1, PersonId = SCOPE_IDENTITY(), SeatStatus = 1
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 11 AND Flight = 1
	)

INSERT INTO tblPerson (Name, Surname) VALUES ('Shenita', 'Lowman')
UPDATE tblSeatStatus SET UserId = 1, PersonId = SCOPE_IDENTITY(), SeatStatus = 1
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 5 AND Flight = 2
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Margarite', 'Birdsong')
UPDATE tblSeatStatus SET UserId = 2, PersonId = SCOPE_IDENTITY(), SeatStatus = 1 
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 1 AND Flight = 2
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Lacie', 'Kemmerer')
UPDATE tblSeatStatus SET UserId = 2, PersonId = SCOPE_IDENTITY(), SeatStatus = 1
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 2 AND Flight = 2
	)

INSERT INTO tblPerson (Name, Surname) VALUES ('Hee', 'Laurin')
UPDATE tblSeatStatus SET UserId = 3, PersonId = SCOPE_IDENTITY(), SeatStatus = 1
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 10 AND Flight = 2
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Tommy', 'Ritenour')
UPDATE tblSeatStatus SET UserId = 3, PersonId = SCOPE_IDENTITY(), SeatStatus = 1
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 17 AND Flight = 3
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Ingrid', 'Demma')
UPDATE tblSeatStatus SET UserId = 3, PersonId = SCOPE_IDENTITY(), SeatStatus = 1
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 23 AND Flight = 3
	)

--assign some reservation canceled
INSERT INTO tblPerson (Name, Surname) VALUES ('Lorelei', 'Elie')
UPDATE tblSeatStatus SET UserId = 1, PersonId = SCOPE_IDENTITY(), SeatStatus = 2 
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 22 AND Flight = 1
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Nisha', 'Cuffee')
UPDATE tblSeatStatus SET UserId = 1, PersonId = SCOPE_IDENTITY(), SeatStatus = 2 
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 31 AND Flight = 2
	)
INSERT INTO tblPerson (Name, Surname) VALUES ('Shana', 'Eberly')
UPDATE tblSeatStatus SET UserId = 2, PersonId = SCOPE_IDENTITY(), SeatStatus = 2 
WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = 46 AND Flight = 2
	)
GO