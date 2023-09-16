CREATE PROCEDURE [dbo].[spShiftTimes_ClockedOut]
	@employeeId int
AS
begin
	set nocount on;

	if not exists(select 1 from dbo.Employees where Id = @employeeId)
	begin
		update dbo.Employees
		set IsClockedIn = 0
		where Id = @employeeId;
	end

end