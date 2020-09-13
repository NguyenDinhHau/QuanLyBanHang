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

namespace QuanLyBanGiay
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strSql = "Server = DESKTOP-KJ1U6CT;Database = CSDL_QLBG; user id = sa; pwd = Hoa95@100";
        public void hienThi()
        {
            connect_data();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select * from BanGiay";
            sqlCommand.Connection = conn;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            lsv_data.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetInt32(0) + "");
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetString(6));
                item.SubItems.Add(reader.GetString(7));
                item.SubItems.Add(reader.GetDateTime(8) + "");
                item.SubItems.Add(reader.GetString(9));
                lsv_data.Items.Add(item);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienThi();
        }
        public void connect_data()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strSql);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_them_data fm_data = new frm_them_data();
            fm_data.ShowDialog(this);
        }

        private void btn_tiemKiem_Click(object sender, EventArgs e)
        {
            fm_timKiem fm_TimKiem = new fm_timKiem();
            fm_TimKiem.ShowDialog(this);
        }

        private void lsv_data_DoubleClick(object sender, EventArgs e)
        {
            if(lsv_data.SelectedItems.Count >0)
            {
                ListViewItem item = lsv_data.SelectedItems[0];
                int stt = int.Parse(item.SubItems[0].Text);
                frm_update frm_update = new frm_update(stt);
                frm_update.ShowDialog(this);
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(lsv_data.SelectedItems.Count >0)
            {
                ListViewItem item = lsv_data.SelectedItems[0];
                int index = int.Parse(item.SubItems[0].Text);
                connect_data();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql_str = "delete from BanGiay where Stt = " + index;
                command.CommandText = sql_str;
                command.Connection = conn;

                int ret = command.ExecuteNonQuery();

                if(ret > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }    
                else
                {
                    MessageBox.Show("Lỗi Xóa");
                }
                conn.Close();
            } 
            else
            {
                MessageBox.Show("Bạn cần chọn item để xóa");
            }    
        }

        private void frm_main_Click(object sender, EventArgs e)
        {
            hienThi();
        }
    }
}
