using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ApplicationDevelopement001
{
   internal class StaffClass
    {
        //constructor
        internal StaffClass() { }
       
        //SQL connection String
        internal string ConnectionString = "Data Source=UR-DETDY;Initial Catalog=AppDev;Integrated Security=True";
        
        //SQL retreive all query method based on the data role
        internal DataTable RetrieveAllQuery(string role)
        {
            // replace the role into query to retrieve response table.
            string Query = "SELECT * FROM ["+role+"]";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(Query,con);
            DataTable dtbl = new DataTable();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtbl.Load(reader);
            con.Close();
            return dtbl;
        }
        /// <summary>
        /// methods for Trainer and Trainee
        /// </summary>
        /// <returns></returns>



        //Retreive Category Name from SQL
        internal List<string> CatNameRec()
        {
            List<string> Name = new List<string>();
            string query = "Select Name from Category";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            //Add result to the Name list
            while (reader.Read())
            {
                Name.Add(reader[0].ToString());
            }
            con.Close();
            return Name;
        }
        //Retreive Course Name from SQL
        internal List<string> CourseNameRec()
        {
            List<string> Name = new List<string>();
            string query = "Select Name from Course";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            //Add result to the Name list
            while (reader.Read())
            {
                Name.Add(reader[0].ToString());
            }
            con.Close();
            return Name;
        }

        //REtrieve ID of Topic/Course from SQl
        internal string TCIDRec(string name, string mainrole)
        {
            //create new query and list contains ID

            //List<string> ID = new List<string>();

            string ID = "";
            string IDquery = "";
            //Retrieve ID
            //for different main role, the query change to retrieve the response ID.
            switch (mainrole)
            {
                case "Category":
                    //The query asks to retrieve Category ID 
                    //of the correspond Category Name in the row
                    IDquery = "select Cat_ID from Category where Name like '" + name + "' ";
                    break;
                case "Course":
                    //The query asks to retrieve Course ID 
                    //of the correspond Course Name in the row
                    IDquery = "select Course_ID from Course where Name like '" + name + "' ";
                    break;
            }

            SqlConnection IDcon = new SqlConnection(ConnectionString);
            IDcon.Open();
            SqlCommand IDcmd = new SqlCommand(IDquery, IDcon);
            SqlDataReader IDreader = IDcmd.ExecuteReader();
            
            //Add items into the list
            while (IDreader.Read())
            {
                ID = IDreader[0].ToString();
            }
            IDcon.Close();
            //return with a list of correspond ID.
            return ID;
        }

        //Retrieve Topic and Course Name from SQL
        internal List<string> TCNameRec(string ID, string subrole)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            
            List<string> Name = new List<string>();

            //execute search query on the ID list by search the items one by one, 
            //each will add a list of Name correspond to the Category ID.
           // for (int i = 0; i < ID.Count();i++)
            //{
                string query = "";
            switch (subrole)
            {
                case "Course":
                    query = "select Name from Course where Cat_ID = '" + ID + "' ";
                    break;
                case "Topic":
                    query = "select Name from Topic where Course_ID = '" + ID + "'  ";
                    break;
            }
            con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader read = cmd.ExecuteReader();
                //group all the lists of Name into a new list
                while (read.Read())
                {
                    Name.Add(read[0].ToString());
                }
                con.Close();
           // }
            return Name;
        }
        /// <summary>
        ///take name from role tuong ung (Cat lay name tu bang Cat...) -> nhan string: role
        ///       => select name from role
        ///
        /// take name using Cat name -> list Course iD -> list Course Name -> nhan string name
        ///        => select ID from role where name = name
        ///              => select name from ...join...on ID = ID
        ///
        /// take name using Course name -> list Topic ID -> Topic Name -> nhan string name
        ///        => select ID from role where name = name
        ///              => select name from ... join ... on ID = ID
        /// </summary>
        /// <param name="datatype"></param>
        /// <param name="dataname"></param>
        /// <returns></returns>

        //Retrieve Topics, Courses and Categories descriptions from SQL
        internal string TCCDataDescripRetrieve(string datatype, string dataname)
        {
            string DataDescription = "";
            string DataDesRetrieveQuery = "";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            switch (datatype)
            {
                case "Category":
                    DataDesRetrieveQuery = "select Description from Category where Name = '" + dataname + "'";
                    break;
                case "Course":
                    DataDesRetrieveQuery = "SELECT Description FROM Course WHERE Name = '" + dataname + "'";
                    break;
                case "Topic":
                    DataDesRetrieveQuery = "SELECT Description FROM Topic WHERE Name = '" + dataname + "'";
                    break;
            }
            SqlCommand cmd = new SqlCommand(DataDesRetrieveQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                DataDescription = reader[0].ToString();
            }
            return DataDescription;
        }

        //SQL retrieve attributes query method based on the data role
        internal List<string> RetrieveDataAtrributesQuery(string role)
        {
            List<string> RetrieveData = new List<string>();
            string RetrievedQuery = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"+ role +"' ORDER BY ORDINAL_POSITION";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(RetrievedQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RetrieveData.Add(reader[0].ToString());
            }
            con.Close();
            return RetrieveData;
        }
    }
}
