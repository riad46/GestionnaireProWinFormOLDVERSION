 Begin TRANSACTION
Delete FROM dbo.ventes  WHERE ventes.Id=4
Delete FROM dbo.detailVentes  WHERE detailVentes.VenteId=4             

COMMIT