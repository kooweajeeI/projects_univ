using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 도서판매관리_1612077_이재욱
{
    public partial class Form1 : Form
    {
        int err_cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("아이디를 입력하세요");
                txtID.Focus();
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요");
                txtPwd.Focus();
                return;
                }
            if (txtID.Text == "admin")
            {
                Admin f = new Admin();
                f.ShowDialog();
            }
            else
            {
                string sql = "select pwd from member where id='" +
                txtID.Text + "'";
                string pwd = Program.MD5Hash(txtPwd.Text).Trim();
                DBConn conn = new DBConn();
                object pwd2 = conn.ExecuteScalar(sql);
                if (pwd2 != null && pwd2.ToString() == pwd)
                {
                    MDIForm mdi = new MDIForm();
                    mdi.Show();
                    this.Hide();
                }
                else
                {
                    err_cnt++;
                    if (err_cnt >= 1)
                    {
                        MessageBox.Show("아이디랑 비밀번호를 다시 확인해주세요.");
                    }
                    if (err_cnt >= 3)
                    {
                        MessageBox.Show("3회 이상 로그인에 실패하였습니다.");
                        Application.Exit();
                    }
                }
            }
        }
    }
}