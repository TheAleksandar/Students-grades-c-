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

namespace AplikacijaOcenki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

         

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            //kopiraj conection string tuka
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //proveri dali tabela so admini e [Tables] isto zavedena vo SQL
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [Tables] where UserName='" + textBox1.Text + "'and Password ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {

                MasterForm ss = new MasterForm();
                this.Hide();
                ss.Show();


            }
            else
            {
                MessageBox.Show("please Check UserName & passworrd");

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
