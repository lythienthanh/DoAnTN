using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace nha_tro
{
    public partial class FromMain : DevExpress.XtraEditors.XtraForm
    {
        public FromMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemNguoiDung ThemNguoiDung = new ThemNguoiDung();
            ThemNguoiDung.MdiParent = this;
            ThemNguoiDung.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemNguoiDungVaoNhom ThemNguoiDungVaoNhom = new ThemNguoiDungVaoNhom();
            ThemNguoiDungVaoNhom.MdiParent = this;
            ThemNguoiDungVaoNhom.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhanQuyen PhanQuyen = new PhanQuyen();
            PhanQuyen.MdiParent = this;
            PhanQuyen.Show();
        }
        CauHinh CauHinh = new CauHinh();

        //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public FromMain(string Message) : this()
        {
            tendn = Message;
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            
            
            WindowState = FormWindowState.Maximized;

            //====nhan ten dang nhap tu form dang nhap

            //====================================
            List<string> nhomND = CauHinh.GetMaNhomNguoiDung(tendn); // lay gia tri ma nhom nguoi dung          
            //dung` ma nhom nguoi dun(nhomND) lay ra ma~ man` hinh,CoQuyen
            for (int i = 0; i < nhomND.Count; i++)
            {
                List<string> MaMH = CauHinh.GetMaManHinh(nhomND[i]);
                List<string> CoQuyen = CauHinh.GetCoQuyen(nhomND[i]);
                //dung ma man hinh va` co quyen de bat visible cho cac control

                for (int j = 0; j < MaMH.Count; j++)
                {
                    if (CoQuyen[j] == true.ToString())
                    {
                        string maMH = MaMH[j].ToString();
                        getAlwayBarButton(maMH);
                    }
                }
            }
            //set hinh
            
        }
        public void getAlwayBarButton(string nameBarbtn)
        {
            foreach (RibbonPage rPage in ribbonPage1.Collection)
            {
                foreach (RibbonPageGroup rpg in rPage.Groups)
                {
                    foreach (var btn in rpg.Ribbon.Items)
                    {
                        if (btn is BarButtonItem)
                        {
                            BarButtonItem btnBar = btn as BarButtonItem;
                            if (string.Compare(btnBar.Name,nameBarbtn) == 0)//btnBar.Name.ToString() == nameBarbtn
                            {
                                btnBar.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //TrangThaiPhong TrangThaiPhong = new TrangThaiPhong();
            //TrangThaiPhong.MdiParent = this;
            //TrangThaiPhong.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form1 quanlyhang = new Form1();
            quanlyhang.MdiParent = this;
            quanlyhang.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

            MH000000000000000004 nhaphang = new MH000000000000000004(tendn);
            nhaphang.MdiParent = this;
            nhaphang.Show();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            NhaCungCap nhaCC = new NhaCungCap();
            nhaCC.MdiParent = this;
            nhaCC.Show();
        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            QuanLyKhachHang QuanLyKhachHang = new QuanLyKhachHang();
            QuanLyKhachHang.MdiParent = this;
            QuanLyKhachHang.Show();
        }

        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            BanHang BanHang = new BanHang(tendn);
            BanHang.MdiParent = this;
            BanHang.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemSPKhuyenMai ThemSPKhuyenMai = new ThemSPKhuyenMai();
            ThemSPKhuyenMai.MdiParent = this;
            ThemSPKhuyenMai.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemLKkhuyenMai ThemLKkhuyenMai = new ThemLKkhuyenMai();
            ThemLKkhuyenMai.MdiParent = this;
            ThemLKkhuyenMai.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyLinhKien QuanLyLinhKien = new QuanLyLinhKien();
            QuanLyLinhKien.MdiParent = this;
            QuanLyLinhKien.Show();

        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            TaoPhieuNhapLinhKien TaoPhieuNhapLinhKien = new TaoPhieuNhapLinhKien(tendn);
            TaoPhieuNhapLinhKien.MdiParent = this;
            TaoPhieuNhapLinhKien.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            //BanHangTraGop BanHangTraGop = new BanHangTraGop(tendn);
            //BanHangTraGop.MdiParent = this;
            //BanHangTraGop.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongKeSanPham ThongKeSanPham = new ThongKeSanPham();
            ThongKeSanPham.MdiParent = this;
            ThongKeSanPham.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            TinhDoanhThu TinhDoanhThu = new TinhDoanhThu();
            TinhDoanhThu.MdiParent = this;
            TinhDoanhThu.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            thongKeSPTheoKM thongKeSPTheoKM = new thongKeSPTheoKM();
            thongKeSPTheoKM.MdiParent = this;
            thongKeSPTheoKM.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraGop TraGop = new TraGop();
            TraGop.MdiParent = this;
            TraGop.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            BaoHanh BaoHanh = new BaoHanh(tendn);
            BaoHanh.MdiParent = this;
            BaoHanh.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            LOISX LOISX = new LOISX();
            LOISX.ShowDialog();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoiND LoiND = new LoiND();
            LoiND.ShowDialog();
        }

        private void MH000000000000000015_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimKiem frm = new TimKiem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MH000000000000000016_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimKiemTheoSanPham frm = new TimKiemTheoSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MH000000000000000017_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimkiemSPKM frm = new TimkiemSPKM();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            ThanhToanTraGop ThanhToanTraGop = new ThanhToanTraGop();
            ThanhToanTraGop.MdiParent = this;
            ThanhToanTraGop.Show();
        }

        private void MH000000000000000004_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.MdiParent = this;
            Form2.Show();
        }

        private void barButtonItem3_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = "hdsudung.pdf";
            Pdf.Start();
        }

        private void barButtonItem7_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            MH000000000000000024 TaoPhieuNhap = new MH000000000000000024(tendn);
            TaoPhieuNhap.MdiParent = this;
            TaoPhieuNhap.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            LuuNhapHang LuuNhapHang = new LuuNhapHang(tendn);
            LuuNhapHang.MdiParent = this;
            LuuNhapHang.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            LưuLinhKienVaoKho llkvk = new LưuLinhKienVaoKho(tendn);
            llkvk.MdiParent = this;
            llkvk.Show();
        }

        private void barButtonItem12_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            ThongKeLoaiSP ThongKeLoaiSP = new ThongKeLoaiSP();
            ThongKeLoaiSP.MdiParent = this;
            ThongKeLoaiSP.Show();
        }

        private void barButtonItem14_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            ThongKeTop5 ThongKeTop5 = new ThongKeTop5();
            ThongKeTop5.MdiParent = this;
            ThongKeTop5.Show();

        }

        private void barButtonItem15_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            thongKeTop10 thongKeTop10 = new thongKeTop10();
            thongKeTop10.MdiParent = this;
            thongKeTop10.Show();
        }

        private void barButtonItem17_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            BaoHanhh baoHanhh = new BaoHanhh(tendn);
            baoHanhh.MdiParent = this;
            baoHanhh.Show();
        }

        private void MH000000000000000029_ItemClick(object sender, ItemClickEventArgs e)
        {
            banlinhkien banlinhkien = new banlinhkien(tendn);
            banlinhkien.MdiParent = this;
            banlinhkien.Show();
        }
    }
}