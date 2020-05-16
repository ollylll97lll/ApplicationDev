using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopement001
{
    class AdminCl
    {
        private string username, password, role, account_ID;
        private string ConnectionString = "Data Source=UR-DETDY;Initial Catalog = AppDev; Integrated Security = True";
        internal AdminCl(string u, string p, string r, string id)
        {
            this.username   = u;
            this.password   = p;
            this.role       = r;
            this.account_ID = id;
        }
        internal AdminCl() { }

        //Retrieve Info
        internal DataTable AccountTable()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string query = "Select *from Account";
            SqlCommand cmd = new SqlCommand(query,con);
            DataTable dtbl = new DataTable();
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            dtbl.Load(read);
            con.Close();
            return dtbl;
        }

        //Add method
        internal int Add()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string query = "INSERT INTO ACCOUNT ( USERNAME, PASSWORD, ROLE, ACC_ID) VALUES ('"+username+"','"+password+"','"+role+"','"+account_ID+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        //Update method
        internal int Update(string updaterow)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "UPDATE ACCOUNT set USERNAME = '" + username + "',PASSWORD = '" + password + "', ROLE = '" + role + "' WHERE ACC_ID = '" + updaterow + "'   ";
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        
        //Bring data to textboxes for update
        internal string UpdateData(string UpdateRow, string datatype )
        {
            string Data = "";
            string query = "";
            SqlConnection con = new SqlConnection(ConnectionString);
            switch (datatype)
            {
                case "Role":
                    query = "SELECT Role FROM ACCOUNT WHERE ACC_ID = '" + UpdateRow + "' ";
                    break;
                case "Username":
                    query = "SELECT Username FROM ACCOUNT WHERE ACC_ID = '" + UpdateRow + "' ";
                    break;
                case "Password":
                    query = "SELECT Password FROM ACCOUNT WHERE ACC_ID = '" + UpdateRow + "' ";
                    break;
                case "Acc_ID":
                    query = "SELECT Acc_ID FROM ACCOUNT WHERE ACC_ID = '" + UpdateRow + "' ";
                    break;
            }
             con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Data = (reader[0].ToString());
            }
            con.Close();
            return Data;
        }

        //Delete method
        internal int Delete(string DeleteRow)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE  FROM ACCOUNT WHERE ACC_ID = '" + DeleteRow + "'", con);
           int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
