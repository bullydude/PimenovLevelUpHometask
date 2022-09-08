USE [CoffeeStore]
GO

/****** Object:  View [dbo].[ProductOperations]    Script Date: 08.09.2022 12:54:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_ClientsActivity]
AS
SELECT TOP 100 PERCENT c.Name, c.Surname, COUNT(o.id) AS [Amount]
FROM     dbo.Clients AS c INNER JOIN
                  dbo.Orders AS o ON o.ClientId = c.Id
GROUP BY c.Surname, c.Name
ORDER BY [Amount] DESC
GO
