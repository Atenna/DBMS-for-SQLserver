﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManagementSystem.Security;

namespace DBManagementSystem.DataHandler
{
    public static class ObjectCreator
    {
        public static void CreateTable(NewConnection connection, string tableName)
        {
            string commandString = "CREATE TABLE " + tableName + " ( id int primary key );";
            SqlCommand sqlCmd = new SqlCommand(commandString, connection.Connection);
            sqlCmd.ExecuteNonQuery();
        }

        public static void CreateColumn(NewConnection connection, string columnName, string type, bool autoIncrement, bool unique, bool primaryKey)
        {
            string commandString = "ALTER TABLE " + connection.ActualTable +" ADD " + columnName + " " + type;
            if (autoIncrement)
            {
                commandString += " IDENTITY(1,1)";
            }
            commandString += ";";
            Console.WriteLine(commandString);
            SqlCommand sqlCmd = new SqlCommand(commandString, connection.Connection);
            sqlCmd.ExecuteNonQuery();

            if (unique)
            {
                commandString = "ALTER TABLE " + connection.ActualTable + " ADD UNIQUE ( " + columnName+ ");";
                Console.WriteLine(commandString);
                sqlCmd = new SqlCommand(commandString, connection.Connection);
                sqlCmd.ExecuteNonQuery();
            }
        }

        public static void CreateDatabase(NewConnection connection, string databaseName)
        {
            var command = connection.Connection.CreateCommand();
            command.CommandText = "CREATE DATABASE " + databaseName;
            command.ExecuteNonQuery();
        }
    }
}
