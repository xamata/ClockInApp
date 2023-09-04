CREATE PROCEDURE [dbo].[spEmployees_GetByPin]
	@pin NVARCHAR(4)
AS
begin 
	set nocount on;

	select [Id], [FirstName], [LastName], [Pin], [IsClockedIn]
	from dbo.Employees
	where Pin = @pin
end
