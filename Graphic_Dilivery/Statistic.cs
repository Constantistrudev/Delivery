using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery;
using System.IO;
using  System.Text.Json.Serialization;
using System.Text.Json;

namespace Graphic_Dilivery
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu nfrm = new Menu();
            nfrm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Show(DayInfo());
        }

        private void Statistic_Load(object sender, EventArgs e)
        {

        }

        //private void label13_Click(object sender, EventArgs e)
        //{
        //    //DayInfo.restourants
        //    string best = "";
        //    label13.Text = best;
        //}
    }
}
