CREATE PROCEDURE [dbo].[spShiftTimes_StopShift]
	@employeeId int,
	@stopTime datetime2(7)
AS
begin
	set nocount on;

	if not exists(select 1 from dbo.ShiftTimes where Id = @employeeId)
	begin
		insert dbo.ShiftTimes (EndTime)
		values (@stopTime)
	end
end