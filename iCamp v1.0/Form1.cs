//references used in this form
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
    public partial class splash_screen : Form
    {
        //global variable to be used accross form
        Boolean check;
        public splash_screen()

        {
            InitializeComponent();

        }

        //when the timer is activated this method is run
        private void timer1_Tick(object sender, EventArgs e)
        {

            //simple if statement to increment the preloader
            if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;
                preloader.Value++;

            }

            else

            {

                timer1.Stop();
                start_button.Show();
            }


        }

        //get setter to update the time with preloader
        public int timeLeft { get; set; }

        //this method is run when the form is run
        private void Form1_Load(object sender, EventArgs e)
        {
            //we start the timer and when timer ends start button displays
            start_button.Hide();
            timeLeft = 100;
            timer1.Start();
        }

        //when start button is clicked on this method is run
        private void start_button_Click(object sender, EventArgs e)
        {
            //we display the login register form and hide current one
            new login_register().Show();
            this.Hide();
        }
    }
}

