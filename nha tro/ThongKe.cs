using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Diagnostics;
namespace nha_tro
{
    class ThongKe
    {
        public void xuatfile_tinhtong(DataGridView datagrid,string tongTien,string sl,string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile+".pdf", FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k,i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            Paragraph Paragraph = new Paragraph("SL: " + sl);
            doc.Add(Paragraph);
            Paragraph Paragraph1 = new Paragraph("Tong: " + tongTien + " VND");
            doc.Add(Paragraph1);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }


        public void xuatfile_tinhtong_khoantime(DataGridView datagrid, string tongTien,string sl, string ngaybd,string ngaykt, string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("Bao Cao Doanh Thu Tu  " + ngaybd + " Den " + ngaykt);
            doc.Add(Paragraph0);
            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            Paragraph Paragraph = new Paragraph("SL: " + sl);
            doc.Add(Paragraph);
            Paragraph Paragraph1 = new Paragraph("Tong: " + tongTien + " VND");
            doc.Add(Paragraph1);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }


        public void xuatfile_tragop(DataGridView datagrid, string sldaBan, string tongTienDaTT, string tongTienConLai, string tongTienPhaiNhan, string ngaybd, string ngaykt, string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("Bao Cao Doanh Thu Tra Gop Tu  " + ngaybd + " Den " + ngaykt);
            doc.Add(Paragraph0);

            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            Paragraph Paragraph = new Paragraph("SL Da Ban: " + sldaBan);
            doc.Add(Paragraph);
            Paragraph Paragraph1 = new Paragraph("Tong Tien Da Thanh Toan: " + tongTienDaTT + " VND");
            doc.Add(Paragraph1);
            Paragraph Paragraph2 = new Paragraph("Tong Tien Con Lai: " + tongTienConLai + " VND");
            doc.Add(Paragraph2);
            Paragraph Paragraph3 = new Paragraph("Tong Tien Phai Nhan: " + tongTienPhaiNhan + " VND");
            doc.Add(Paragraph3);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }



        public void xuatfile_HD(DataGridView datagrid, string tongTien, string NgayHienTai, string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("Hoa Don   " + NgayHienTai);
            doc.Add(Paragraph0);
            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            Paragraph Paragraph1 = new Paragraph("Tong: " + tongTien + " VND");
            doc.Add(Paragraph1);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }

        public void xuatfileHD_TragopNCC(DataGridView datagrid, string tongTien,string tienconlaiphaitra, string NgayHienTai, string tenfile)
        {

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("Hoa don tra gop cho nha cung cap " +"              Ngày trả  "+ NgayHienTai);
            doc.Add(Paragraph0);
            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            Paragraph Paragraph1 = new Paragraph("Số tiền thanh toán " + tongTien + " VND");
            doc.Add(Paragraph1);
            Paragraph Paragraph2 = new Paragraph("so tien con lai phai tra " + tienconlaiphaitra + " VND");
            doc.Add(Paragraph2);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }

        public void xuatfile_HD_TraGop(DataGridView datagrid,string matragop, string tongTien, string NgayHienTai, string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("Ma Tra Gop: "+matragop+"        Hoa Don Tra Gop   " + NgayHienTai);
            doc.Add(Paragraph0);
            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            Paragraph Paragraph1 = new Paragraph("Tong: " + tongTien + " VND");
            doc.Add(Paragraph1);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }


        public void xuatfile_HD_NhapHang(DataGridView datagrid, string mapn, string tongTien, string sl, string NgayHienTai, string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("Ma Phieu Nhap: " + mapn + "        Hoa Don Nhap Hang   " + NgayHienTai);
            doc.Add(Paragraph0);
            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            Paragraph Paragraph = new Paragraph("SL: " + sl);
            doc.Add(Paragraph);
            Paragraph Paragraph1 = new Paragraph("Tong: " + tongTien + " VND");
            doc.Add(Paragraph1);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }

        public void xuatfile_HD_LK(DataGridView datagrid, string mapn, string tongTien, string sl, string NgayHienTai, string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("Ma Phieu Nhap: " + mapn + "        Hoa Don Nhap Linh Kien   " + NgayHienTai);
            doc.Add(Paragraph0);
            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            Paragraph Paragraph = new Paragraph("SL: " + sl);
            doc.Add(Paragraph);
            Paragraph Paragraph1 = new Paragraph("Tong: " + tongTien + " VND");
            doc.Add(Paragraph1);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }



        public void xuatfile_HD_DoiTra(DataGridView datagrid, string mahd, string chenhLech, string NgayHienTai, string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("MaHD " + mahd + "        Hoa Don Doi Tra   " + NgayHienTai);
            doc.Add(Paragraph0);
            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            Paragraph Paragraph1 = new Paragraph("Tong: " + chenhLech + " VND");
            doc.Add(Paragraph1);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }




        public void xuatfile_HD_BaoHanh(DataGridView datagrid, string mahd, string tong, string NgayHienTai, string tenfile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            iTextSharp.text.pdf.PdfWriter wir = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(tenfile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Paragraph0 = new Paragraph("MaHD " + mahd + "        Hoa Don Bao Hanh   " + NgayHienTai);
            doc.Add(Paragraph0);
            Paragraph Paragraph5 = new Paragraph(" ");
            doc.Add(Paragraph5);

            PdfPTable table = new PdfPTable(datagrid.ColumnCount);
            for (int j = 0; j < datagrid.ColumnCount; j++)
            {
                table.AddCell(new Phrase(datagrid.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                for (int k = 0; k < datagrid.ColumnCount; k++)
                {
                    if (datagrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(datagrid[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            Paragraph Paragraph1 = new Paragraph("Tong: " + tong + " VND");
            doc.Add(Paragraph1);
            doc.Close();
            MessageBox.Show("Xuất file pdf Thành Công!!!");

            Process Pdf = new Process();
            Pdf.StartInfo.FileName = "AcroRd32.exe";
            Pdf.StartInfo.Arguments = tenfile + ".pdf";
            Pdf.Start();
        }
















        }
    }

