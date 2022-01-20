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
            textBox1.Text = Convert.ToString(DayInfo.CountOfOrders(Fileworker.Deliverers));
            textBox2.Text = Convert.ToString(DayInfo.CountOfAllSucsessDeliveres(Fileworker.Deliverers));
            textBox3.Text = Convert.ToString(DayInfo.CountOfAllCancledDeliveres(Fileworker.Deliverers));
            textBox4.Text = Convert.ToString(DayInfo.GetAllPrice(Fileworker.Deliverers));
            textBox5.Text = Convert.ToString(DayInfo.GetProfit(Fileworker.Deliverers));
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
        private void Statistic_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
    }
}
