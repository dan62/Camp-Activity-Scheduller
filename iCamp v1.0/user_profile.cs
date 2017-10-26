//references used in form
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
    public partial class user_profile : Form
    {
        //global variable to be used in multiple place in the form
        String username;

        //constructor retreiving username from previous form to display
        public user_profile(string text)
        {
            InitializeComponent();
             username = text;
        }

        //This method is displayed on form load 
        private void user_profile_Load(object sender, EventArgs e)
        {
            //setting up the display and sorting the username
            back_icon.Hide();
            string[] words = username.Split('@');
            username = words[0];
            welcome_heading.Text = "Welcome, "+username;

            //loading the activities form in the profile pannel 
            display_option.Controls.Clear();
            activities_add activities = new activities_add();
            activities.TopLevel = false;
            activities.AutoScroll = true;
            display_option.Controls.Add(activities);
            activities.Show();
        }

        //Method used when the veiw activities button is initiated
        private void view_activities_Click(object sender, EventArgs e)
        {
            //loading the veiw  activities form in the profile pannel
            back_icon.Show();
            display_option.Controls.Clear();
            view_all_activities activities = new view_all_activities();
            activities.TopLevel = false;
            activities.AutoScroll = true;
            display_option.Controls.Add(activities);
            activities.Show();
        }

        //method that is used when the back button is clicked
        private void back_icon_Click(object sender, EventArgs e)
        {
            //loads the previous form in the profile pannel
            back_icon.Hide();
            display_option.Controls.Clear();
            activities_add activities = new activities_add();
            activities.TopLevel = false;
            activities.AutoScroll = true;
            display_option.Controls.Add(activities);
            activities.Show();
        }

        //method used when add activities button is clicked
        private void add_activities_Click(object sender, EventArgs e)
        {
            //The username is updated and the activities form is loaded in profile pannel
            back_icon.Hide();
            string[] words = username.Split('@');
            username = words[0];
            welcome_heading.Text = "Welcome, " + username;


            display_option.Controls.Clear();
            activities_add activities = new activities_add();
            activities.TopLevel = false;
            activities.AutoScroll = true;
            display_option.Controls.Add(activities);
            activities.Show();
        }

        //method used when add students button is clicked on 
        private void add_students_button_Click(object sender, EventArgs e)
        {
            //loading of students form in the profile pannel
            display_option.Controls.Clear();
            add_students students = new add_students();
            students.TopLevel = false;
            students.AutoScroll = true;
            display_option.Controls.Add(students);
            students.Show();
        }

        //method used when update button is clicked
        private void update_button_Click(object sender, EventArgs e)
        {
            //loading of update form in the profile pannel
            display_option.Controls.Clear();
            Update_activity update_now = new Update_activity();
            update_now.TopLevel = false;
            update_now.AutoScroll = true;
            display_option.Controls.Add(update_now);
            update_now.Show();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
