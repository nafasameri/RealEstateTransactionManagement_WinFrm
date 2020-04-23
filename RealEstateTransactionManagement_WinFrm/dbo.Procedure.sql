CREATE PROCEDURE [dbo].[sp_getHouse]
	@_id int = 0
AS
	SELECT * From tblHouses WHERE id = @_id
RETURN 0
