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
            var param =new {code =codeBarre,nom=nom,type=type,nomF =nomFournisseur };
            var sql = "SELECT a.codeBarre,a.nom,a.Quantité,a.prixVente,a.dateExpiration,f.* FROM articles a LEFT JOIN fournisseurs f ON a.fournisseurId=f.id WHERE ";
         
            
            
               
            
            
          
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
        public static List<Fournisseur> GetAllFournisseurs()
        {

            var sql = "SELECT id,nom,address,numTlf,creditArendre FROM fournisseurs";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var fournisseurs = connection.Query<Fournisseur>(sql, new DynamicParameters());
                return fournisseurs.ToList();
            }

        }
        public static int GetFournisseurIdByNom(string nomFournisseur)
        {
            var sql = $"SELECT Id FROM fournisseurs WHERE nom =@nom";

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var result = connection.QueryAsync<int>(sql, new { nom =nomFournisseur} ).Result.First();
                return result;
            }
        }
        //--------------------------------------------------------------------------------  Client

       
        /// <summary>
        /// use in Liste de Clients
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Client>> GetAllClients()
        {
            var sql = "Select id,nom,Address,numTlf,credit FROM clients ";

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                var res= await connection.QueryAsync<Client>(sql);
                return res.ToList();
            }

        }
        public static async Task<List<Client>> GetClientsByFilter(string nom,string numTlf)
        {
            var param = new { name = "%"+nom+"%", num = "%" + numTlf+ "%"  };
            var sql = "SELECT id,nom,Address,numTlf,credit FROM clients WHERE ";
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
            else
            {
                sql += "1";
            }
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


        //--------------------------------------------------------------------------------  achat+detail
        /// <summary>
        /// use in Table d'Achats
        /// </summary>
        /// <returns></returns>
        public static List<Achat> GetAllAchatsWithDetails()
        {
            var sql = "SELECT a.*,da.* from achats a LEFT JOIN detailAchats da ON da.AchatId=a.Id;";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                return connection.Query<Achat, DetailAchat, Achat>(sql, (achat, detailAchat) => {
                    if (detailAchat != null)
                        achat.DetailAchats.Add(detailAchat);
                    return achat;
                }).ToList();
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
        public async Task<List<DetailAchat>> GetDetailAchats(int achatID)
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
            var sql = "Select v.id,v.dateVente,v.montantTotale,v.remise,v.netPayé,v.ajouterPar,v.dateModification,v.modifierPar,v.nouveauMontantTotal,v.nouvelleRemise,c.* FROM ventes v LEFT JOIN clients c ";
            if(Id!=0 || clientId>0 ||total >=0 || dateMin!=null ||dateMax!=null)
            {
                sql += " WHERE ";
                if (Id >-1)
                {
                    sql += " v.id=@Id AND";
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
            //--------------------------------------------------------------------------------  infoBoutique
            public static async Task<InfoBoutique> GetBoutiqueInfos()
        {
            var sql = "SELECT * FROM infosBoutique where id=1";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                var res = await connection.QueryAsync<InfoBoutique>(sql);
                return res.First();
            }
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
            var res=    await connection.QueryAsync<Utilisateur>(sql);
                return res.ToList();
            }
            
        }
        //----------------------------------------------------------------------------------- Action
        public List<ActionEffectuer> GetAllActions()
        {
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                return null;
            }
        }
        //----------------------------------------------------------------------------------------------------------------//



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
