CREATE PROCEDURE [dbo].[spShiftTimes_StartShift]
	@employeeId int,
	@startTime datetime2(7)
AS
begin
	set nocount on;

	if not exists(select 1 from dbo.ShiftTimes where Id = @employeeId)
	begin
		insert dbo.ShiftTimes (StartTime)
		values (@startTime)
	end
end