//references used in the project
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCamp_v1._0
{
    public partial class activities_add : Form
    {
        //global variable to be used by multiple methods
        string connection = "datasource=localhost;port=3306;username=root;password= ";

        public activities_add()
        {
            InitializeComponent();
        }

        //method used when add activity button is clicked on 
        private void add_activity_button_Click(object sender, EventArgs e)
        {
            //try catch block to insert activity incase of failure we can display the error in messagebox
            try
            {
                //the query i used to insert data 
                string Query = "insert into icamp.activities(activity_name,advisor_name,seats_available,date,description) values('" + this.Activity_name.Text + "','" + this.Advisor.Text + "','" + this.participant_max.Text + "','" + this.date.Text + "','" + this.description.Text +"');";

                //creating the connection and opening it
                MySqlConnection connection_firm = new MySqlConnection(connection);
                MySqlCommand execute_query = new MySqlCommand(Query, connection_firm);

                //reading the data 
                MySqlDataReader MyReader2;
                connection_firm.Open();
                MyReader2 = execute_query.ExecuteReader();

                //message on successfull entry
                MessageBox.Show("You have successfully added an Activity!");

                //assigning default text in labels after entry succeeds
                Activity_name.Text = "Activity Name";
                Advisor.Text = "Advisor Name";
                participant_max.Text = "Number of seats";
                description.Text = "Describe the activity and how it shall be conducted.";


                while (MyReader2.Read())
                {
                }
                connection_firm.Close();
            }
            catch (Exception ex)
            {
                //If an error occurs then a message shall be shown identifying the problem
                MessageBox.Show(ex.Message);
            }
        }

        //method used when the delete button is clicked 
        private void delete_activity_button_Click(object sender, EventArgs e)
        {
            //we try deleting the data and catch any exception
            try
            {
                
                //The query used to delete the data from the database
                string Query = "delete from icamp.activities where activity_name='" + this.activity_name_del.Text + "' AND advisor_name ='" + this.advisor_del.Text + "' AND date ='" + this.date_activity_del.Text + "';";

                //turning the string into a mysql connection then opening it
                MySqlConnection connection_firm = new MySqlConnection(connection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connection_firm);
                MySqlDataReader MyReader2;
                connection_firm.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                //message box to display when the activity is deleted
                MessageBox.Show("Activity has been deleted!");

                //assigning default text to the textboxes after deletion
                activity_name_del.Text = "Activity Name";
                advisor_del.Text = "Advisor Name";

                while (MyReader2.Read())
                {
                }
                connection_firm.Close();
            }
            catch (Exception ex)
            {
                //if an error is encountered it shall be throuwn as a message
                MessageBox.Show("The data either does not exist on the server or you have no connection to the server!");
            }
        }
    }
}
