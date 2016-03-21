USE FSR
CREATE TABLE tblPerson
(
	Id INT NOT NULL IDENTITY(1,1),
	Name NVARCHAR(255) NOT NULL, 
	Surname NVARCHAR(255) NOT NULL
	CONSTRAINT PK_tblPerson_Id PRIMARY KEY (Id)
)

CREATE TABLE tblFlight
(
	Id INT NOT NULL IDENTITY(1,1), 
	DepatureTime DATETIME NOT NULL, 
	ArrivalTime DATETIME NOT NULL,
	Depature NVARCHAR(255) NOT NULL,
	Destination NVARCHAR(255) NOT NULL
	CONSTRAINT PK_tblFlight_Id PRIMARY KEY (Id)
)

CREATE TABLE tblSeat
(
	Id INT NOT NULL IDENTITY(1,1),
	Number INT NOT NULL,
	Flight INT NOT NULL,
	Cost NUMERIC(18, 4) NOT NULL
	CONSTRAINT PK_tblSeat_Id PRIMARY KEY (Id),
	CONSTRAINT FK_tblSeat_Flight_tblFlight_Id FOREIGN KEY (Flight) REFERENCES tblFlight (Id),
	CONSTRAINT UQ_tblSeat_Number_Flight UNIQUE (Number, Flight),
	CONSTRAINT CK_Number_Positive CHECK (Number > 0),
	CONSTRAINT CK_Cost_Positive CHECK (Cost > 0)
)

CREATE TABLE tblUser
(
	Id INT NOT NULL IDENTITY(1,1),
	Name NVARCHAR(255) NOT NULL,
	Surname NVARCHAR(255) NOT NULL,
	[Login] VARCHAR(50) NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[Disabled] BIT NOT NULL
	CONSTRAINT PK_tblUser_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblSeatStatus_Login_Password UNIQUE([Login], [Password])
)

CREATE TABLE tblSeatStatus
(
	Id INT NOT NULL IDENTITY(1,1),
	UserId INT,
	PersonId INT, 
	SeatId INT NOT NULL,
	SeatStatus INT NOT NULL
	CONSTRAINT PK_tblSeatStatus_Id PRIMARY KEY (Id),
	CONSTRAINT FK_tblSeatStatus_PersonId_tblPerson_Id FOREIGN KEY (PersonId) REFERENCES tblPerson (Id),
	CONSTRAINT FK_tblSeatStatus_SeatId_tblSeat_Id FOREIGN KEY (SeatId) REFERENCES tblSeat (Id),
	CONSTRAINT FK_tblSeatStatus_UserId_tblUser_Id FOREIGN KEY (UserId) REFERENCES tblUser (Id)
)
GO