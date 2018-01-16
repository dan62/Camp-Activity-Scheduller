//references used in this form
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
    public partial class Update_activity : Form
    {
        //global variable to be used by multiple classes
        private string connection = "datasource=localhost;port=3306;username=root;password= ";

        public Update_activity()
        {
            InitializeComponent();
        }

        //the main method which is used when the form is loaded
        private void Update_activity_Load(object sender, EventArgs e)
        {
            //we set up the interface by hiding inecessary items
            activity_image.Hide();
            activity_name_retreived.Hide();
            advisor_retreived.Hide();
            participant_max_retreived.Hide();
            date_retreived.Hide();
            description_retreived.Hide();
            save_update_button.Hide();
        }

        //method is used when search activities button is clicked
        private void search_activity_button_Click(object sender, EventArgs e)
        {

            //try catch block to catch any errors connecting with database
            try
            {

                //query to retreive data
                string Query = "select * from icamp.activities where activity_name='" + this.Activity_name.Text + "' AND date='" + this.date.Text +"';";

                //creating and using the connection
                MySqlConnection connection_firm = new MySqlConnection(connection);
                MySqlCommand execute_query = new MySqlCommand(Query, connection_firm);
                
                //using mysql adapter to save the data to a data table 
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = execute_query;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                    //assigning fetched data from the data table to the textboxes 
                    activity_name_retreived.DataBindings.Add("Text", dTable, "activity_name");
                    advisor_retreived.DataBindings.Add("Text", dTable, "advisor_name");
                    participant_max_retreived.DataBindings.Add("Text", dTable, "seats_available");
                    date_retreived.DataBindings.Add("Text", dTable, "date");
                    description_retreived.DataBindings.Add("Text", dTable, "description");

                    //displaying appropriate GUI features
                    activity_image.Show();
                    activity_name_retreived.Show();
                    advisor_retreived.Show();
                    participant_max_retreived.Show();
                    date_retreived.Show();
                    description_retreived.Show();
                    save_update_button.Show();
               
            }
            catch (Exception ex)
            {
                //if an error is encountered it will throw the error in a messagebox
                MessageBox.Show(ex.Message);
            }
        }


        //this method is used when the save update button is clicked
        private void save_update_button_Click(object sender, EventArgs e)
        {
            //a try catch block is used to catch any errors whilst interacting with the database
            try
            {
                //querry used to update the current data in the database
                string Query = "update icamp.activities set activity_name='" + this.activity_name_retreived.Text + "',advisor_name='" + this.advisor_retreived.Text + "',seats_available='" + this.participant_max_retreived.Text + "',date='" + this.date_retreived.Text + "',description='" + this.description_retreived.Text + "' WHERE activity_name='" + this.activity_name_retreived.Text + "'";

                //creating and using connection to database
                MySqlConnection connection_firm = new MySqlConnection(connection);
                MySqlCommand execute_query = new MySqlCommand(Query, connection_firm);
                MySqlDataReader MyReader2;
                connection_firm.Open();
                MyReader2 = execute_query.ExecuteReader();

                //if the data has been updated then a message will be displayed
                MessageBox.Show("You have updated the activity");
                while (MyReader2.Read())
                {
                }

                connection_firm.Close();
            }
            catch (Exception ex)
            {
                //if an error is encountered then it will be thrown in a messagebox
                MessageBox.Show(ex.Message);
            }
        }
    }
}
