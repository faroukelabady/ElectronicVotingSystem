using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace VotingSystemVer2.DatabaseConnection
{
    /// <summary>
    /// handel the connection to a local mysql database server
    /// </summary>
    public class LocalDatabase : DataBase 
    {
       
       MySqlConnection conn;
       MySqlCommand command;
       MySqlDataReader rdr;
       string myConnectionString;
        //= "server=127.0.0.1;uid=root;pwd=farouk;";
        string host;
        string uid;
        string pwd;


        public LocalDatabase(string host,string uid, string pwd)
        {
            this.host = host;
            this.uid = uid;
            this.pwd = pwd;
            command = new MySqlCommand();
        }

        /// <summary>
        /// connect to dataBase server
        /// </summary>
        /// <returns></returns>
        public bool connect()
        {
            myConnectionString = "server=" + host + ";uid=" + uid + ";pwd="+ pwd +";";
            
            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                command.Connection = conn;
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {            
                return false;           
            }
        }

        /// <summary>
        /// connect to database server and use the specified database
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        public bool connect(string database)
        {
            myConnectionString = "server=" + host + ";uid=" + uid + ";pwd=" + pwd + ";database=" + database + ";";

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                command.Connection = conn;
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }
        }

        /// <summary>
        /// disconnect from database
        /// </summary>
        public void disConnect()
        {
            
                conn.Close();
                conn.Dispose();
           
        }

        /// <summary>
        /// insert data into table 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="motherName"></param>
        /// <param name="choice"></param>
        /// <returns></returns>
        public bool insertData(string ID, string motherName, List<string> choices)
        {
            try
            {
                command.CommandText = "use voting;";
                command.ExecuteNonQuery();
                command.CommandText = "insert into votingtable values (\'" + ID + "\',"+
                    " \'"+motherName+"\', localtime());";
                //command.Prepare();
                //command.Parameters.AddWithValue("@id", ID);
                //command.Parameters.AddWithValue("@mothername", motherName);
                //command.Parameters.AddWithValue("@choice", choice);
                command.ExecuteNonQuery();
                foreach (string choice in choices)
                {
                    command.CommandText = "insert into result values (\'" + ID + "\'," +
                        " \'" + choice + "\');";
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (MySqlException mex)
            {
                return false;
            }
            catch (InvalidOperationException inex)
            {
                return false;
            }

        }

        /// <summary>
        /// get the rseults from the table
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int countChoice(string text)
        {
            
            command.CommandText = "use voting;";
            command.ExecuteNonQuery();
            command.CommandText = "select count(choice) as choice from votingtable where choice=\'" + text +"\';";
            //command.Prepare();
            //command.Parameters.AddWithValue("@choice", text);
            rdr = command.ExecuteReader();
            int result = 0;
            while (rdr.Read())
            {
                result = Convert.ToInt16(rdr[0]);
            }

            rdr.Close();
            return result;
        }

        /// <summary>
        /// clear all data inside a table
        /// </summary>
        /// <returns></returns>
        public bool clearData()
        {
            try
            {
                command.CommandText = "use voting;";
                command.ExecuteNonQuery();
                command.CommandText = "delete from votingTable;";
                command.ExecuteNonQuery();
                return true;
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        /// <summary>
        /// create a datavase inside te server and also create te corresponding table that
        /// will store the voting data
        /// </summary>
        /// <returns></returns>
        public bool createDB()
        {
            
            try
            {
                command.CommandText = "CREATE DATABASE IF NOT EXISTS voting;";
                command.ExecuteNonQuery();
                command.CommandText = "use voting;";
                command.ExecuteNonQuery();
                command.CommandText = "create table IF NOT EXISTS votingTable (IDNumber varchar(14) not null," +
                                                "MotherName varchar(255) not null," +
                                                "votingdate datetime," +                                                
                                                "primary key (IDNumber)" +
                                                ");";
                command.ExecuteNonQuery();
                command.CommandText = "create table IF NOT EXISTS result (ID varchar(14) not null," +
                                                "choice varchar(40) not null" +
                                                ");";
                command.ExecuteNonQuery();
                return true;
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
    }
}
