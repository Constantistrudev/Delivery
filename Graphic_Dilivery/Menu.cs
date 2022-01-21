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

namespace Graphic_Dilivery
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            List<Deliverer> temp = DayInfo.SortList(Fileworker.Deliverers);
            dataGridView1.DataSource = Fileworker.Deliverers;
            DataTable table = new DataTable();
            table.Columns.Add("Номер сумки", typeof(string));
            table.Columns.Add("Рабочее время", typeof(int));
            table.Columns.Add("Рейтинг", typeof(double));
            for (int index = 0; index < temp.Count; index++)
            {
                table.Rows.Add(temp[index].DelivererNumber, temp[index].WorkTime, temp[index].Rating);
            }
            dataGridView1.DataSource = table;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Statistic nfrm = new Statistic();
            nfrm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog createFile = new SaveFileDialog();
            createFile.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            createFile.ShowDialog();
            Fileworker.AddFile(createFile.FileName);
            MessageBox.Show("Вы создали файл и работаете с этим файлом ");

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFile.ShowDialog();
            Fileworker.OpenFile(openFile.FileName);
            MessageBox.Show("Вы выбрали: " + openFile.FileName);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            save.ShowDialog();
            save.OpenFile();
            MessageBox.Show("Файл сохранен");
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void смотретьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistic nfrm = new Statistic();
            nfrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void посмотретьСписокКурьеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListofDeliverers nfrm = new ListofDeliverers();
            nfrm.Show();
            this.Hide();
        }


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа сделана Трубчаниновым Константином ИСТ20о");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void списокКурьеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fileworker.WorkPath == null)
            {
                MessageBox.Show("Вы не работаете с файлом, создайте или откройте его");
            }
            else
            {
                ListofDeliverers nfrm = new ListofDeliverers();
                nfrm.Show();
                this.Hide();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void линейныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineGraphic nfrm = new LineGraphic();
            nfrm.Show();
            this.Hide();
        }

        private void круговойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CirleGraphic nfrm = new CirleGraphic();
            nfrm.Show();
            this.Hide();
        }

        private void столбиковыйToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PillarGraphic nfrm = new PillarGraphic();
            nfrm.Show();
            this.Hide();
        }
    }
}
