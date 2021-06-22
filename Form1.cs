using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int number = rdm.Next(0, 100);

            string midnumber = number.ToString();

            

            label8.Text = ("s1" + "-" + midnumber + "-" + DateTime.Now.Year);


            //Class Obj
            //Itmes it = new Itmes();
            //it.ID=
            //it.Rate = Convert.ToInt16(textBox2.Text);
            //it.Quantity = Convert.ToInt32(textBox3.Text);
            //it.ItemSelected = comboBox2.SelectedItem.ToString();

            string ttotal = Total.ToString();
            label11.Text = (ttotal);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comboValue = comboBox2.SelectedItem.ToString();
            int Rate = Convert.ToInt32(textBox3.Text);
            int Quantity= Convert.ToInt32(textBox2.Text);
            int Total = Rate * Quantity;
            dataGridView1.Rows.Add(comboValue, Quantity,Rate, "PCS", Total);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           // textBox4.Text =Convert.ToString( Total);
          
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }
    }
}
