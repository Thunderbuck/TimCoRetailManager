CREATE PROCEDURE [dbo].[spInventory_GetAll]
AS

begin
	set nocount on;

	select [ProductID], [Quantity], [PurchasePrice], [PurchaseDate]
	from dbo.Inventory
end
