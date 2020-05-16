using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopement001
{
    class TRCl
    {
        //Trainer variables
        private string TrainerID, Name, Education, Employment, location, telephone, email,TopicID;
        private DateTime DoB;
        //Trainee variables
        private string TraineeID, trName, tredu, trprog_lan, trTOEIC, trexp_detail, trdept, CourseID;
        private DateTime trDoB;
        private string ConnectionString = "Data Source=UR-DETDY;Initial Catalog = AppDev; Integrated Security = True";


        internal TRCl() { }
        //constructor takes Trainer info
        internal TRCl(string id, string name, string edu, string emp, string loca , string tel, string e, DateTime DoB, string TopID)
        {
            this.TrainerID = id;
            this.Name = name;
            this.Education = edu;
            this.Employment = emp;
            this.location = loca;
            this.telephone = tel;
            this.email = e;
            this.DoB = DoB;
            this.TopicID = TopID;
        }
        //constructor takes TRainee info
        internal TRCl(string id, string name, string edu, DateTime DoB, string prog, string TOEIC, string exp, string dept, string CourseID)
        {
            this.TraineeID = id;
            this.trName = name;
            this.tredu = edu;
            this.trDoB = DoB;
            this.trprog_lan = prog;
            this.trTOEIC = TOEIC;
            this.trexp_detail = exp;
            this.trdept = dept;
            this.CourseID = CourseID;
        }

        //RETRIEVE COURSEID
        internal List<string> IDretrieve()
        {
            List<string> ID = new List<string>();
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "select Course_ID from Course";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID.Add(reader[0].ToString());
            }
                return ID;
        }


        //Add
        internal int Add()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string query = "";
            con.Open();
                    query = "INSERT INTO TRAINEE (TRAINEE_ID,       NAME,       DOBIRTH,        EDUCATION,   PROG_LANGUAGE,      TOEIC,      EXP_DETAIL,     DEPARTMENT,       COURSE_ID)" 
                        + "VALUES               ('"+TraineeID+ "', '"+trName+ "', '"+trDoB+ "', '"+tredu+ "', '"+trprog_lan+ "', '"+trTOEIC+ "','"+trexp_detail+ "','"+trdept+ "','"+CourseID+"' )";
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        //internal int Update(string role)
        //{

        //}

    }
}
