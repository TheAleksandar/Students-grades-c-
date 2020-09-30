using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaOcenki
{
    public partial class MasterForm : Form

    {
        StudentsEntities test;

        public MasterForm()
        {
            InitializeComponent();
           

        }

        //save btn
        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text))

            {
                label15.Text = ((Convert.ToInt32(textBox6.Text) + Convert.ToInt32(comboBox1.Text))).ToString();


                if ((Convert.ToInt32(label15.Text)) < 50)
                {
                    textBox9.Text = "5-Ne Polozil";
                }

                if (((Convert.ToInt32(label15.Text)) >=50) && ((Convert.ToInt32(label15.Text)) <=60))
                {
                    textBox9.Text = "6-Sest";
                }
                if (((Convert.ToInt32(label15.Text)) >=61) && ((Convert.ToInt32(label15.Text)) <=70))
                {
                    textBox9.Text = "7-Sedum";
                }
                if (((Convert.ToInt32(label15.Text)) >=71) && ((Convert.ToInt32(label15.Text)) <=80))
                {
                    textBox9.Text = "8-Osum";

                }
                if (((Convert.ToInt32(label15.Text)) >=81) && ((Convert.ToInt32(label15.Text)) <=89))
                {
                    textBox9.Text = "9-Devet";
                }
                if (((Convert.ToInt32(label15.Text)) > 90) && ((Convert.ToInt32(label15.Text)) >100))
                {
                    textBox9.Text = "10-Deset";
                }

                else
                {
                    textBox9.Text = "Data ERROR";
                }
            }

            try
            {
                studentiBindingSource.EndEdit();
                test.SaveChangesAsync();
                panel1.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentiBindingSource.ResetBindings(false);
            }

        }

        //new btn create item;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                textBox1.Focus();
                Studenti c = new Studenti();
                test.Studentis.Add(c);
                studentiBindingSource.Add(c);
                studentiBindingSource.MoveLast();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //edit btn
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Focus();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            

            panel1.Enabled = false;
            test = new StudentsEntities();
            studentiBindingSource.DataSource = test.Studentis.ToList();
        }

        //cancel
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            studentiBindingSource.ResetBindings(false);

            foreach(DbEntityEntry entry in test.ChangeTracker.Entries())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;

                }
            }

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox10.Text))
                {
                    dataGridView1.DataSource = studentiBindingSource;
                }
                else
                {
                    var queru = from o in studentiBindingSource.DataSource as List<Studenti>
                                where o.StudentIme.Contains(textBox10.Text) || o.StudentIndex.Contains(textBox10.Text) || o.StudentPrezime.Contains(textBox10.Text) || o.Ocena == textBox10.Text
                                select o;

                    dataGridView1.DataSource = queru.ToList();

                }
            }

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))

            {
                textBox6.Text = ((Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text)) / 2).ToString();
            }

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sa = new Form1();
            sa.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are sure to delete?,", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    test.Studentis.Remove(studentiBindingSource.Current as Studenti);
                    studentiBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
    
    
