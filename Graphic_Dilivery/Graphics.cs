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
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
            //DayInfo.CoutOfAllSucsessDeliveresByDeliverer();
            chart1.Series["NumberOfCanceledOrders"].Points.AddY();
            chart1.Series["NumberOfSucsessOrders"].Points.AddY();

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
