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
    public partial class TraGop : Form
    {
        public TraGop()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime ngayDB = Convert.ToDateTime(dateTimePicker1.Value.ToString("dd/MM/yyyy"));


            try
            {
                this.thongKe_tragop_theongayTableAdapter.Fill(this.tt.thongKe_tragop_theongay, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int sltheosp = 0;
            int sl = 0;
            int tongtien = 0;
            for (int i = 0; i < thongKe_tragop_theongayDataGridView.Rows.Count -1 ; i++)
            {
                sl += int.Parse(thongKe_tragop_theongayDataGridView.Rows[i].Cells[3].Value.ToString());
                sltheosp = int.Parse(thongKe_tragop_theongayDataGridView.Rows[i].Cells[3].Value.ToString());
                int dongia = int.Parse(thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_tragop_theongayDataGridView.Rows[i].Cells[1].Value.ToString()).ToString());
                tongtien += sltheosp * dongia;
            }
            textBox1.Text = sl.ToString();
            textBox2.Text = tongtien.ToString();

            try
            {
                this.traGop2_select_theo_ngayTableAdapter.Fill(this.tt.TraGop2_select_theo_ngay, Convert.ToDateTime(dateTimePicker2.Value.ToString()), Convert.ToDateTime(dateTimePicker1.Value.ToString()));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int tongtienphaitra = 0;
            int tongtienconlai = 0;
            for (int i = 0; i < traGop2_select_theo_ngayDataGridView.RowCount - 1; i++)
            {
                tongtienphaitra += int.Parse(traGop2_select_theo_ngayDataGridView.Rows[i].Cells[1].Value.ToString());
                tongtienconlai += int.Parse(traGop2_select_theo_ngayDataGridView.Rows[i].Cells[2].Value.ToString());
            }
            textBox3.Text = (tongtienphaitra + (tongtienphaitra - tongtienconlai)).ToString();
            textBox4.Text = tongtienconlai.ToString();
            tongtienphaitra = 0;
            tongtienconlai = 0;

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void TraGop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.TraGop' table. You can move, or remove it, as needed.
            this.traGopTableAdapter.Fill(this.tt.TraGop);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //do du lieu vao sheet
            string fromMont = dateTimePicker1.Value.ToString().Substring(0, 2);
            string fromDay = dateTimePicker1.Value.ToString().Substring(3, 2);
            string fromyear = dateTimePicker1.Value.ToString().Substring(6, 4);

            string toMont = dateTimePicker2.Value.ToString().Substring(0, 2);
            string tongay = dateTimePicker2.Value.ToString().Substring(3, 2);
            string toYear = dateTimePicker2.Value.ToString().Substring(6, 4);

            //sreach datagid
            string NamNgayThangStar = fromyear + "/" + fromMont + "/" + fromDay;
            string NamNgayThangEnd = toYear + "/" + toMont + "/" + tongay;

            //==========================================
            ThongKe ThongKe = new ThongKe();
            ThongKe.xuatfile_tragop(traGop2_select_theo_ngayDataGridView, textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, NamNgayThangStar, NamNgayThangEnd, "ThongKe_TraGop");


            //gui du lieu tu datagird vao file excel
            
                
            
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            //try
            //{
            //    this.traGop2_select_theo_ngayTableAdapter.Fill(this.tt.TraGop2_select_theo_ngay, nGAYKTToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {


        }
    }
}
