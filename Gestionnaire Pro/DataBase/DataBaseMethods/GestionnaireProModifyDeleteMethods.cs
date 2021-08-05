﻿using Dapper;

using Gestionnaire_Pro.DataBase.DataConnection;
using Gestionnaire_Pro.DataBase.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Gestionnaire_Pro.DataBase.DataBaseMethods
{
    class GestionnaireProModifyDeleteMethods
    {
        ////---------------------------------------------Utilisateur 
        public static async void ModifyUserInfos(Utilisateur utilisateur)
        {
            var sql = $@" UPDATE utilisateurs
                      Set
                      nom={utilisateur.nomUtilisateur},
                      motDePass={utilisateur.motDePasse},
                      numTlf={utilisateur.numTlf},
                      isAdmin={utilisateur.estAdmin}";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        public static async void DeleteUser(int id)
        {
            //check if users are +1
            if (GestionnaireProRetreivingMethods.GetAllUtilisateurs().Count <= 1)
            {
                System.Windows.Forms.MessageBox.Show("Il y a un seul Utilisateur dans ce Programme", "Attention !!!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            var sql = $"DELETE FROM utilisateurs WHERE id={id}";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        ////---------------------------------------------Client
        public static async void ModifyClientInfos(Client client)
        {
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                await connection.ExecuteAsync("dbo.spClient_ModifyClient", client);


            }
        }
        public static async void DeleteClient(int id)
        {
            var sql = $"DELETE FROM clients WHERE id={id}";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        public static async void DeleteAllClient()
        {
            var sql = $"DELETE FROM clients ";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        ////---------------------------------------------DetailClient
     
        public static async void ModifyDetailClient(DetailAchat[] detailAchats)
        {
            var sql = @"UPDATE detailCreditClients
                        SET 
                        descriptionProduit=@descriptionCredit,
                        prixTotale=@prixTotal,
                        restApayé=@restApayé,
                        estPayé=@estPayé
                         WHERE id=@Id";
                         
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                foreach (var detail in detailAchats)
                {
                    await connection.ExecuteAsync(sql, detail);
                }
                
            }
        }
        public static async void DeleteDetailCreditClient(int[] ids)
        {
            var sql = $"DELETE FROM clients WHERE id IN @ids";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql, ids);
            }
        }

        ////---------------------------------------------Fournisseur
        public static async void ModifyFournisseurInfos(Fournisseur fournisseur)
        {
            var sql = $@"UPDATE fournisseurs
              SET nom='{fournisseur.nom}',address='{fournisseur.Address}',numTlf='{fournisseur.numTlf}',
             creditArendre={fournisseur.creditArendre} WHERE id={fournisseur.Id}";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }

        }
        public static async void DeleteFournisseur(int id)
        {
            var sql = $"DELETE FROM fournisseurs WHERE id ={id}";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        public static async void DeleteAllFournisseur()
        {
            var sql = $"DELETE FROM fournisseurs";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        ////---------------------------------------------Article
        public static async void ModifyArticle(Article article)
        {
           var sql = $@"UPDATE articles
                            SET
                            codeBarre=@codeBarre,
                            nom=@nom,
                            Type=@type,
                            Quantité=@quantité,
                            prixAchat=@prixAchat,
                            prixVente=@prixVente,
                            dateExpiration=@dateExpiration,
                            fournisseurId=@FournisseurId where id=@Id
                          ";

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql,article);
            }

        }
        public static async void DeleteArticle(int id)
        {
            var sql = $"DELETE FROM articles WHERE id={id}";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        public static async void DeleteAllArticle()
        {
            var sql = "DELETE FROM articles";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        public static async void ResetStock()
        {
            var sql = $@"UPDATE articles
                SET
                Quantité = {0}";

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        ////---------------------------------------------Achat
        public static async void ModifyAchat(int id)
        {
            var sql = @"UPDATE achats 
                        SET
                       dateAchat =@dateAchat,
                        montantTotal=@montantTotal
                        WHERE id=@Id";

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql, new { id = id });
            }
        }
        public static async void DeleteAchat(int id)
        {
            var sql = "DELETE FROM achats WHERE id=@id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql, new { id=id});
            }
        }
        public static async void DeleteAllAchat()
        {
            var sql = $"DELETE FROM achats";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }

        ////---------------------------------------------DetailAchat
        public static async void ModifyDetailAchat(DetailAchat[] detailAchats)
        {
            var sql = "";

            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                foreach (var detail in detailAchats)
                {
                    if (detail.dateExpiration != null)
                    {
                        if (detail.FournisseurId != null)
                        {
                            sql = $@"UPDATE articles
                            SET
                            codeBarre=@codeBarre
                            nom=@nom
                            Type=@type
                            Quantité=@qnt
                            prixAchat=@prixAchat
                            prixVente=@prixVente
                            dateExpiration='{detail.dateExpiration.Value.ToString("dd/MM/yyyy")}',
                            fournisseurId=@fournisseurId where id=@id";

                        }
                        else
                        {
                            sql = $@"UPDATE articles
                            SET
                            codeBarre=@codeBarre
                            nom=@nom
                            Type=@type
                            Quantité=@qnt
                            prixAchat=@prixAchat
                            prixVente=@prixVente
                           dateExpiration ='{detail.dateExpiration.Value.ToString("dd/MM/yyyy")}',
                            fournisseurId=NULL where id=@id";
                        }

                    }
                    else
                    {
                        if (detail.FournisseurId != null)
                        {
                            sql = $@"UPDATE articles
                            SET
                             codeBarre=@codeBarre
                            nom=@nom
                            Type=@type
                            Quantité=@qnt
                            prixAchat=@prixAchat
                            prixVente=@prixVente
                            dateExpiration=NULL,
                            fournisseurId=NULL where id=@id";
}
                        else
                        {
                            sql = $@"UPDATE articles
                            SET
                            codeBarre=@codeBarre
                            nom=@nom
                            Type=@type
                            Quantité=@qnt
                            prixAchat=@prixAchat
                            prixVente=@prixVente
                            dateExpiration=NULL,
                            fournisseurId=NULL where id=@id";
                        }
                    }
                await connection.ExecuteAsync(sql,detail);
                }
            }
        }
        public static async void DeleteDetailAchat(int[] id)
        {
            var sql = $"DELETE FROM detailAchats WHERE id=@id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql,new {id =id } );
            }
        }
        public static async void DeleteAllDetailAchat()
        {
            var sql = $"DELETE FROM detailAchats";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        ////---------------------------------------------Vente
        public static async void ModifyVente(DetailVente[] detailVentes)
        {
            var sql = @"UPDATE ventes
                       SET
                       dateModification=@dateModification,
                       modifierPar=@modifierPar,
                       nouveauMontantTotal=@nouveauMontantTotal,
                       nouvelleRemise=@nouvelleRemise,
                       clientId=@clientId
                       WHERE id=@Id 
                       ";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                await connection.ExecuteAsync(sql, detailVentes);


            }
        }
        public static async void DeleteVente(int id)
        {
            var sql = $"DELETE FROM ventes WHERE id=@id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql, new { id=id });
            }
        }
        public static async void DeleteAllVentes()
        {
            var sql = $"DELETE FROM ventes";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        ////---------------------------------------------DetailVente
        public static async void ModifyDetailVente(Vente vente)
        {
            var sql = @"UPDATE ventes
                       SET
                       nouvelleQnt=@nouvelleQnt,
                       nouveauTotal=@nouveauMontantTotal,
                       nouvelleRemise=@nouvelleRemise,
                       WHERE id=@Id 
                       "; ;
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {

                await connection.ExecuteAsync(sql, vente);


            }
        }
        public static async void DeleteDetailVente(int id)
        {
            var sql = $"DELETE FROM detailVentes WHERE id=@id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql, new { id = id });
            }
        }
        public static async void DeleteAllDetailVentes()
        {
            var sql = $"DELETE FROM detailVentes";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        ////---------------------------------------------Actions
        public static async void DeleteAction(int id)
        {
            var sql = $"DELETE FROM actionsEffectué WHERE id=@id";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql, new { id = id });
            }
        }
        public static async void DeleteAllActions()
        {
            var sql = $"DELETE FROM actionsEffectué";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql);
            }
        }
        //------------------------------------------------InfoBoutique
        public static async void ModifyInfosBoutique(InfoBoutique infosBoutique)
        {
            var sql = @"UPDATE infosBoutique
                 SET
                nomBoutique=@nomBoutique,
                address=@address,
                numTlf=@numTlf,
                logo =@logo
                ";
            using (IDbConnection connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
                await connection.ExecuteAsync(sql, infosBoutique);
            }
        }








    }











    
}

