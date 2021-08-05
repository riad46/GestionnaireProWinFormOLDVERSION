create procedure dbo.spAchat_GetAllAchatsWithDetails
as
begin
SELECT a.Id,a.dateAchat,a.montantTotal,da. from achats a LEFT JOIN detailAchats da LEFT JOIN fournisseurs f
end