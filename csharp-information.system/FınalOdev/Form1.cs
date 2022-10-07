using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FınalOdev
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Program.connstring);

        public Form1()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("usp_Login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userNameTB.Text);
            cmd.Parameters.AddWithValue("@password", passwordTB.Text);
            
            conn.Open();
            int loginResult =Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            // KULLANICI ADLARININ BAŞ HARFLERİ BÜYÜK GİRİLMELİDİR.

            if(loginResult==1)
            {
                Form2 finalBilgi = new Form2();
                finalBilgi.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
