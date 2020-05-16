using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDevelopement001
{
    public partial class Staff : Form
    {
        public static string Action = "";
        StaffClass SC = new StaffClass();
        private string TR_Role = "";
        
        
        private List<string> CatName = new List<string>();
        private List<string> CourseName = new List<string>();
        private List<string> TopicName = new List<string>();
        
        
        //string TCC_Role = "";
        // variables for moving windows
        // indicate mouse trigger event     mov
        // indicate mouse axis              movX
        // indicate mouse axyl              movY
        private int mov, movX, movY;

        public Staff()
        {
            InitializeComponent();
            //Hide both groupbox
            TR_GB.Hide();
            TCC_GB.Hide();
            //Hide description text
            TCC_Cat_Description_Text_LB.Text = "";
            //Hide no result label
            No_result_LB.Hide();
            TCC_Course_LB.Hide();
            TCC_Topic_LB.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }


        /// <summary>
        /// Form basic functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        //Choose Trainer & Trainee Groupbox
        private void TR_BT_Click(object sender, EventArgs e)
        {
            TR_GB.Show();
            TR_GB.BringToFront();
        }

        //Show and CRUD Trainer Data
        private void TR_trainer_BT_Click(object sender, EventArgs e)
        {
            TR_Role = "Trainer";
            
            //Clear the Data Grid View and fill with new data source
            TR_DGV.DataSource = null;
            TR_DGV.DataSource = SC.RetrieveAllQuery(TR_Role);

            //Change the attributes in the combobox based on the data source
            TR_Search_attributes_CB.DataSource = SC.RetrieveDataAtrributesQuery(TR_Role);
        }

        //Show and CRUD Trainee Data
        private void TR_trainee_BT_Click(object sender, EventArgs e)
        {
            TR_Role = "Trainee";
            
            //Clear the Data Grid View and fill with new data source
            TR_DGV.DataSource = null;
            TR_DGV.DataSource = SC.RetrieveAllQuery(TR_Role);

            //Change the attributes in the combobox based on the data source
            TR_Search_attributes_CB.DataSource = SC.RetrieveDataAtrributesQuery(TR_Role);
        }

        //Trainer & Trainee group Search Textbox method
        private void TR_Search_TB_TextChanged(object sender, EventArgs e)
        {
            DataView SGrid = SC.RetrieveAllQuery(TR_Role).DefaultView;
            SGrid.RowFilter = string.Format("{0} LIKE '%{1}%'",TR_Search_attributes_CB.Text, TR_Search_TB.Text);
            TR_DGV.DataSource = SGrid.ToTable();
        }
        
        //Add new Trainer / Trainer button
        private void Add_Trainer_Trainee_button_Click(object sender, EventArgs e)
        {
            Action = "Add";
            this.Hide();
            //Check whether there are any exist instance initialized from the form type
            TR_PopupForm existing = Application.OpenForms.OfType<TR_PopupForm>().FirstOrDefault();
            if (existing != null)
            {
                existing.Show();
                existing.Refresh();
            }
            else
            {
                TR_PopupForm tr = new TR_PopupForm();
                tr.Show();
            }
           
        }


      /// <summary>
        /// Trainer and Trainee related functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        //Choose Topic, Course and Category Groupbox
        private void TCC_BT_Click(object sender, EventArgs e)
        {
            //bring the TCC group box to front
            TCC_GB.Show();
            TCC_GB.BringToFront();
            
            //fill Category listbox with Category Name
            TCC_Cat_LB.DataSource = SC.CatNameRec();
            CatName = SC.CatNameRec();
            
            //Deselect index from all listbox
            TCC_Cat_LB.SelectedIndex = -1;
            TCC_Course_LB.SelectedIndex = -1;
            TCC_Topic_LB.SelectedIndex = -1;

        }

        //Show Category Courses based on select item.
        private void TCC_Cat_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TCC_Cat_LB.SelectedIndex != -1)
            {
                TCC_Course_LB.Show();
                //retrieve Category select item ID
                string x = SC.TCIDRec(TCC_Cat_LB.SelectedItem.ToString(), "Category");
                
                //Use the retrieved ID to search for list of Courses Name have the same ID
                TCC_Course_LB.DataSource = SC.TCNameRec(x, "Course");
                CourseName = SC.TCNameRec(x, "Course");

                //retrieve Category Description
                TCC_Cat_Description_Text_LB.Text = SC.TCCDataDescripRetrieve("Category", TCC_Cat_LB.Text.ToString()); ;
            
                //refresh Topic List Box 
                if(TCC_Topic_LB.DataSource != null)
                {
                    TCC_Topic_LB.Hide();
                    TCC_Topic_LB.DataSource = null;
                }
            }
        }

        //Show Course topics based on the select item
        private void TCC_Course_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(TCC_Course_LB.SelectedIndex != -1)
            {
                TCC_Topic_LB.Show();
                //retrieve ID of the select item.
                string x = SC.TCIDRec(TCC_Course_LB.SelectedItem.ToString(), "Course");
                
                //retrieve Topic Items have the same ID as the Course ID.
                TCC_Topic_LB.DataSource = SC.TCNameRec(x, "Topic");
                TopicName = SC.TCNameRec(x, "Topic");

                //retrieve Course Description
                TCC_Course_Description_Text_LB.Text = SC.TCCDataDescripRetrieve("Course", TCC_Course_LB.Text.ToString());
            }
        }

        //Show description of the select topic.
        private void TCC_Topic_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TCC_Topic_LB.SelectedIndex != -1)
            {
                TCC_Topic_Description_Text_LB.Text = SC.TCCDataDescripRetrieve("Topic", TCC_Topic_LB.Text.ToString());
            }
        }


        //search item correspond to select data
        private void TCC_Search_TB_TextChanged(object sender, EventArgs e)
        {
            string role = TCC_Atributes_CB.SelectedItem.ToString();
            List<string> results = new List<string>();
            switch (role)
            {
                case "Category":
                    if (!string.IsNullOrEmpty(TCC_Search_TB.Text))
                    {
                        foreach (string str in CatName)
                        {
                            if (str.Contains(TCC_Search_TB.Text))
                            {
                                results.Add(str);
                            }
                        }
                        if (results.Count == 0)
                        {
                            No_result_LB.Show();
                        }
                        else No_result_LB.Hide();
                        TCC_Cat_LB.DataSource = results;

                    }
                    else TCC_Cat_LB.DataSource = SC.CatNameRec();
                    break;
                case "Course":
                    if (!string.IsNullOrEmpty(TCC_Search_TB.Text))
                    {
                        foreach (string str in CourseName)
                        {
                            if (str.Contains(TCC_Search_TB.Text))
                            {
                                results.Add(str);
                            }
                        }
                        if (results.Count == 0)
                        {
                            No_result_LB.Show();
                        }
                        else No_result_LB.Hide();
                        TCC_Course_LB.DataSource = results;
                    }
                    else TCC_Course_LB.DataSource = CourseName;
                    break;
                case "Topic":
                    if (!string.IsNullOrEmpty(TCC_Search_TB.Text))
                    {
                        foreach (string str in TopicName)
                        {
                            if (str.Contains(TCC_Search_TB.Text))
                            {
                                results.Add(str);
                            }
                        }
                        if (results.Count == 0)
                        {
                            No_result_LB.Show();
                        }
                        else No_result_LB.Hide();
                        TCC_Topic_LB.DataSource = results;
                    }
                    else TCC_Topic_LB.DataSource = TopicName;
                    break;
            }
        }

        //Add new info
        private void TopCouCat_Add_button_Click(object sender, EventArgs e)
        {
            TopCoursCatPopup existing = Application.OpenForms.OfType<TopCoursCatPopup>().FirstOrDefault();
            if (existing != null)
            {
                existing.Show();
                existing.Refresh();
            }
            else
            {
                TopCoursCatPopup TCCPopup = new TopCoursCatPopup();
                TCCPopup.Show();
            }
            this.Hide();
        }
    }
}
