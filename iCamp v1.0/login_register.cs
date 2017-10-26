//These are the references i shall be using on this form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace iCamp_v1._0
{
    public partial class login_register : Form
    {
        //global variable to be used in multiple methods
        string connection = "datasource=localhost;port=3306;username=root;password= ";

        public login_register()
        {
            InitializeComponent();
        }

        /*This method is triggered when the close icon is clicked on 
        all it does is close the software */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //This method is used to minimize the form when the minimize icon is clicked
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //When the user wants to change the language this method is used
        private void language_change_Click(object sender, EventArgs e)
        {
            //It first checks to see the current language
            if(language_change.Text == "Change to English?")
            {
                //once finding out it changes the lable accordingly
                language_change.Text = "Change to Thai?";
                
                //Changing all tesxt to english
                register_label.Text = "Register User";
                register_details.Text = "Please enter user details below to";
                register_details2.Text = "register a user, please note only";
                register_details3.Text = "administrators can register a user";
                first_name.Text = "First Name";
                surname.Text = "Last Name";
                email.Text = "Email Address";
                passport.Text = "Passport Number";
                Admin_code.Text = "Admin Code";
                password1.Text = "Password";
                retype_password.Text = "Retype Password";
                admin_user.Text = "Admin user";
                parent_user.Text = "Parent user";
                register_button.Text = "Register User";

                username.Text = "Email address";
                password.Text = "Password";
                login_user.Text = "Login";
                remember.Text = "Remember me";
                login.Text = "Login";
                details1.Text = "Please enter login details below";
                details2.Text = "to continue";
            }
            else
            {
                //if the current language was english it will convert to thai
                language_change.Text = "Change to English?";
                
                //Changing all text to Thai
                register_label.Text = "การลงทะเบียนผู้ใช้";
                register_details.Text = "โปรดใส่รายละเอียดผู้ใช้ด้านล่าง";
                register_details2.Text = "เพื่อลงทะเบียนผู้ใช้โปรดทราบเท่านั้น";
                register_details3.Text = "เฉพาะผู้ดูแลระบบเท่านั้นที่สามารถลงทะเบียนผู้ใช้";
                first_name.Text = "ชื่อจริง";
                surname.Text = "นามสกุล";
                email.Text = "ที่อยู่อีเมล";
                passport.Text = "หมายเลขหนังสือเดินทาง";
                Admin_code.Text = "รหัสผู้ดูแลระบบสำหรับการลงทะเบียนผู้ใช้";
                password1.Text = "รหัสผ่าน";
                retype_password.Text = "ป้อนรหัสผ่านใหม่";
                admin_user.Text = "ผู้ดูแลระบบ";
                parent_user.Text = "ผู้ปกครอง";
                register_button.Text = "ลงทะเบียนผู้ใช้";

                username.Text = "ที่อยู่อีเมล";
                password.Text = "รหัสผ่าน";
                login_user.Text = "เข้าสู่ระบบ";
                remember.Text = "จดจำรหัสผ่าน";
                login.Text = "ลงชื่อเข้าใช้ตอนนี้";
                details1.Text = "โปรดป้อนรายละเอียดการเข้าสู่ระบบด้านล่าง";
                details2.Text = "ดำเนินการต่อไป";
            }
           
        }

        //This is the method used to register a user to the system
        private void register_button_Click(object sender, EventArgs e)
        {
            //variable to save boolean user type admin or not admin
            int x = 0;

            //This checks to see if the password and password retype is equal
            if (password1.Text != retype_password.Text)
            {
                MessageBox.Show("Please ensure the password and retype password is the same!");
            }

            //Checking if admin code is present
            if (Admin_code.Text == ""){
                MessageBox.Show("Please ensure you type in a correct admin code to create a user");
            }

            //if the user being registered is admin boolean value to be stored is 1 if not 0
            if(admin_user.Checked == true)
            {
                x = 1;
            }
            else
            {
                x = 0;
            };

            //Try catch block to try saving data to database if fail a message will display
            try
            {  
                //SQL query used in saving the data 
                string Query = "insert into icamp.users(first_name,surname,email,passport_no,password,admin_user) values('"+ this.first_name.Text + "','" + this.surname.Text + "','" + this.email.Text + "','" + this.passport.Text + "','" + this.password1.Text + "','" +x + "');";

                //i created the connection and the sql command to get processed
                MySqlConnection connection_firm = new MySqlConnection(connection);
                MySqlCommand process_query = new MySqlCommand(Query, connection_firm);

                //Then we read the data using mysql data reader
                MySqlDataReader MyReader2;
                connection_firm.Open();
                MyReader2 = process_query.ExecuteReader();  
                
                //a message shall display on successful registration     
                MessageBox.Show("You have successfully registered a user!");
                while (MyReader2.Read())
                {
                }
                connection_firm.Close();
            }
            catch (Exception ex)
            {
                //if there is an error a message displaying the kind of exception will pop up
                MessageBox.Show(ex.Message);
            }

        }

        //This is the main method that is loaded when the form is started
        private void login_register_Load(object sender, EventArgs e)
        {
            //This basically maked the password characters hidden
            password.UseSystemPasswordChar = true;
        }

        //This is the method used for logging into the system
        private void login_Click(object sender, EventArgs e)
        {
            //we turn the connection string into a mysql connection
            MySqlConnection connection_firm = new MySqlConnection(connection);

            //The following is the query being used to verify login
            MySqlCommand query = new MySqlCommand("select * from icamp.users where email=@username and password =@password", connection_firm);
            query.Parameters.AddWithValue("@username", username.Text);
            query.Parameters.AddWithValue("@password", password.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(query);

            //We store the data retreived into a data table 
            DataTable data_retreived = new DataTable();
            adapter.Fill(data_retreived);
            connection_firm.Open();
            int i = query.ExecuteNonQuery();
            connection_firm.Close();

            //checking to see if data was retreived to allow access to system
            if (data_retreived.Rows.Count > 0)
            {
                //message granting user access
                MessageBox.Show("You have been granted Access!");
                
                //creating an object out of user profile and displaying it
                user_profile form = new user_profile(username.Text);
                form.Show();
                this.Hide();

                //if the remember me is ticked on the login
                if (remember.Checked == true)
                {
                    /*we try to save the username and password on the pc so next time it can just retreive the data
                     from pc, user wont have to type in data on next use - Required Administrator Privalage*/
                    try
                    {
                        using (System.IO.StreamWriter bw = new System.IO.StreamWriter(System.IO.File.Create("C:\\remember_me.txt")))
                        {
                            bw.Write(username.Text + "" + password.Text);
                            bw.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        //if the data cannot be saved then a message telling user to ensure Administrative privalage is granted
                        MessageBox.Show("Please ensure you have run this program with Administrative privalage in order to use the 'remember me' feature!");
                    }
                };
            }

            else
            {
                //If the login details where incorrect a message asking for correct login details will display
                MessageBox.Show("Please enter correct loggin details");
            }
        }
    }
}
