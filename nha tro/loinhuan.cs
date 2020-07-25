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
    public partial class loinhuan : Form
    {
        public loinhuan()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.thongke_loinhuanTableAdapter.Fill(this.tt.thongke_loinhuan, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value.ToString(), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value.ToString(), typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            int sl = 0;
            int tongtiennhap = 0;
            int tongtienban = 0;
            for (int i = 0; i < thongKe_TinhDoanhThuDataGridView.RowCount - 1; i++)
            {
                if (string.Compare(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString().Trim(), "khong") != 0)//tinh tien sp
                {
                    sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString());
                    tongtiennhap += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()) * int.Parse(thongke_loinhuanTableAdapter.dongianhap(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString(), DateTime.Today.ToString("MM/dd/yyyy")).ToString());
                    tongtienban += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()) * int.Parse(thongke_loinhuanTableAdapter.dongia_ban(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString()).ToString());
                }
                else//tinh tien lk
                {
                    sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString());
                    tongtiennhap += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()) * int.Parse(thongke_loinhuanTableAdapter.FillBy_DONGIANHAP_LK(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[5].Value.ToString(), DateTime.Today.ToString("MM/dd/yyyy")).ToString());
                    tongtienban += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()) * int.Parse(thongke_loinhuanTableAdapter.FillBy_DONGIA_ban_lk(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[5].Value.ToString()).ToString());
                }
            }
            
            
            
            textBox4.Text = sl.ToString();
            textBox2.Text = tongtiennhap.ToString();
            textBox1.Text = tongtienban.ToString();
            textBox3.Text = (tongtienban - tongtiennhap).ToString();

            sl = 0;
            tongtiennhap = 0;
            tongtienban = 0;


            try
            {
                this.hOADON_chenhlechTableAdapter.Fill(this.tt.HOADON_chenhlech, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value.ToString(), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value.ToString(), typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int tienbaohanh = 0;

            for(int i = 0; i < hOADON_chenhlechDataGridView.RowCount - 1; i++)
            {
                if(int.Parse(hOADON_chenhlechDataGridView.Rows[i].Cells[0].Value.ToString()) >= 0)
                {
                    tienbaohanh += int.Parse(hOADON_chenhlechDataGridView.Rows[i].Cells[0].Value.ToString());
                }
                else
                {
                    string temp = hOADON_chenhlechDataGridView.Rows[i].Cells[0].Value.ToString();
                    string temp1 = temp.Substring(1, temp.Length - 1);
                    tienbaohanh += int.Parse(temp1);
                }
            }
            int gianhaplk = 0;

            try
            {
                this.malk_bhTableAdapter.Fill(this.tt.malk_bh, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value.ToString(), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value.ToString(), typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            int giaban = 0;
            for (int i= 0; i< malk_bhDataGridView.RowCount - 1; i++)
            {
                if (string.Compare(malk_bhDataGridView.Rows[i].Cells[0].Value.ToString().Trim(), "TEMP") != 0 && malk_bhDataGridView.Rows[i].Cells[0].Value.ToString().Length != 0)
                {
                    gianhaplk += int.Parse(hOADON_chenhlechTableAdapter.GIANHAP_LK(malk_bhDataGridView.Rows[i].Cells[0].Value.ToString(), DateTime.Today.ToString("MM/dd/yyyy")).ToString());
                    giaban += int.Parse(hOADON_chenhlechTableAdapter.giaban_lk(malk_bhDataGridView.Rows[i].Cells[0].Value.ToString()).ToString());
                }
            }

            textBox5.ReadOnly = true;
            textBox5.Text = (tienbaohanh ).ToString();

            textBox6.ReadOnly = true;
            textBox6.Text = hOADON_chenhlechTableAdapter.tien_suachua(Convert.ToDateTime(dateTimePicker1.Value.ToString()), Convert.ToDateTime(dateTimePicker2.Value.ToString())).ToString();
            textBox6.Text = (giaban - gianhaplk).ToString();

        }

        private void loinhuan_Load(object sender, EventArgs e)
        {
            thongKe_TinhDoanhThuDataGridView.BorderStyle = BorderStyle.None;
            thongKe_TinhDoanhThuDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            thongKe_TinhDoanhThuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            thongKe_TinhDoanhThuDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            thongKe_TinhDoanhThuDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            thongKe_TinhDoanhThuDataGridView.BackgroundColor = Color.White;

            thongKe_TinhDoanhThuDataGridView.EnableHeadersVisualStyles = false;
            thongKe_TinhDoanhThuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            thongKe_TinhDoanhThuDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            thongKe_TinhDoanhThuDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xuat_tk_loinhuan xuat_Tk_Loinhuan = new xuat_tk_loinhuan(DateTime.Today.Date.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString(), textBox4.Text, textBox2.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"), textBox1.Text, textBox3.Text);
            xuat_Tk_Loinhuan.ShowDialog();
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {

            }

        }
    }


