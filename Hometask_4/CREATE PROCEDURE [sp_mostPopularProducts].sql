-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [sp_mostPopularProducts] 
	-- Add the parameters for the stored procedure here
	@product_type_id as uniqueidentifier,
	@begin_date as datetime2(7),
	@end_date as datetime2(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *--od.[ProductId], p.Name, sum(od.Amount) as [Amount]
	FROM [CoffeeStore].[dbo].[Orders] o
	LEFT JOIN [CoffeeStore].[dbo].[OrderDetails] od ON o.Id = od.OrderId 
	LEFT JOIN [CoffeeStore].[dbo].[Products] p ON od.ProductId = p.Id
	LEFT JOIN [CoffeeStore].[dbo].[ProductTypes] pt ON p.ProductTypeId = pt.Id
	WHERE o.CreatedDate >= @begin_date AND 
	o.CreatedDate <= @end_date AND
	pt.Id = CONVERT(nvarchar(40), @product_type_id)
	GROUP BY od.ProductId, p.Name
	ORDER BY Amount DESC
END
GO
