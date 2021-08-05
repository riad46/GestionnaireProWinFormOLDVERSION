select c.nom,sum(c.credit) ,sum(dc.prixTotal) from clients c Left JOIN CreditClients dc
on dc.ClientId=c.Id Group by c.nom