CREATE PROCEDURE [dbo].[spShiftTimes_StartShift]
	@employeeId int,
	@startTime datetime2(7)
AS
begin
	set nocount on;

	insert dbo.ShiftTimes (EmployeeId, StartTime)
	values (@employeeId, @startTime);
end