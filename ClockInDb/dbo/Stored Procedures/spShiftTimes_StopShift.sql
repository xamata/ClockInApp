CREATE PROCEDURE [dbo].[spShiftTimes_StopShift]
	@employeeId int,
	@startTime datetime2(7),
	@stopTime datetime2(7)
AS
begin
	set nocount on;

	update dbo.ShiftTimes
	set StopTime = @stopTime
	where EmployeeId = @employeeId
	and StopTime is null;
end