CREATE PROCEDURE [dbo].[spShiftTimes_ClockedOut]
	@employeeId int
AS
begin
	set nocount on
	update dbo.Employees
	set IsClockedIn = 0
	where Id = @employeeId;
end