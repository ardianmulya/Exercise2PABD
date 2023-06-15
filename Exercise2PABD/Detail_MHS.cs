using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2PABD
{
    public partial class Detail_MHS : Form
    {
        public Detail_MHS(string data1)
        {
            InitializeComponent();
            textBox1.Text = data1;
        }

        private void Detail_MHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_MHS data = new Data_MHS();
            data.Show();
            this.Hide();
        }
    }
}
