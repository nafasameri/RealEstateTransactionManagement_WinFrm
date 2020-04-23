CREATE PROCEDURE [dbo].[sp_setHouse]
	@type nvarchar,
	@prod nvarchar,
	@price bigint,
	@rent bigint,
	@farea int,
	@floor int,
	@yarea int,
	@yard int,
	@tarea int
AS
	Insert into tblHouses values(@type)
RETURN 0
