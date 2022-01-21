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

namespace Graphic_Dilivery
{
    public partial class LineGraphic : Form
    {
        public LineGraphic()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear();
            var orders = DayInfo.LineGraphic(Fileworker.Deliverers);
            foreach (var d in orders)
            {
                chart1.Series[0].Points.AddXY(d.WorkDay, d.AllOrders);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
