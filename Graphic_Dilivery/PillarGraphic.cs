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
    public partial class PillarGraphic : Form
    {
        public PillarGraphic()
        {
            InitializeComponent();
            List<Deliverer> list = new List<Deliverer>(DayInfo.SortList(Fileworker.Deliverers));
            for (int i = 0; i < list.Count; i++)
            {
                chart1.Series[0].Points.AddXY(list[i].DelivererNumber, list[i].WorkTime);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
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
