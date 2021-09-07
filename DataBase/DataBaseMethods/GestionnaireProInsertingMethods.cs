using Dapper;
using Gestionnaire_Pro.DataBase.DataConnection;
using Gestionnaire_Pro.DataBase.Models;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Threading.Tasks;

namespace Gestionnaire_Pro.DataBase.DataBaseMethods
{
    class GestionnaireProInsertingMethods
    {
        //article
        public static async void AddArticle(Article article)
        {
            var sql = @"INSERT INTO articles (codeBarre,nom,Type,Quantité,prixAchat,prixVente,dateExpiration,fournisseurId) VALUES (
                        @codeBarre,
                        @nom,
                        @type,
                        @quantité,
                        @prixAchat,
                        @prixVente,
                        @dateExpiration,
                        @FournisseurId
                       )";
        
      
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
               await connection.ExecuteAsync(sql,article);
            }

        }
      
        //Fournisseurs
        public static void AddFournisseur(Fournisseur fournisseur)
        {
            var sql = $@"INSERT INTO fournisseurs (nom,address,numTlf,creditArendre) VALUES (
  @nom,
  @address,
  @numTlf,
  @creditArendre
)
";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                connection.ExecuteAsync(sql,new {
                    @nom=fournisseur.nom,
                    @address=fournisseur.Address,
                    @numTlf=fournisseur.numTlf,
                    @creditArendre=fournisseur.creditArendre
                });
            }
        }
        //ACTION
        public static void AddActionEffectué(ActionEffectuer action)
        {
            var sql = $@"INSERT INTO actionsEffectué (descriptionAction,utilisateur,dateAction) VALUES (
@descriptionAction,
@nomUtilisateur,
@dateAction
);";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                connection.ExecuteAsync(sql,new {
                    descriptionAction=action.descriptionAction,
                    nomUtilisateur=action.utilisateur,
                    dateAction=action.dateAction
                });
            }
        }
        //INFO BOUTIQUE
        public static void AddInfoBoutique(InfoBoutique infoBoutique)
        {
           var sql = "INSERT INTO infosBoutique(nomBoutique,address,numTlf,logo) VALUES (@nomBoutique,@address,@numTlf,@logo)";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                connection.ExecuteAsync(sql, infoBoutique);
            }
        }
        //utilisateur
        public static async void AddUtilisateur(Utilisateur utilisateur)
        {
            var sql = "INSERT INTO utilisateurs(nomUtilisateur,motDePass,numTlf,estAdmin) VALUES(@username,@password,@numTlf,@isAdmin)"; ;
          
          
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql,new {username=utilisateur.nomUtilisateur,password=utilisateur.motDePass,numTlf=utilisateur.numTlf,isAdmin=utilisateur.estAdmin });
            }
        }
        //achat
        public static async void AddAchat(Achat achat)
        {
            var param = new { dateAchat=achat.dateAchat,total=achat.montantTotal };
            var sql = "Insert INTO achats(dateAchat,montantTotal) VALUES(@dateAchat,@total)";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
               await connection.ExecuteAsync(sql,param);
            }
        }
        public static async void AddDetailAchat(List<DetailAchat> detailAchats)
        {
            var sql = @"INSERT INTO detailAchats(codeBarre, nom, Type, Quantité, prixAchat, prixVente, dateExpiration, fournisseurId,achatId) VALUES(
                              @codeBarre,
                              @nom,
                              @typeArticle,
                              @qnt,
                              @prixAchat,
                              @prixVente,
                              @dateExp,
                              @fournisseurId,
                              @achatId
                             )";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                foreach (var item in detailAchats)
                {
                    var param = new { codeBarre = item.codeBarre, nom = item.nom, typeArticle = item.Type,
                        qnt = item.Quantité, prixAchat = item.prixAchat, prixVente = item.prixVente,
                        dateExp = item.dateExpiration, fournisseurId = item.fournisseurId,achatId=item.AchatId };
                    await connection.ExecuteAsync(sql, param);
                }
                  
                
                
            }
        }
       //vente
        public static async  void AddVente(Vente vente)
        {
            var sql = @"INSERT INTO ventes(dateVente,montantTotale,remise,netPayé,ajouterPar,clientId) VALUES(
                        @dateVente,
                        @montantTotale,
                        @remise,
                        @netPayé,
                        @ajouterPar,
                        @clientId)";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
               await connection.ExecuteScalarAsync(sql, vente);
            }
        }
        public static async void AddDetailVente(List<DetailVente> detailVentes)
        {
            
            var sql = @"INSERT INTO detailVentes(codeBarre,nom,Type,Quantité,prixAchat,prixVente,remise,venteId) VALUES(
                      @codeBarre,
                      @nom,
                      @Type,
                      @Quantité,
                      @prixAchat,
                      @prixVente,
                      @remise,
                      @VenteId)";

            foreach (var item in detailVentes)
            {
                using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
                {

                     await connection.ExecuteAsync(sql, item);
                }
                
            }
        }

        //client
        public static async void AddClient(Client client)
        {
            var sql = $@"INSERT INTO clients (nom,address,numTlf,credit) VALUES (
                         @nom,
                         @address,
                         @numTlf,
                         @credit
                         )";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                await connection.ExecuteAsync(sql,client);
            }
        }
       
         public static void AddDetailCreditClient(List<DetailCreditClient> detailCreditClients)
        {
            
            var sql = @"INSERT INTO detailCreditClients (descriptionProduit,dateCredit,prixTotale,restApayé,estPayé,clientId) VALUES (
                        @desc,
                        @date,
                        @total,
                        @rest,
                        @estpaye,
                        @clientId
)";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                foreach (var detail in detailCreditClients)
                {
                    var param = new { 
                        desc =detail.descriptionProduit,
                        date=detail.dateCredit,
                        total=detail.prixTotale,
                        rest=detail.restApayé,
                        estpaye=detail.estPayé,
                        clientId=detail.ClientId
                    };
                    connection.ExecuteAsync(sql, param);
                }


            }
        }



        

    }
}