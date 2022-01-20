using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using Delivery;

namespace Graphic_Dilivery
{
    public partial class ListofDeliverers : Form
    {
        public ListofDeliverers()
        {
            InitializeComponent();
            listBox1.DataSource = Fileworker.Deliverers;
            listBox1.DisplayMember = "DelivererNumber";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu nfrm = new Menu();
            nfrm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Fileworker.DeliteDeliverer(listBox1.SelectedIndex); 
                listBox1.DataSource = null;
                listBox1.DataSource = Fileworker.Deliverers;
                listBox1.DisplayMember = "DelivererNumber";
                MessageBox.Show("Курьер удалён");
            }
            else
                MessageBox.Show("выберите элемент");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0 || textBox6.Text.Length == 0 || numericUpDown1.Text.Length == 0)
            {
                MessageBox.Show("Введите значения");
            }
            else
            {
                Fileworker.AddDeliverer(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(numericUpDown1.Text), dateTimePicker1.Value);
                //Fileworker.AddDelivererAtTable(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(numericUpDown1.Text), dateTimePicker1.Value);
                listBox1.DataSource = null;
                listBox1.DataSource = Fileworker.Deliverers;
                listBox1.DisplayMember = "DelivererNumber";

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Fileworker.EditDeliverer(listBox1.SelectedIndex, textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text),int.Parse(textBox5.Text),int.Parse(textBox6.Text), int.Parse(numericUpDown1.Text), dateTimePicker1.Value);
            listBox1.DataSource = null;
            listBox1.DataSource = Fileworker.Deliverers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
