﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLTiemBanhMi.Connector;
using System.Data;
using System.Data.SqlClient;
using QLTiemBanhMi.Object;

namespace QLTiemBanhMi.QuanTriHeThong{
    public partial class Phanquyen : DevExpress.XtraEditors.XtraForm
    {
        int flag = 0;
        List<string> maquyentheoid = new List<string>();
        public Phanquyen()
        {
            InitializeComponent();
          
        }

        private void glue_nhanvien_EditValueChanged(object sender, EventArgs e)
        {
            flag = 1;
           
            LayDSMaQuyenTheoID(glue_nhanvien.EditValue.ToString());

        }

        public void LayDSMaQuyenTheoID(string nhanvienid)
        {
            maquyentheoid = Program.Quantrihethongsql.LayDSMaQuyenTheoNVID(nhanvienid);
            
            int add = 0;
    
         
            foreach (DataGridViewRow row in dtgvDSQuyen.Rows)
            {
                if(maquyentheoid.Contains(row.Cells["ID"].Value.ToString()))
                {
                    add += 1;
                    row.Cells["Chk"].Value = true;
                }    
                else
                {
                    row.Cells["Chk"].Value = false;
                }    
             
                
            }
           
        }

       
        private void Phanquyen_Load(object sender, EventArgs e)
        {
            Program.Quantrihethongsql.SelectAll(dtgvDSQuyen);
            List<string> list_nhanvienid = Program.Quanlyhoadonsql.LayDS_NhanVien(glue_nhanvien);
            dtgvDSQuyen.Columns["ID"].ReadOnly = true;
            dtgvDSQuyen.Columns["TenQuyen"].ReadOnly = true;
            
            
        }

       

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            maquyentheoid = Program.Quantrihethongsql.LayDSMaQuyenTheoNVID(glue_nhanvien.EditValue.ToString());
            List<string> addedlist = new List<string>();
            List<string> movedlist = new List<string>();
            List<string> newmaquyentheoid = new List<string>();

           


            if (flag == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Notice Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string neww = " ";
                for (int i = 0; i < dtgvDSQuyen.Rows.Count; i++)
                //if dgv is autogenerated then change the condition to i < dataGridView1.Rows.Count - 1
                {
                    if (bool.Parse(dtgvDSQuyen.Rows[i].Cells["Chk"].Value.ToString()) == true)
                    {
                        newmaquyentheoid.Add(dtgvDSQuyen.Rows[i].Cells["ID"].Value.ToString());
                        neww += " " + dtgvDSQuyen.Rows[i].Cells["ID"].Value.ToString();
                    }

                }
                int count = 0;
                
                foreach (string item in newmaquyentheoid)
                {
                    string sql = "ThemPhanQuyenNguoiDung";
                    string[] para = { "@nhanvienid", "@quyenthaotacid" };
                    object[] values = { Int32.Parse(glue_nhanvien.EditValue.ToString()), Int32.Parse(item) };
                    int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
                    if (a != 0)
                    {
                        count += 1;
                    }
                }
                //xoa
                string xoa = " ";
                foreach (string i in maquyentheoid)
                {
                    if (!newmaquyentheoid.Contains(i))
                    {
                        movedlist.Add(i);
                        xoa += " "+ i;
                    }
                }
                foreach (string item in movedlist)
                {
                    string sql = "XoaPhanQuyenNguoiDung";
                    string[] para = { "@nhanvienid", "@quyenthaotacid" };
                    object[] values = { Int32.Parse(glue_nhanvien.EditValue.ToString()), Int32.Parse(item) };
                    int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);

                }
              
                if (Program.Quantrihethongsql.LayDSMaQuyenTheoNVID(glue_nhanvien.EditValue.ToString()).Count == newmaquyentheoid.Count)
                {
                    MessageBox.Show("Lưu thành công", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                }    
                else
                {
                    XtraMessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }    
            } 
            
