USE FSR
ALTER TABLE tblSeatStatus DROP CONSTRAINT 
	PK_tblSeatStatus_Id,
	FK_tblSeatStatus_PersonId_tblPerson_Id, 
	FK_tblSeatStatus_SeatId_tblSeat_Id,
	FK_tblSeatStatus_UserId_tblUser_Id

ALTER TABLE tblSeat DROP CONSTRAINT 
	PK_tblSeat_Id,
	FK_tblSeat_Flight_tblFlight_Id,
	UQ_tblSeat_Number_Flight,
	CK_Number_Positive,
	CK_Cost_Positive

ALTER TABLE tblFlight DROP CONSTRAINT PK_tblFlight_Id

ALTER TABLE tblPerson DROP CONSTRAINT PK_tblPerson_Id

ALTER TABLE tblUser DROP CONSTRAINT
	PK_tblUser_Id,
	UQ_tblSeatStatus_Login_Password

DROP TABLE tblSeatStatus
DROP TABLE tblSeat
DROP TABLE tblFlight
DROP TABLE tblPerson
DROP TABLE tblUser

DROP PROCEDURE spReserveSeat
DROP PROCEDURE spCancelReserving
DROP PROCEDURE spGetSeats
DROP PROCEDURE spGetPersons
DROP PROCEDURE spGetFlights
DROP PROCEDURE spGetUsers
DROP PROCEDURE spGetSeatStatuses
DROP PROCEDURE spGetUserByLogin