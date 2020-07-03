using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using iDiTect.Word.Basic.Model;
using iDiTect.Word.Editing;
using iDiTect.Word.IO;
using iDiTect.Word.Shapes;
using iDiTect.Word.Styles;
using System.IO;

namespace QLBV
{
    public partial class Form1 : Form
    {
        QLBNEntities2 db = new QLBNEntities2();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGridControl();
        }
        private void RefreshGridControl()
        {
            dgv_Data.DataSource = db.TT_BenhNhan.ToList();
        }

        private void dgv_Data_SelectionChanged(object sender, EventArgs e)
        {
            string txtGioiTinh = dgv_Data.CurrentRow.Cells["Gioi_Tinh"].Value.ToString();
            txtTenBN.Text = dgv_Data.CurrentRow.Cells["Ten_BN"].Value.ToString();
            txtDiaChi.Text = dgv_Data.CurrentRow.Cells["Dia_Chi"].Value.ToString();
            txtBHYT.Text = dgv_Data.CurrentRow.Cells["So_BHYT"].Value.ToString();
            txtLoaiDV.Text = dgv_Data.CurrentRow.Cells["Loai_DV_Kham"].Value.ToString();
            if (txtGioiTinh == "Nam")
            {
                RB_Nam.Checked = true;
            }
            else
            {
                RB_Nu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string global = "BN-";
            string today = DateTime.Now.ToString("MMddss");
            TT_BenhNhan ins_TTBN = new TT_BenhNhan();
            ins_TTBN.MaBN = string.Concat(global, today);
            ins_TTBN.Ten_BN = txtTenBN.Text;
            ins_TTBN.Dia_Chi = txtDiaChi.Text;
            if (RB_Nam.Checked == true)
            {
                ins_TTBN.Gioi_Tinh = "Nam";
            }
            else
            {
                ins_TTBN.Gioi_Tinh = "Nữ";
            }
            ins_TTBN.So_BHYT = txtBHYT.Text;
            ins_TTBN.Loai_DV_Kham = txtLoaiDV.Text;
            ins_TTBN.Ngay_Sinh = dTPNgaySinh.Value;
            try
            {
                db.TT_BenhNhan.Add(ins_TTBN);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Success");
                RefreshGridControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //Lấy file template
            string strFileName = "Test.docx";
            string strFileTemplate = string.Format(@"{0}\{1}", Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())), strFileName);
            if (!System.IO.File.Exists(strFileTemplate))
            {
                MessageBox.Show(string.Format("File mẫu không tồn tại."));
                return;
            }

            //List chứa key và value cần replace
            SortedList<string, string> lstTemp = new SortedList<string, string>();

            //set thông tin bênh nhân
            var lst = db.KQXNs.ToList();
            foreach (var item in lst)
            {
                lstTemp.Add("[tenbv]", item.Loai_XN);
                lstTemp.Add("[no]", "Test no");
            }
            //set thong tin chi tiet ket qua 


            //lstTemp.Add("[tenbv]", "Test");
            //lstTemp.Add("[no]", "Test no");

            ExportFile(strFileTemplate, lstTemp);

        }


        public void ExportFile(string strFileTemplate, SortedList<string, string> lstKeyAndValueReplaces, Boolean isVisible = false, string strFileNameDefault = "")
        {
            //Lưu file vào vị trí nào
            string strFilePath = "";
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Word 2003 file(*.doc)|*.doc | Word 2007 file(*.docx)|*.docx";
            saveDlg.AddExtension = true;
            saveDlg.RestoreDirectory = true;
            saveDlg.Title = "Chọn vị trí lưu file?";

            //Tên file
            if (!string.IsNullOrEmpty(strFileNameDefault))
                saveDlg.FileName = string.Format(@"{0}", strFileNameDefault);

            if (saveDlg.ShowDialog() == DialogResult.Cancel)
                return;

            Word.Application wordApp = new Word.Application();
            Microsoft.Office.Interop.Word.Document newDocument = wordApp.Documents.Open(strFileTemplate);

            try
            {
                //Xoá file đã tồn tại, tại vị trí lưu
                strFilePath = saveDlg.FileName;
                if (File.Exists(strFilePath))
                {
                    File.Delete(strFilePath);
                }


                //Replace key = giá trị 
                foreach (string keys in lstKeyAndValueReplaces.Keys)
                {
                    while (newDocument.Content.Find.Execute(FindText: keys))
                    {
                        if (newDocument.Content.Find.Execute(FindText: keys))
                        {
                            if (lstKeyAndValueReplaces[keys].Length > 254)
                            {
                                if (newDocument.Application.Selection.Find.Execute(keys) == true)
                                {
                                    newDocument.Application.Selection.Text = lstKeyAndValueReplaces[keys];
                                    break;
                                }
                            }
                            else
                            {
                                newDocument.Content.Find.Execute(FindText: keys, ReplaceWith: lstKeyAndValueReplaces[keys], Replace: WdReplace.wdReplaceOne);
                            }
                        }
                    }
                }

                CreateDocumentPropertyTable(newDocument);
                //Lưu file
                newDocument.SaveAs(strFilePath);

                wordApp.Visible = isVisible;

                if (!isVisible)
                {
                    newDocument.Close();
                    wordApp.Quit();
                }
            }
            catch (Exception ex)
            {
                newDocument.Close();
                wordApp.Quit();
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateDocumentPropertyTable(Document newDocument)
        {
            //<Snippet90>
            object start = 10, end = 10;
            Word.Range rangeTbl = null;
            string keys = "[tbl]";
            while (newDocument.Content.Find.Execute(FindText: keys))
            {
                if (newDocument.Content.Find.Execute(FindText: keys))
                {

                    if (newDocument.Application.Selection.Find.Execute(keys) == true)
                    {
                        rangeTbl = newDocument.Range(newDocument.Application.Selection.Range.Start, newDocument.Application.Selection.Range.End);
                    }
                }
            }

            //if (newDocument.Application.Selection.Find.Execute("[tbl]"))
            //{
            //    rangeTbl = newDocument.Range(newDocument.Application.Selection.Range.Start, newDocument.Application.Selection.Range.End); 
            //}

            Word.Range rng = newDocument.Range(rangeTbl.Start, rangeTbl.End);
            //</Snippet90>

            // Insert a title for the table and paragraph marks. 
            //<Snippet91>
            //rng.InsertBefore("Document Statistics");
            rng.Font.Name = "Calibri (Body)";
            rng.Font.Size = 16;
            rng.InsertParagraphAfter();
            rng.InsertParagraphAfter();
            rng.SetRange(rng.End, rng.End);
            //</Snippet91>

            // Add the table.
            //<Snippet92>
            rng.Tables.Add(newDocument.Paragraphs[2].Range, 3, 2);
            //</Snippet92>

            // Format the table and apply a style. 
            //<Snippet93>
            Word.Table tbl = newDocument.Tables[1];
            tbl.Range.Font.Size = 12;
            tbl.Columns.DistributeWidth();

            object styleName = "Table Professional";
            tbl.set_Style(ref styleName);
            //</Snippet93>

            // Insert document properties into cells. 
            //<Snippet94>
            tbl.Cell(1, 1).Range.Text = "Document Property";
            tbl.Cell(1, 2).Range.Text = "Value";

            tbl.Cell(2, 1).Range.Text = "Subject";
            tbl.Cell(2, 2).Range.Text = "Test";

            tbl.Cell(3, 1).Range.Text = "Author";
            tbl.Cell(3, 2).Range.Text = "test";
            //</Snippet94>
        }
    }
}
