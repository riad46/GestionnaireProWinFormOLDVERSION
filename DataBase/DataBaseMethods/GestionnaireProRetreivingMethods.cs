 using Gestionnaire_Pro.DataBase.DataConnection;
using Gestionnaire_Pro.DataBase.Models;

using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System;

namespace Gestionnaire_Pro.DataBase.DataBaseMethods
{
    class GestionnaireProRetreivingMethods
    {
        //--------------------------------------------------------------------------------  Article
        /// <summary>
        /// use in Table d'Articles
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Article>> GetAllArticles()
        {
            var sql = "SELECT a.id,a.codeBarre,a.nom,a.Type,a.Quantité,a.prixAchat,a.PrixVente,a.dateExpiration,a.fournisseurId,f.* From articles a LEFT JOIN fournisseurs f ON a.fournisseurId =f.id ";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Article, Fournisseur, Article>(sql, (article, fournisseur) =>
                {

                    if (fournisseur != null)
                        article.Fournisseur = fournisseur;
                    return article;
                });
                return res.ToList();
            }

        }
        /// <summary>
        /// use it in searching for articles in list/table article with filters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="codeBarre"></param>
        /// <param name="nom"></param>
        /// <returns></returns>
        public static async Task<List<Article>> SearchForArticle(string codeBarre,string nom,string type,string nomFournisseur)
        {
            var param =new {code ="%"+codeBarre+"%",nom= "%" + nom + "%", type= "%" + type + "%", nomF = "%" + nomFournisseur + "%" };
            var sql = "SELECT a.Id,a.codeBarre,a.nom,a.type,a.Quantité,a.prixAchat,a.prixVente,a.dateExpiration,f.* FROM articles a LEFT JOIN fournisseurs f ON a.fournisseurId=f.id  ";

            if (codeBarre != null || nom != null || type != null || nomFournisseur != null)
            {
                sql += "where";
                if (codeBarre != null) sql += " a.codeBarre LIKE @code ";

                if (codeBarre != null && nom != null)
                {
                    sql += " AND a.nom LIKE @nom ";
                }
                else if (nom != null)
                {
                    sql += " a.nom LIKE @nom";
                }

                if ((codeBarre != null || nom != null) && type != null)
                {
                    sql += " And a.type LIKE @type ";
                }
                else if (type != null)
                {
                    sql += " a.type LIKE @type ";
                }


                if ((codeBarre != null || nom != null || type != null) && nomFournisseur != null)
                {
                    sql += " AND f.nom LIKE @nomF";
                }
                else if (nomFournisseur != null)
                {
                    sql += " f.nom LIKE @nomF";
                }





            }

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Article, Fournisseur, Article>(sql, (article, fournisseur) =>
                {

                    if (fournisseur != null)
                        article.Fournisseur = fournisseur;
                    return article;
                },param);
                return res.ToList();
            }
        }
        public static async Task<Article> GetArticleById(int id)
        {
            var sql ="SELECT * FROM articles WHERE id=@id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
             var res= await connection.QueryFirstAsync<Article>(sql,new { id =id });
                return res;
            }
        }
       

        /// <summary>
        /// use it in vente  
        /// </summary>
        /// <param name="codeBarre"></param>
        /// <returns></returns>
        public static async Task<Article> GetArticleForVente(string codeBarre)
        {
            var sql = $"SELECT id,codeBarre,nom,Quantité,type,prixAchat,prixVente FROM articles where codeBarre ='{codeBarre}' ";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Article>(sql);
                if (res.Count()==0)
                {
                    return null;
                }
                else
                {
                    return res.First(a =>a.Id != null);
                }
                
            }
            
            }

        //--------------------------------------------------------------------------------  Fournisseur
        /// <summary>
        /// use in Liste/Table de Founisseurs
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Fournisseur>> GetAllFournisseurs()
        {

            var sql = "SELECT id,nom,address,numTlf,creditArendre FROM fournisseurs";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var fournisseurs =await connection.QueryAsync<Fournisseur>(sql, new DynamicParameters());
                return fournisseurs.ToList();
            }

        }
        public static int GetFournisseurIdByNom(string nomFournisseur)
        {
            if (nomFournisseur == "")
                nomFournisseur = "23qf4q8674fq534d1q32sd41q3";
            var sql = $"SELECT Id FROM fournisseurs WHERE nom =@nom";

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var result = connection.QueryAsync<int>(sql, new { nom =nomFournisseur} ).Result;
                if (result.Count() > 0)
                {
                    return result.First();
                }
                else
                {
                    return -1;
                }
                
            }
        }
        public static async Task<List<Fournisseur>> SearchForFournisseur(string nom, string numTlf,float credit)
        {
            var param = new
            {
                nom = "%"+ nom+"%",
                num = "%" + numTlf + "%",
                credit = credit
            };
            var sql = "SELECT * FROM fournisseurs ";
            if(nom !=null || numTlf!=null || credit != -1)
            {
                sql += "WHERE";
                if (nom != null) sql += " nom LIKE @nom";

                if (nom != null && numTlf != null)
                {
                    sql += " AND numTlf LIKE @num";
                }
                else if(numTlf != null)
                {
                    sql += " numTlf LIKE @num";
                }
                if((nom != null || numTlf != null) && credit != -1)
                {
                    sql += " AND creditArendre =@credit";
                }
                else if(credit !=-1)
                {
                    sql += " creditArendre =@credit";
                }
                
            }
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var result = await connection.QueryAsync<Fournisseur>(sql,param);
                return result.ToList();
            }
        }
        //--------------------------------------------------------------------------------  Client


        /// <summary>
        /// use in Liste de Clients
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Client>> GetAllClients()
        {
            var sql = "Select id,numRegistre,nom,Address,numTlf,credit FROM clients ";

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                var res= await connection.QueryAsync<Client>(sql);
                return res.ToList();
            }

        }
        public static async Task<List<Client>> GetClientsByFilter(string numRegistre,string nom,string numTlf)
        {
            var param = new { registerNumber = "%" + numRegistre + "%", name = "%"+nom+"%", num = "%" + numTlf+ "%"  };
            var sql = "SELECT id,numRegistre,nom,Address,numTlf,credit FROM clients WHERE ";
            if (!string.IsNullOrWhiteSpace(numRegistre) && numRegistre != "")
            {
                sql += "numRegistre LIKE @registerNumber";
                if (!string.IsNullOrWhiteSpace(nom) || !string.IsNullOrWhiteSpace(numTlf))
                    sql += " AND ";
            }
            
            
            if (!string.IsNullOrWhiteSpace(nom) && nom != "") 
            { 
                sql += " nom LIKE @name";
               
                if (!string.IsNullOrWhiteSpace(numTlf) && numTlf != "") 
                    sql += "AND numTlf LIKE @num";
            }
            else if (!string.IsNullOrWhiteSpace(numTlf) && numTlf != "")
            {
                sql += "numTlf LIKE @num";
            }

            if (string.IsNullOrWhiteSpace(numRegistre) && string.IsNullOrWhiteSpace(nom) && string.IsNullOrWhiteSpace(numTlf))
                sql += " 1";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Client>(sql,param);
                return res.ToList();
            }
        
        }
        /// <summary>
        /// use when clicking on a "Client" in Liste de Clients
        /// </summary>
        /// <param name="clientID"></param>
        /// <returns></returns>
        public static async Task<List<DetailCreditClient>> GetDetailsCreditClient(int clientID)
        {
            var param = new { id=clientID };
            var sql = "SELECT id,descriptionProduit,dateCredit,prixTotale,restApayé,estPayé FROM detailCreditClients WHERE clientId =@id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
             var res = await  connection.QueryAsync<DetailCreditClient>(sql,param);
                return res.ToList();
            }
            
        }
        /// <summary>
        /// use when trying to put clientId in vente
        /// </summary>
        /// <param name="nom"></param>
        public static async  Task<int> GetClientIdByName(string nom)
        {
            var sql = "SELECT id FROM clients WHERE nom=@nom";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                
                var res = await connection.QueryAsync<int>(sql,new { nom = nom });
                return res.First();
            }
        }

        //use to add client name to combo in vente and cell in historique vente
        public static async Task<string> GetClientNameById(int clientId)
        {
            
            var sql = "SELECT nom FROM clients WHERE id=@id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                var res = await connection.QueryAsync<string>(sql, new { id=clientId });
                return res.First();
            }
        }

        //--------------------------------------------------------------------------------  achat+detail
        /// <summary>
        /// use in Table d'Achats
        /// </summary>
        /// <returns></returns>
        public static async  Task< List<Achat> > GetAllAchatsWithDetails()
        {
            var sql = "SELECT a.*,da.* from achats a LEFT JOIN detailAchats da ON da.AchatId=a.Id;";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Achat, DetailAchat, Achat>(sql, (achat, detailAchat) =>
                {
                    if (detailAchat != null)
                        achat.DetailAchats.Add(detailAchat);
                    return achat;
                }) ;
                return res.ToList();
            }
        }
        /// <summary>
        /// use in Liste d'Achats
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Achat>> GetAllAchat()
        {
            var sql = "SELECT * FROM achats";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Achat>(sql); 
                
                return res.ToList();
            }

        }
        /// <summary>
        /// use when Clicking on a "ACHAT" in Liste d'Achat
        /// </summary>
        /// <param name="achatID"></param>
        /// <returns></returns>
        public static async Task<List<DetailAchat>> GetDetailAchats(int achatID)
        {
            var sql = $@"SELECT da.codeBarre,da.nom,da.Type,da.Quantité,da.prixAchat,da.prixVente,da.dateExpiration,da.fournisseurId,a.* 
                FROM detailAchats da LEFT JOIN achat a where da.achatId = a.id and a.id=@achatID";


            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<DetailAchat, Achat, DetailAchat>(sql, (detailAchats, achats) =>
                {
                    detailAchats.Achat = achats; return detailAchats;
                },new { achatID=achatID});
                return res.ToList();
            }

        }
        public static async Task<List<Achat>> GetAchatByFilter(DateTime dateMin,DateTime dateMax)
        {
            var param = new { dateMin = dateMin, dateMax = dateMax };
            var sql = "SELECT * FROM achats where dateAchat<=@dateMax AND dateAchat>=@dateMin";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Achat>(sql,param);

                return res.ToList();
            }

        }

        //--------------------------------------------------------------------------------  vente+detail

        /// <summary>
        /// use when Clicking on a "Vente" in Historique de Vente
        /// </summary>
        /// <param name="venteID"></param>
        /// <returns></returns>
        public List<DetailVente> GetDetailVentes(int venteID)
        {
            var detailsVentes = new List<DetailVente>();
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

            }
            return detailsVentes;
        }


        //use in revenue
        public static async Task<List<int>> GetVenteIds(DateTime dateMin,DateTime dateMax)
        {
            var sql = "Select id FROM ventes where dateVente>=@dateMin and dateVente<=@dateMax";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
              var res=  await connection.QueryAsync<int>(sql,new { dateMin=dateMin,dateMax=dateMax}) ;
                return res.ToList();
            }

        }
        public static async Task<List<DetailVente>> GetAllDetailVentes(List<int> ids)
        {
            
            var sql = "select  id,codeBarre,nom,Type,Quantité,prixAchat,prixVente From detailVentes where venteId IN @ids";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                
                    var res = await connection.QueryAsync<DetailVente>(sql,new {ids });
                
                return res.ToList();
                
            }
        }
            /// <summary>
            /// Historique de vente 
            /// </summary>
            /// <returns></returns>
        public static async Task<List<Vente>> GetHistoriqueDeVente()
        {
            var sql = "Select v.id,v.dateVente,v.montantTotale,v.remise,v.netPayé,v.ajouterPar,v.dateModification,v.modifierPar,v.nouveauMontantTotal,v.nouvelleRemise,c.* FROM ventes v LEFT JOIN clients c";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Vente, Client, Vente>(sql, (vente, client) =>
                {
                    if (vente.clientId != null)
                        vente.Client = client;
                    return vente;
                });
                return res.ToList();
            }


        }

        public static async Task<List<Vente>> GetHistoriqueDeVenteByFilter(int Id,int clientId, float total,DateTime dateMin,DateTime dateMax)
        {
            var param = new { Id=Id,clientId=clientId,total=total,dateMin=dateMin,dateMax=dateMax };
            var sql = "Select DISTINCT v.id,v.dateVente,v.montantTotale,v.remise,v.netPayé,v.ajouterPar,v.dateModification,v.modifierPar,v.nouveauMontantTotal,v.nouvelleRemise,c.* FROM ventes v LEFT JOIN clients c ";
            if(Id!=0 || clientId>0 ||total >=0)
            {
                sql += " WHERE ";
                if (Id >-1)
                {
                    sql += " v.id=@Id AND ";
                }
                if(clientId >-1) sql += " v.clientId=@clientId AND ";
                if (total > -1) sql+="v.montantTotale=@total AND ";
                if (dateMin != null) sql += " v.dateVente >=@dateMin AND ";
                if (dateMin != null) sql += " v.dateVente <=@dateMax  ";

            }
            
            


            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Vente, Client, Vente>(sql, (vente, client) =>
                {
                    if (vente.clientId != null)
                        vente.Client = client;
                    return vente;
                }, param);
                return res.ToList();
            }
        }

        //----------------------------------------------------------------------------- Facture+details
         public static async Task<List<Facture>> GetFacturesByFilter(int Id, int clientId, float total, DateTime dateMin, DateTime dateMax)
       
        {
            var param = new { Id = Id, clientId = clientId, total = total, dateMin = dateMin, dateMax = dateMax };
            var sql = "Select f.id,f.dateFacture,f.montantTotale,f.remise,f.netPayé,f.ajouterPar,c.* FROM factures f LEFT JOIN clients c ";
            if (Id != 0 || clientId > 0 || total >= 0)
            {
                sql += " WHERE ";
                if (Id > -1)
                {
                    sql += " f.id=@Id AND ";
                }
                if (clientId > -1) sql += " f.clientId=@clientId AND ";
                if (total > -1) sql += "f.montantTotale=@total AND ";
                if (dateMin != null) sql += " f.dateFacture >=@dateMin AND ";
                if (dateMin != null) sql += " f.dateFacture <=@dateMax  ";

            }
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<Facture, Client, Facture>(sql, (facture, client) =>
                {
                    if (facture.clientId != null)
                        facture.Client = client;
                    return facture;
                }, param);
                return res.ToList();
            }
        }
         public static async Task<List<DetailsFacture>> GetDetailsFactureByFactureId(int id)
        {
            var sql = "select  id,codeBarre,nom,Type,Quantité,prixAchat,prixVente From detailVentes where venteId IN @id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<DetailsFacture>(sql,id);
                return res.ToList();
            }
        }
        //--------------------------------------------------------------------------------  infoBoutique
        public static async Task<InfoBoutique> GetBoutiqueInfos()
        {
            var sql = "SELECT * FROM infosBoutique where id=1";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<InfoBoutique>(sql);
                if(res.Count()>0)
                return res.First();
            }
            return null;
        }
        //--------------------------------------------------------------------------------  utilisateurs

        /// <summary>
        /// use in Table d'Utilisateurs
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Utilisateur>> GetAllUtilisateurs()
        {
            
            var sql = "SELECT id,nomUtilisateur,motDePass,numTlf,estAdmin FROM utilisateurs";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
            var res= await connection.QueryAsync<Utilisateur>(sql);
                return res.ToList();
            }
            
        }
        //----------------------------------------------------------------------------------- Action
        public static async Task<List<ActionEffectuer>> GetAllActions()
        {
            var sql = "SELECT * FROM actionsEffectué";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
               var res=await connection.QueryAsync<ActionEffectuer>(sql);
                return res.ToList();
            }
        }
        //-----------------------------------------------Produit de Vérifications
        public static async Task<List<ArticleExcluAnotification>> GetQntNONVerifiedProducts()
        {
            var sql = "SELECT * FROM ProduitExcluDeQntVerification";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<ArticleExcluAnotification>(sql);
                return res.ToList();
            }
        }
        public static async Task<List<ArticleExcluAnotification>> GetDateNONVerifiedProducts()
        {
            var sql = "SELECT * FROM ProduitExcluDeDateVerification";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<ArticleExcluAnotification>(sql);
                return res.ToList();
            }
        }


        //------------------------------------------------------------------------------------------------//



        public static async Task<int> RetreiveLastInsertedRowId(string tableName)
        {
            var sql = $"SELECT max(id) FROM {tableName}";
            
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                return  await connection.ExecuteScalarAsync<int>(sql);
                
               
                
            }
            
        }
        public static async Task<int> RetreiveNumRows(string tableName)
        {
            var sql = $"SELECT COUNT(id) FROM {tableName}";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                var res = await connection.QueryAsync<int>(sql);
                return res.AsList()[0];

            }
        }


    }
}
