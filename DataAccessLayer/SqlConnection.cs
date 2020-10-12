﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    class SqlConnection
    {


        private MySqlConnection CreateConnection()
        {
            MySqlConnection cnn;
            string connetionString = $"server=185.182.57.161;database=tijnvcd415_SLB;uid=tijnvcd415_Danillo;pwd=123456;";
            cnn = new MySqlConnection(connetionString);
            return cnn;
        }

        public List<string> ExecuteSearchQuery(string query)
        {
            List<string> readerResults = new List<string>();
            MySqlConnection cnn = CreateConnection();
            MySqlCommand cmd = new MySqlCommand
            {
                CommandText = query,
                Connection = cnn
            };
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    readerResults.Add(reader[i].ToString());
                }
            }
            cnn.Close();
            return readerResults;
        }

        public List<string> ExecuteSearchQueryParameters(string query, List<string[]> parameters)
        {
            List<string> readerResults = new List<string>();
            MySqlConnection cnn = CreateConnection();
            MySqlCommand cmd = GenerateCommand(query, cnn);
            cmd = AddParameters(cmd, parameters);
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    readerResults.Add(reader[i].ToString());
                }
            }
            cnn.Close();
            return readerResults;
        }

        public void ExecuteNonSearchQuery(string query)
        {
            MySqlConnection cnn = CreateConnection();
            MySqlCommand cmd = GenerateCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void ExecuteNonSearchQueryParameters(string query, List<string[]> parameters)
        {
            MySqlConnection cnn = CreateConnection();
            MySqlCommand cmd = GenerateCommand(query, cnn);
            cmd = AddParameters(cmd, parameters);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public List<string> ExecuteGetStringQuery(string query)
        {
            List<string> readerResults = new List<string>();
            MySqlConnection cnn = CreateConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = cnn;
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            readerResults.Clear();
            while (reader.Read())
            {

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    readerResults.Add(reader.GetString(i));
                }
            }
            cnn.Close();
            return readerResults;
        }

        public List<string[]> ExecuteSearchQueryWithArrayReturn(string query, List<string[]> parameters)
        {
            List<string[]> values = new List<string[]>();
            MySqlConnection cnn = CreateConnection();
            MySqlCommand cmd = GenerateCommand(query, cnn);
            cmd = AddParameters(cmd, parameters);
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            values.Clear();
            try
            {
                while (reader.Read())
                {
                    string[] tempStrArr = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        tempStrArr[i] = reader[i].ToString();
                    }
                    values.Add(tempStrArr);
                }
            }
            catch (Exception e)
            {
                string eString = e.ToString();
            }
            cnn.Close();
            return values;
        }


        private MySqlCommand AddParameters(MySqlCommand cmd, List<string[]> parameters)
        {
            foreach (string[] array in parameters)
            {
                cmd.Parameters.Add(new MySqlParameter(array[0], array[1]));
            }
            return cmd;
        }

        private MySqlCommand GenerateCommand(string query, MySqlConnection cnn)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = cnn;
            return cmd;
        }

    }
}



