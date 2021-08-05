﻿using Dapper;
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
                    nomUtilisateur=action.nomUtilisateur,
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
        public void AddUtilisateur(Utilisateur utilisateur)
        {
            var sql = "INSERT INTO utilisateurs(nomUtilisateur,motDePass,numTlf,estAdmin) VALUES(@username,@password,@numTlf,@isAdmin)"; ;
            if (string.IsNullOrEmpty(utilisateur.numTlf))
                 sql = "INSERT INTO utilisateurs(nomUtilisateur,motDePass,estAdmin) VALUES(@username,@password,@isAdmin)";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                connection.ExecuteAsync(sql,new {username=utilisateur.nomUtilisateur,password=utilisateur.motDePasse,numTlf=utilisateur.numTlf,isAdmin=utilisateur.estAdmin });
            }
        }
        //achat
        public void AddAchat(Achat achat)
        {
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                connection.ExecuteAsync("dbo.spAchat_AddAchat", achat);
            }
        }
        public void AddDetailAchat(List<DetailAchat> detailAchats)
        {
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                foreach (var detail in detailAchats)
                {
                    connection.ExecuteAsync("dbo.spAchat_AddDetail", detail);
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
                      @nomArticle,
                      @typeArticle,
                      @qnt,
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
                         '{client.nom}',
                         '{client.numTlf}',
                         '{client.Address}',
                         '{client.credit}')";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                await connection.ExecuteAsync(sql);
            }
        }
        public static void AddDetailCreditClient(List<DetailCreditClient> detailCreditClients)
        {
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                foreach (var detail in detailCreditClients)
                {
                    connection.ExecuteAsync("dbo.spDetailCreditClient_AddDetailCredit", detail);
                }


            }
        }


        

    }
}