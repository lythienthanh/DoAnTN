using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nha_tro
{
    public partial class ThanhToanTraGop : Form
    {
        public ThanhToanTraGop()
        {
            InitializeComponent();
        }

        private void traGopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traGopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tt);

        }

        private void ThanhToanTraGop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.LOAISANPHAM' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'tt.TraGop' table. You can move, or remove it, as needed.
            /*this.traGopTableAdapter.Fill(this.tt.TraGop);*/

        }
        ThongKe ThongKe = new ThongKe();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 || textBox3.Text.Length != 0)
            {
                int t = int.Parse(textBox1.Text);
                string t2 = traGopTableAdapter.KTSoTienMax(textBox3.Text).ToString();
                int t1 = int.Parse(t2);

                if (t <= t1)
                {
                    string ngay = DateTime.Today.ToString();
                    int sotienconlai = int.Parse(dataTable1DataGridView.Rows[0].Cells[4].Value.ToString()) - int.Parse(textBox1.Text);
                    //lay thong tin
                    string matragop = dataTable1DataGridView.CurrentRow.Cells[2].Value.ToString();
                    int sotienphaitra = int.Parse(dataTable1DataGridView.CurrentRow.Cells[3].Value.ToString());
                    string sotienconlaitt = dataTable1DataGridView.Rows[0].Cells[4].Value.ToString();
                    string ngaytra = dataTable1DataGridView.CurrentRow.Cells[5].Value.ToString();
                    string deadline = dataTable1DataGridView.CurrentRow.Cells[6].Value.ToString();
                    traGopTableAdapter.Insert(textBox3.Text, int.Parse(textBox1.Text), int.Parse(sotienconlaitt) - int.Parse(textBox1.Text), Convert.ToDateTime(DateTime.Today), Convert.ToDateTime(deadline));
                    //traGopTableAdapter.Insert(traGopComboBox.SelectedValue.ToString(),)
                    MessageBox.Show("Thành Công !!!");

                    try
                    {
                        this.traGop1TableAdapter.Fill_dk(this.tt.TraGop1, matragop);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    /*ThongKe.xuatfile_HD_TraGop(traGop1DataGridView, traGopComboBox.SelectedValue.ToString(), textBox1.Text, ngay, "HD_TraGop_TT");*/
                    hd_tragop hD_Tragop = new hd_tragop(dataTable1DataGridView.CurrentRow.Cells[0].Value.ToString(), textBox3.Text, DateTime.Today.ToString("dd/MM/yyyy"));
                    hD_Tragop.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Vượt quá số tiền thanh toán");


                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");


            }
        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void traGopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.FillBy_matragop(this.tt.DataTable1, textBox3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                dataTable1TableAdapter.Fill_sdt(tt.DataTable1, textBox2.Text);

                if (dataTable1DataGridView.Rows.Count <= 2)
                    MessageBox.Show("không có dữ liệu !!!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");

            }
        }

        private void traGop1DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataTable1DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataTable1DataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
