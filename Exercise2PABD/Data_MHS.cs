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
    public partial class Data_MHS : Form
    {
        public Data_MHS()
        {
            InitializeComponent();
        }

        private void Data_MHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string data = row.Cells[0].Value.ToString(); // Mengambil nilai dari kolom pertama (misalnya)

                Detail_MHS detail = new Detail_MHS(data);
                detail.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
