using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
public class DataAccessLayer
{
    private string connStr;
    private string sql;

    /*
        Tarvitaan pakat käyttäjältä
        Tarvitaan pakan luonti (insertoida kortteja deck_has_card)
        tarvitaan kortit näkyviin(millä logiikalla? eli kui monta ja millä haulla siis)
    */

    public DataAccessLayer()
    {
        connStr = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        //connStr = @"Data Source=db-H3408.vm; Database=mydb; User ID=DotnetHarkka; Password=dotnet";
    }

    public void testConnection()
    {
        using (MySqlConnection cnn = new MySqlConnection(connStr))
        {
            cnn.Open();
            //teetesti
            cnn.Close();
        }
    }

    public void InsertCardsToDb(List<Card> cards)
    {        
        sql = "INSERT INTO Card (CardName,Cardset,CardType,CardRarity,CardCost,CardAttack,CardHealth,CardText,CardPlayerClass,CardImg)" +  
              "Values (@name, @set, @type, @rarity, @cost, @attack, @health, @text, @playerClass, @img);";
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            foreach (var item in cards)
            {
                insertCard(conn, item);
            }
            conn.Close();
        }
    }

    public void insertCard(MySqlConnection conn, Card x)
    {
        if (x.type != "Hero")
        {
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", x.name);
                cmd.Parameters.AddWithValue("@set", x.cardSet);
                cmd.Parameters.AddWithValue("@type", x.type);
                cmd.Parameters.AddWithValue("@rarity", x.rarity);
                cmd.Parameters.AddWithValue("@cost", x.cost);
                cmd.Parameters.AddWithValue("@attack", x.attack);
                cmd.Parameters.AddWithValue("@health", x.health);
                cmd.Parameters.AddWithValue("@text", x.text);
                cmd.Parameters.AddWithValue("@playerClass", x.playerClass);
                cmd.Parameters.AddWithValue("@img", x.img);
                cmd.ExecuteNonQuery();
            }
        }
    }
}