using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_OPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.vidah". При необходимости она может быть перемещена или удалена.
            this.vidahTableAdapter.Fill(this.labaDataSet.vidah);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.Sotrydn". При необходимости она может быть перемещена или удалена.
            this.sotrydnTableAdapter.Fill(this.labaDataSet.Sotrydn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.Knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.labaDataSet.Knigi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.izdatel". При необходимости она может быть перемещена или удалена.
            this.izdatelTableAdapter.Fill(this.labaDataSet.izdatel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.Chetateli". При необходимости она может быть перемещена или удалена.
            this.chetateliTableAdapter.Fill(this.labaDataSet.Chetateli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.Avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter.Fill(this.labaDataSet.Avtor);

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
