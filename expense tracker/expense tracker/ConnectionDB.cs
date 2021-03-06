﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace expense_tracker
{
    class ConnectionDB
    {
        string DatabaseFilename;
        string DBConnectionInfo;
        public ConnectionDB(string _DatabaseFilename)
        {
            DatabaseFilename = _DatabaseFilename;
            DBConnectionInfo = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + DatabaseFilename + ";Persist Security Info=False";
        }

        public bool TestConnection()
        {
            OleDbConnection db = new OleDbConnection();
            db.ConnectionString = DBConnectionInfo;
            bool state = false;
            //try catch 
            try
            {
                db.Open();
                state = (db.State == ConnectionState.Open);
                db.Close();
            }

            catch
            {
                MessageBox.Show("Not Connected to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return state;
        }

        public void ExecuteQuery(string sql)

        {
            try
            {

                //Sets up the connection to the database
                OleDbConnection db = new OleDbConnection();
                db.ConnectionString = DBConnectionInfo;


                // Open the connection in a try/catch block. 
                db.Open();
                //create  a sql command to execute over our database
                OleDbCommand sqlCommand = new OleDbCommand();
                //give the sqlCommand the connection.
                sqlCommand.Connection = db;
                //give the sqlCommand the sql statement
                sqlCommand.CommandText = sql;
                sqlCommand.ExecuteNonQuery();   //Executes the  command
                // Call Close.Remember this is always a good practice.
                db.Close();
                MessageBox.Show("Data is updated!");
            }
            catch
            {
                MessageBox.Show("The data is not saved!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public OleDbDataReader findData(string sql)
        {
            //Sets up the connection to the database
            OleDbConnection db = new OleDbConnection();
            db.ConnectionString = DBConnectionInfo;


            // Open the connection in a try/catch block. 
            db.Open();
            //create  a sql command to execute over our database
            OleDbCommand sqlCommand = new OleDbCommand();
            //give the sqlCommand the connection.
            sqlCommand.Connection = db;
            //give the sqlCommand the sql statement
            sqlCommand.CommandText = sql;
            //Creates a data set out of the data
            // Create and execute the DataReader, writing the result in the textboxs
            OleDbDataReader reader = sqlCommand.ExecuteReader();
            return reader;

        }
    }
}
