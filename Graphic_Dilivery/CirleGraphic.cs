﻿using System;
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
    public partial class CirleGraphic : Form
    {
        public CirleGraphic()
        {
            InitializeComponent();
                chart1.Series[0].Points.AddY(Convert.ToString(DayInfo.CountOfAllCancledDeliveres(Fileworker.Deliverers)));
                chart1.Series[0].Points.AddY(Convert.ToString(DayInfo.CountOfAllSucsessDeliveres(Fileworker.Deliverers)));
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu nfrm = new Menu();
            nfrm.Show();
            this.Close();
        }
    }
}
