//references used in the form
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
    public partial class view_all_activities : Form
    {

        string connection = "datasource=localhost;port=3306;username=root;password= ";

        public view_all_activities()
        {
            InitializeComponent();
        }

        //this is the main method and it is loaded on displaying the form
        private void view_all_activities_Load(object sender, EventArgs e)
        {
            //we use a try catch block to catch any errors that may occur with database
            try
            {
                
                //The following is the query used to retreive data 
                string Query = "select * from icamp.activities;";
                MySqlConnection  connection_firm = new MySqlConnection(connection);
                MySqlCommand execute_query = new MySqlCommand(Query, connection_firm);
               
                //we use the mysql adapter to allow us to fill the datatable with contents from the database
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = execute_query;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;   

            }
            catch (Exception ex)
            {
                //if an error is encountered it shall be thrown in a message box
                MessageBox.Show(ex.Message);
            }
        }
         
        //This is the method to be used when the search button is clicked
        private void Search_button_Click(object sender, EventArgs e)
        {

        }
    }
}
