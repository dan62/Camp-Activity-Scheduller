//referenced used in this form
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
    public partial class add_students : Form
    {
        //global variable to be used in multiple methods
        string connection = "datasource=localhost;port=3306;username=root;password= ";

        public add_students()
        {
            InitializeComponent();
        }

        //this method is used when the signup button is clicked 
        private void login_Click(object sender, EventArgs e)
        {
            //we use try catch block to catch any errors and avoid exceptions
            try
            {
                //the query used to save the data to the mysql database
                string Query = "insert into icamp.students(students_name,age,email,cellphone_number,school,medical_aid) values('" + this.students_name.Text + "','" + this.age.Text + "','" + this.p_email.Text + "','" + this.cellphone.Text + "','" + this.school.Text + "','" + this.medical_aid.Text + "');";

                //turning the connection string into a mysql connection and using it
                MySqlConnection connection_firm = new MySqlConnection(connection);
                MySqlCommand execute_query = new MySqlCommand(Query, connection_firm);
                MySqlDataReader MyReader2;
                connection_firm.Open();
                MyReader2 = execute_query.ExecuteReader();

                //if the insert is successfull this message shall be printed
                MessageBox.Show("You have added the student to the system!");
                while (MyReader2.Read())
                {
                }

                connection_firm.Close();
            }
            catch (Exception ex)
            {
                //if an error occurs it shall be thrown in the form of a message
                MessageBox.Show(ex.Message);
            }

            //setting the textboxes to default text after insertion
            students_name.Text = "Students Name";
            age.Text = "Students Age";
            p_email.Text = "Parent Email";
            cellphone.Text = "Parent Cellphone";
            school.Text = "School Name";
            medical_aid.Text = "Medical Aid Number";

        }

        //This is the main method and it is loaded when the form is loaded
        private void add_students_Load(object sender, EventArgs e)
        {
            //try catch block to catch any errors when retriving activities 
            try
            {
                //we create the connection
                MySqlConnection connection_firm = new MySqlConnection(connection);
                MySqlDataAdapter adapter;

                //creating the data table to store activities
                DataTable table = new DataTable();

                //the query that will retreive all activities and place them in a listbox
                adapter = new MySqlDataAdapter("SELECT * FROM icamp.activities", connection_firm);
                adapter.Fill(table);
                available_activities.DataSource = table;
                available_activities.DisplayMember = "activity_name";
                available_activities.ValueMember = "activity_name";

            }
            catch (Exception ex)
            {
                //if any error occurs then it will be thrown as a message
                MessageBox.Show(ex.Message);
            }
        }

        //This method is used when we click the assign activities button
        private void assign_button_Click(object sender, EventArgs e)
        {
            //creating the connection
            MySqlConnection connection_firm = new MySqlConnection(connection);

            //query to verify that the student typed in actually exists
            MySqlCommand query = new MySqlCommand("select * from icamp.students where students_name=@students_name and email =@email", connection_firm);
            query.Parameters.AddWithValue("@students_name", students_name_assign.Text);
            query.Parameters.AddWithValue("@email", parents_email_assign.Text);
            MySqlDataAdapter sda = new MySqlDataAdapter(query);

            //we save the data to a datatable
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connection_firm.Open();
            int i = query.ExecuteNonQuery();
            connection_firm.Close();

            //if the student exists then it goes to the next step of saving the assigning of activity
            if (dt.Rows.Count > 0)
            {
                //we use a try catch block to catch any errors
                try { 
                
                    //this is the query im using to save the data to mysql
                    string Query = "insert into icamp.assigned_activities(activity_name,student_name,parent_email) values('" + this.available_activities.GetItemText(available_activities.SelectedItem) + "','" + this.students_name_assign.Text + "','" + this.parents_email_assign.Text + "');";

                    //we create the connection from the string and use it
                    MySqlConnection connection_firm2 = new MySqlConnection(connection);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, connection_firm2);
                    MySqlDataReader MyReader2;
                    connection_firm2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    //if the insertion to the database is sueccessful then a message shall be displayed
                    MessageBox.Show("You have assigned " + students_name_assign.Text + " to an activity");
                    while (MyReader2.Read())
                    {
                    }
                
                    connection_firm2.Close();
                }
                catch (Exception ex)
                {
                    //if an error occurs the it will show the exception in the form of a message box
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //if the user typed in a student name that does not exist a message is displayed
                MessageBox.Show("Your student name or parent email is incorrect please check and try again!");
            }

            //finally the textboxes are assigned to their original values
            students_name_assign.Text = "Students Name";
            parents_email_assign.Text = "Parents Email";
        }

        //this metehod is used when the remove button is clicked 
        private void remove_button_Click(object sender, EventArgs e)
        {
            //a try catch block is used to catch errors when trying to remove the record
            try
            {

                //the query used to delete the student from the database
                string Query = "delete from icamp.students where students_name='" + this.student_name_remove.Text + "';";

                //we create the connection and use it
                MySqlConnection connection_firm = new MySqlConnection(connection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connection_firm);
                MySqlDataReader MyReader2;
                connection_firm.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                
                //if the record has been deleted successfully this message will display
                MessageBox.Show("Student has been removed!");

                while (MyReader2.Read())
                {
                }
                connection_firm.Close();
            }
            catch (Exception ex)
            {
                //if an error is encountered the program will throw the exception in a messagebox
                MessageBox.Show("The student name either does not exist on the server or you have no connection to the server!");
            }

            //once all tasks have been done we replace the text in the textbox to its original values
            student_name_remove.Text = "Students Name";

        }
    }
}
