using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.SqlServer.Management.Smo;
namespace nha_tro
{
    public partial class CauHinhSQL : Form
    {
        CauHinh CauHinh = new CauHinh();
        public CauHinhSQL()
        {
            InitializeComponent();
        }
       
        private void cboServer_DropDown(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = CauHinh.GetServerName();
            //cboServer.Items.Clear();
            //foreach (System.Data.DataRow row in dt.Rows)
            //{
            //    foreach (System.Data.DataColumn col in dt.Columns)
            //    {
            //        cboServer.Items.Add(row[col]);
            //    }
            //}
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
            {
                cboServer.Items.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            }
            string tenpc = System.Environment.MachineName;
            cboServer.Items.Add(tenpc + @"\SQLEXPRESS");
        }
        public bool CheckedBeforSearchNameDB()
        {
            if (cboServer.SelectedItem.ToString() != null && txtUsername.Text != null && txtPassword.Text != null)
            {
                return true;
            }
            return false;
        }
        private void cboDataBase_DropDown(object sender, EventArgs e)
        {
             //cboServer.Text,txtUsername.Text, txtPassword.Text khac null
            if (CheckedBeforSearchNameDB())
            {
                cboDataBase.Items.Clear();
                List<string> _list = CauHinh.GetDatabaseName(cboServer.Text,txtUsername.Text, txtPassword.Text);
                if (_list == null)
                {
                    MessageBox.Show("Thông tin cấu hình chưa chính xác");
                    return;
                }
                foreach (string item in _list)
                {
                    cboDataBase.Items.Add(item);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CauHinh.ChangeConnectionString(cboServer.Text, cboDataBase.Text,txtUsername.Text, txtPassword.Text);
            MessageBox.Show("đã lưu");
            this.Close();
        }

        private void CauHinhSQL_Load(object sender, EventArgs e)
        {
            cboServer_DropDown(sender, e);          
        }

        private void cboDataBase_DropDown_1(object sender, EventArgs e)
        {
            cboDataBase_DropDown(sender, e);
        }

        private void CauHinhSQL_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        
    }
}
