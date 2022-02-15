using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DBConnection
{
    public partial class Form1 : Form
    {
       

        string connectionString = @"Data Source=DESKTOP-IITVJLG\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection connection = new SqlConnection();


        public Form1()
        {
            InitializeComponent();

            this.connection.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }

     


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {     
           
        
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных " +
                   connection.Database + " выполнено успешно " + "\nСервер: " +
                   connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    MessageBox.Show("Соединение с базой данных закрыто");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже закрыто");
            }

            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                    MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }

            }
        }
        

        
        private async void ToolStripMenuItemAsyn_Click(object sender,EventArgs e)
        {
           

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show("Соединение с базой данных " +
                   connection.Database + " выполнено успешно " + "\nСервер: " +
                   connection.DataSource);
                }
                
            else
 MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void connection_StateChange(object sender,
StateChangeEventArgs e)
        {
            ToolStripMenuItem.Enabled =
            (e.CurrentState == ConnectionState.Closed);
           ToolStripMenuItemAsyn.Enabled =
            (e.CurrentState == ConnectionState.Closed);
          ToolStripMenuItem2.Enabled =
            (e.CurrentState == ConnectionState.Open);
        }
    

        private void списокПодключенийToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format("Name = {0}\nProviderName = {1}\nConnectionString = {2}", cs.Name, cs.ProviderName, cs.ConnectionString);
                    MessageBox.Show(str, "Параметры подключений");
                }
            }
            
           /* static string GetConnectionStringByName(string name)
            {
                string returnValue = null;
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
                if (settings != null)
                    returnValue = settings.ConnectionString;
                return returnValue;
            }
            string connectionString = GetConnectionStringByName("DBConnection.Properties.Settings.NorthwindConnectionStrin");
            */
    
                  }

        private void button1_Click(object sender, EventArgs e)
        {


            using (connection)
            {
                if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Products";
            try
            {
                int number = (int)command.ExecuteScalar();
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               }

            
        }
        public static int ExecuteScalarMetod(string cs, string qv)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = qv;
                int number = (int)command.ExecuteScalar();                
            return number;
            }


            
        }

        private void button2_Click(object sender, EventArgs e)       {
            try
            {
                int number = WorkWithDataBase.ExecuteScalarMethod(connectionString, "USE [Northwind] SELECT COUNT(*) FROM [dbo].[Products]");
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



}
