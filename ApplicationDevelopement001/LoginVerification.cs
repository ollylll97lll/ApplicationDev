using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ApplicationDevelopement001
{
    public class LoginVerification
    {
        protected string Username, Password;
        protected string ConnectionString = "Data Source=UR-DETDY;Initial Catalog=ApplicationDevAssignment;Integrated Security=True";

        //Check Account
        public bool AccountVerify(string UN, string PW, string role)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Validatequery = "SELECT * FROM [Account] WHERE UserName ='" + UN + "' AND Password ='" + PW + "' AND Role = '" + role + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(Validatequery, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            connection.Close();
            if (dtbl.Rows.Count == 1)
            {
                return true;
            }
            else return false;
            
        }
    }
}
