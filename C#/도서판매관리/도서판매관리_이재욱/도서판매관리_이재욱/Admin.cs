using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace 도서판매관리_1612077_이재욱
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNm.Text == "")
            {
                MessageBox.Show("이름을 입력하세요");
                txtNm.Focus();
                return;
            }
            if (txtId.Text == "")
            {
                MessageBox.Show("아이디를 입력하세요");
                txtId.Focus();
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("암호를 입력하세요");
                txtPwd.Focus();
                return;
            }
            string sql = "insert into member(id,pwd,nm,reg_date" +
            ") values(@id,@pwd,@nm,@reg_date)";
            string pwd = Program.MD5Hash(txtPwd.Text);
            DBConn conn = new DBConn();
            OleDbCommand cmd = new OleDbCommand(sql, conn.GetConn());
            cmd.Parameters.Add("@nm", txtNm.Text);
            cmd.Parameters.Add("@id", txtId.Text);
            cmd.Parameters.Add("@pwd", pwd);
            cmd.Parameters.Add("@reg_date", DateTime.Now.ToString());

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("저장되었습니다");
                txtNm.Text = "";
                txtId.Text = "";
                txtPwd.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}