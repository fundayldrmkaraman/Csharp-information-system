using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FınalOdev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("E-Posta", typeof(string));
            tablo.Columns.Add("Cep Telefon", typeof(int));
            tablo.Columns.Add("Geri Bildirim", typeof(string));
            dataGridView1.DataSource = tablo;
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }
    }
}
