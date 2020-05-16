using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ApplicationDevelopement001
{
    internal class TCC_PopupCl
    {
        string ID, Name, Description, Assigned_Role;

        //SQL connection String
        internal string ConnectionString = "Data Source=UR-DETDY;Initial Catalog=AppDev;Integrated Security=True";


        //constructor
        internal TCC_PopupCl(string ID, string Name, string Descrip, string Arole)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Descrip;
            this.Assigned_Role = Arole;
        }
        internal TCC_PopupCl() { }

        //Add Course information into the form
        internal int Add(string role)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string query = "";
            switch (role)
            {
                case "Category":
                    query = "INSERT INTO Category (Name,Description,Cat_ID)" +
                " values ('" + Name + "','" + Description + "','" + ID + "' ) ";
                    break;
                case "Course":
                    query = "INSERT INTO COURSE (Name,Description,Course_ID,Cat_ID)" +
               " values ('" + Name + "','" + Description + "','" + ID + "','" + GetID(Assigned_Role.ToString(),"Course") + "' ) ";
                    break;
                case "Topic":
                    query = "INSERT INTO TOPIC (Name,Description,Topic_ID,Course_ID)" +
               " values ('" + Name + "','" + Description + "','" + ID + "' ,'" + GetID(Assigned_Role.ToString(), "Topic") + "') ";
                    break;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close(); 
            return i;
        }

        internal string GetID(string Name,string role)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string query = "";
            string ID = "";
            con.Open();
            switch (role)
            {
                case "Course":
                    query = "select Cat_ID from Category where Name = '"+ Name+"' ";
                    break;
                case "Topic":
                    query = "select Course_ID from Course where Name = '" + Name + "' ";
                    break;
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ID = reader[0].ToString();
            }
            con.Close();
            return ID;
        }

        internal string getCatData(string name, string datatype)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Data = "";
            string query = "";
            switch (datatype)
            {
                case "Cat_ID":
                    query = "Select Cat_ID from Category where Name  = '" + name + "'";
                    break;
                case "Description":
                    query = "Select Description from Category where Name  = '" + name + "'";
                    break;
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Data = (reader[0].ToString());
            }
            con.Close();
            return Data;
        }

        internal string getCourseData(string name, string datatype)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Data = "";
            string query = "";
            switch (datatype)
            {
                case "Course_ID":
                    query = "Select Course_ID from Course where Name  = '" + name + "'";
                    break;
                case "Description":
                    query = "Select Description from Course where Name  = '" + name + "'";
                    break;
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Data = (reader[0].ToString());
            }
            con.Close();
            return Data;
        }

        internal string getTopicData(string name, string datatype)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Data = "";
            string query = "";
            switch (datatype)
            {
                case "Topic_ID":
                    query = "Select Topic_ID from Topic where Name  = '" + name + "'";
                    break;
                case "Description":
                    query = "Select Description from Topic where Name  = '" + name + "'";
                    break;
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Data = (reader[0].ToString());
            }
            con.Close();
            return Data;
        }
    }
}
