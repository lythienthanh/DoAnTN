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

namespace nha_tro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string dd = d.Day + "-" + d.Month;

            string severname = textBox1.Text;
            string databasename = textBox2.Text;

            string conec = nha_tro.Properties.Settings.Default.DTDDConnectionString;

            SqlConnection con = new SqlConnection(conec);

            con.Open();

            string str = "USE " + databasename + ";";
            string str1 = "BACKUP DATABASE " + databasename +
                " TO DISK = 'D:\\database1\\" + databasename + "_" + dd +
                ".Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of " + databasename + "';";
            SqlCommand cmd1 = new SqlCommand(str, con);
            SqlCommand cmd2 = new SqlCommand(str1, con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Backup thành công file in D:\\database1");
            con.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            OpenFileDialog.InitialDirectory = @"C:\";
            OpenFileDialog.Title = "Browse Text Files";

            OpenFileDialog.CheckFileExists = true;
            OpenFileDialog.CheckPathExists = true;

            OpenFileDialog.DefaultExt = "BAK";
            OpenFileDialog.Filter = "Text files (*.bak)|*.bak";
            OpenFileDialog.FilterIndex = 2;
            OpenFileDialog.RestoreDirectory = true;

            OpenFileDialog.ReadOnlyChecked = true;
            OpenFileDialog.ShowReadOnly = true;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = OpenFileDialog.FileName;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string severname = textBox3.Text;
            string databasename = textBox4.Text;

            string conec = nha_tro.Properties.Settings.Default.DTDDConnectionString;
            SqlConnection con = new SqlConnection(conec);
            con.Open();
            string str = "USE master;";
            string str1 = "ALTER DATABASE " + databasename + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
            string str3 = "RESTORE DATABASE " + databasename + " FROM DISK = '" + textBox5.Text + "' WITH REPLACE";
 
            SqlCommand cmd1 = new SqlCommand(str, con);
            SqlCommand cmd2 = new SqlCommand(str1, con);
            SqlCommand cmd3 = new SqlCommand(str3, con);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            MessageBox.Show("Phục hồi thanh công!!!");
            con.Close();
            Application.Exit();
            this.Hide();
            
        }
    }
}
