CREATE PROCEDURE [dbo].[spShiftTimes_ClockedIn]
	@employeeId int
AS
begin
	set nocount on;
	update dbo.Employees
	set IsClockedIn = 1
	where Id = @employeeId;
end