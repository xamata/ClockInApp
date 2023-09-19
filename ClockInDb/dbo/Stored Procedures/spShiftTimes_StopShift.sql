CREATE PROCEDURE [dbo].[spShiftTimes_StopShift]
	@employeeId int,
	@stopTime datetime2(7)
AS
begin
	set nocount on;

	update dbo.ShiftTimes
	set EndTime = @stopTime
	where EndTime = null;
end