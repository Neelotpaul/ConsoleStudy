using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ADOStudy
{
    public class ADO
    {
        public System.Data.SqlClient.SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
        
        public bool Insert(Info dataInsert)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string query = "Insert into Info values ('" + dataInsert.Name + "', '" +dataInsert.Gender+ "')";
            cmd.CommandText = query;

            int res = 0;
            con.Open();
            res = cmd.ExecuteNonQuery();
            con.Close();
            if (res >= 1)
            {
                return true;
            }
            return false;
            
        }

        public DataSet Retrieve()
        {
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string query = "select * from Info";
            cmd.CommandText = query;

            DataSet dsSelect = new DataSet();
            con.Open();
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dsSelect);
            con.Close();
            return dsSelect;
        }

        public bool Update()
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string query = "Update Info SET Name='Neel',Gender='Male'";
            cmd.CommandText = query;

            int res = 0;
            con.Open();
            res = cmd.ExecuteNonQuery(); 
            con.Close();
            if (res >= 1)
            {
                return true;
            }
            return false;
        }

        public bool Delete()
        {
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string query = "Delete From Info"; 
            cmd.CommandText = query;

            int res = 0;
            con.Open();
            res = cmd.ExecuteNonQuery();
            con.Close();
            if (res >= 1)
            {
                return true;
            }
            return false;

        }


    }



}