            //else
            //{
            //    for (int i = 1; i < dtgvDSQuyenThaoTac.RowCount; i++)
            //    {
            //        if (Convert.ToBoolean(dtgvDSQuyenThaoTac.Rows[i].Cells["Check"].Value))
            //        {
            //            newmaquyentheoid.Add(dtgvDSQuyenThaoTac.Rows[i].Cells["ID"].Value.ToString());
            //        }

            //    }


            //    //        foreach (DataGridViewRow row in dtgvDSQuyenThaoTac.Rows)
            //    //{
            //    //    DataGridViewCheckBoxCell cell = row.Cells[2] as DataGridViewCheckBoxCell;
            //    //    if(cell != null)
            //    //    {
            //    //        if (Convert.ToBoolean(cell.Value).Equals(true))
            //    //        // if (isSelected)
            //    //        {
            //    //            newmaquyentheoid.Add(row.Cells[0].Value.ToString());

            //    //        }
            //    //    }    
                   
                    
            //    //}
            //    foreach (string i in newmaquyentheoid)
            //    {
            //        if (!maquyentheoid.Contains(i))
            //        {
            //            addedlist.Add(i);
            //        }
            //    }
            //    foreach (string i in maquyentheoid)
            //    {
            //        if(!newmaquyentheoid.Contains(i))
            //        {
            //            movedlist.Add(i);
            //        }    
            //    }    
            //    int count_added = 0;
            //    int count_moved = 0;
            //    textBox1.Text = "them"+ addedlist.ToList().Count.ToString();
            //    textBox2.Text ="xoa"+ movedlist.Count.ToString();
            //    textBox3.Text = "ban dau"+ maquyentheoid.Count.ToString();
            //    textBox4.Text = "hien tai"+ newmaquyentheoid.Count.ToString();
            //    if (addedlist.Count != 0)
            //    {
                   
                   
            //        foreach (string item in addedlist)
            //        {
            //            string sql = "UpdatePhanQuyenNguoiDung";
            //            string[] para = { "@nhanvienid", "@quyenthaotacid" };
            //            object[] values = { Int32.Parse(glue_nhanvien.EditValue.ToString()), Int32.Parse(item) };
            //            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //            if (a != 0)
            //            {
            //                count_added += 1;
            //            }
            //        }
            //    }    
            //    if(movedlist.Count != 0)
            //    {
            //        //movedlist = moved.ToList();
                    
            //        foreach (string item in movedlist)
            //        {
            //            string sql = "XoaPhanQuyenNguoiDung";
            //            string[] para = { "@nhanvienid", "@quyenthaotacid" };
            //            object[] values = { Int32.Parse(glue_nhanvien.EditValue.ToString()), Int32.Parse(item) };
            //            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //            if (a != 0)
            //            {
            //                count_moved += 1;
            //            }
            //        }
            //    }
            //    if(count_added+count_moved== addedlist.Count+ movedlist.Count)
            //    {
            //        MessageBox.Show("Lưu thành công", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        maquyentheoid = Program.Quantrihethongsql.LayDSMaQuyenTheoNVID(glue_nhanvien.EditValue.ToString());
            //        copymaquyenid = maquyentheoid;
            //        Program.PhanQuyenList = new List<QuyenThaoTac>();
            //        Program.PhanQuyenList = Program.Quantrihethongsql.LayDSPhanQuyenTheoNVID(Program.user.Id);
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("Cập nhật không thành công!", "Thông báo");
            //    }    
              
            //}
        }

        private void dtgvDSQuyenThaoTac_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;
            //bool isChecked = Boolean.Parse(dtgvDSQuyenThaoTac.Rows[e.RowIndex].Cells["Check"].Value.ToString());

            //if (isChecked)
            //{
            //    copymaquyenid.Add(dtgvDSQuyenThaoTac.Rows[e.RowIndex].Cells[0].Value.ToString());
            //}
            //else
            //{
            //    copymaquyenid.Remove(dtgvDSQuyenThaoTac.Rows[e.RowIndex].Cells[0].Value.ToString());
            //}
        }
    }
}