﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctrl_doc
{
    class clsDB
    {

        static string cs = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\BDD.mdf;Integrated Security=True", Directory.GetCurrentDirectory());
        //-------------------< Class: DB >-------------------
        static string ss = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\bdd.mdf;Integrated Security=True", Directory.GetCurrentDirectory());


        public SqlConnection Get_DB_Connection()

        {

            //--------< db_Get_Connection() >--------

            //< db oeffnen >

            //string cn_String = Properties.Settings.Default.connection_String;
            string cn_String = cs;

            SqlConnection cn_connection = new SqlConnection(cn_String);

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            //</ db oeffnen >



            //< output >

            return cn_connection;

            //</ output >

            //--------</ db_Get_Connection() >--------

        }



        public DataTable read(string SQL_Text)

        {

            //--------< db_Get_DataTable() >--------

            SqlConnection cn_connection = Get_DB_Connection();



            //< get Table >

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(SQL_Text, cn_connection);

            adapter.Fill(table);

            //</ get Table >



            //< output >

            return table;

            //</ output >

            //--------</ db_Get_DataTable() >--------

        }



        public void write(string SQL_Text)

        {

            //--------< Execute_SQL() >--------

            SqlConnection cn_connection = Get_DB_Connection();



            //< get Table >

            SqlCommand cmd_Command = new SqlCommand(SQL_Text, cn_connection);

            cmd_Command.ExecuteNonQuery();

            //</ get Table >



            //--------</ Execute_SQL() >--------

        }







        public void Close_DB_Connection()
        {

            //--------< Close_DB_Connection() >--------

            //< db oeffnen >

            string cn_String = cs;

            SqlConnection cn_connection = new SqlConnection(cn_String);

            if (cn_connection.State != ConnectionState.Closed) cn_connection.Close();

            //</ db oeffnen >



            //--------</ Close_DB_Connection() >--------

        }

        //-------------------</ Class: DB >-------------------

    }
}
