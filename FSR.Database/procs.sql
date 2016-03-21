USE FSR
GO

CREATE PROCEDURE spReserveSeat 
	@userid INT, 
	@name NVARCHAR(255), 
	@surname NVARCHAR(255), 
	@seat INT, 
	@flight INT
AS
BEGIN
	INSERT INTO tblPerson (Name, Surname) VALUES (@name, @surname)
	UPDATE tblSeatStatus SET UserId = @userid, PersonId = SCOPE_IDENTITY(), SeatStatus = 1 
	WHERE SeatId =
	(
		SELECT Id 
		FROM tblSeat
		WHERE Number = @seat AND Flight = @flight
	)
	
END
GO

CREATE PROCEDURE spCancelReserving 
	@userid INT,
	@seatStatusId INT
AS
BEGIN
	UPDATE tblSeatStatus SET UserId = @userid, SeatStatus = 2 
	WHERE Id = @seatStatusId
END
GO

CREATE PROCEDURE spGetSeats
AS
BEGIN
	SELECT 
		s.Id, 
		s.Number,
		f.Id, 
		f.DepatureTime, 
		f.ArrivalTime,
		f.Depature, 
		f.Destination, 
		s.Cost 
	FROM tblSeat s JOIN tblFlight f
	ON s.Flight = f.Id
END
GO

CREATE PROCEDURE spGetPersons
AS
BEGIN
	SELECT 
		Id, 
		Name, 
		Surname
	FROM tblPerson
END
GO

CREATE PROCEDURE spGetFlights
AS
BEGIN
	SELECT 
		Id, 
		DepatureTime, 
		ArrivalTime, 
		Depature, 
		Destination
	FROM tblFlight
END
GO

CREATE PROCEDURE spGetUsers
AS
BEGIN
	SELECT 
		Id, 
		Name, 
		Surname, 
		[Login], 
		[Password], 
		[Disabled]
	FROM tblUser
END
GO

CREATE PROCEDURE spGetSeatStatuses
AS
BEGIN
	SELECT 
		ISNULL(u.Id, 0),
		ISNULL(u.Name, ''),
		ISNULL(u.Surname, ''),
		ISNULL(u.[Login], ''),
		ISNULL(u.[Password], ''),
		ISNULL(u.[Disabled], 0),
		ISNULL(f.Id, 0),
		ISNULL(f.DepatureTime, '0-0-0'),
		ISNULL(f.ArrivalTime, '0-0-0'),
		ISNULL(f.Depature, ''), 
		ISNULL(f.Destination, ''),
		ISNULL(p.Id, 0),
		ISNULL(p.Name, ''),
		ISNULL(p.Surname, ''),
		ISNULL(s.Id, 0),
		ISNULL(s.Number, 0),
		ISNULL(s.Flight, 0),
		ISNULL(s.Cost, 0),
		ss.Id,
		ss.SeatStatus 
	FROM tblSeatStatus ss LEFT JOIN tblPerson p
	ON ss.PersonId = p.Id
	LEFT JOIN tblUser u
	ON  ss.UserId = u.Id
	LEFT JOIN tblSeat s
	ON ss.SeatId = s.Id
	JOIN tblFlight f
	ON s.Flight = f.Id
END
GO

CREATE PROCEDURE spGetSeatStatusByPersonId
	@personId INT
AS
BEGIN
	SELECT 
		ISNULL(u.Id, 0),
		ISNULL(u.Name, ''),
		ISNULL(u.Surname, ''),
		ISNULL(u.[Login], ''),
		ISNULL(u.[Password], ''),
		ISNULL(u.[Disabled], 0),
		ISNULL(f.Id, 0),
		ISNULL(f.DepatureTime, '0-0-0'),
		ISNULL(f.ArrivalTime, '0-0-0'),
		ISNULL(f.Depature, ''), 
		ISNULL(f.Destination, ''),
		ISNULL(p.Id, 0),
		ISNULL(p.Name, ''),
		ISNULL(p.Surname, ''),
		ISNULL(s.Id, 0),
		ISNULL(s.Number, 0),
		ISNULL(s.Flight, 0),
		ISNULL(s.Cost, 0),
		ss.Id,
		ss.SeatStatus 
	FROM tblSeatStatus ss JOIN tblPerson p
	ON ss.PersonId = p.Id
	JOIN tblUser u
	ON  ss.UserId = u.Id
	JOIN tblSeat s
	ON ss.SeatId = s.Id
	JOIN tblFlight f
	ON s.Flight = f.Id
	WHERE p.Id = @personId;
END
GO

CREATE PROCEDURE spGetUserByLogin
	@login VARCHAR(50),
	@password VARCHAR(50)
AS
BEGIN
	SELECT 
		Id, 
		Name, 
		Surname, 
		[Login], 
		[Password], 
		[Disabled] 
	FROM tblUser
	WHERE [Login] = @login AND [Password] = @password AND [Disabled] <> 1
END
GO