﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

    public DataAccessLayer()
    {
        connStr = @"Data Source=db-H3408.vm; Database=mydb; User ID=DotnetHarkka; Password=dotnet";
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

    public void openConnection(List<Card> cards)
    {
        string sql;
        sql = "INSERT INTO Card (CardName,Cardset,CardType,CardRarity,CardCost,CardAttack,CardHealth,CardText,CardPlayerClass,CardImg)" +  
              "Values (@name, @set, @type, @rarity, @cost, @attack, @health, @text, @playerClass, @img);";
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            foreach (var item in cards)
            {
                insertCard(sql, conn, item);
            }
            conn.Close();
        }

    }

    public void insertCard(string sql, MySqlConnection conn, Card x)
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
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            }


    }
}