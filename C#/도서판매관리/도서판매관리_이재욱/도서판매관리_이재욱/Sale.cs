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
using BookDBConn_OleDb;

namespace 도서판매관리_1612077_이재욱
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }

        private void o매출액확인후종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report f = new Report();
            f.ShowDialog();
        }

        private void x종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("바코드를 입력하세요");
                txtCode.Focus();
                return;
            }
            string sql = "select book_code, book_name, book_price, book_publisher from book where book_code like'%" + txtCode.Text + "%'";

            BookDBConn conn = new BookDBConn();
            OleDbDataReader dr = conn.ExecuteReader(sql);
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["book_code"].ToString() + "\t" +
                                   dr["book_name"].ToString() + "\t" +
                                   dr["book_price"].ToString() + "\t" +
                                   dr["book_publisher"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("제목을 입력하세요");
                txtTitle.Focus();
                return;
            }
            string sql = "select book_code, book_name, book_price, book_publisher from book where book_name like'%" + txtTitle.Text + "%'";

            BookDBConn conn = new BookDBConn();
            OleDbDataReader dr = conn.ExecuteReader(sql);
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["book_code"].ToString() + "\t" +
                                   dr["book_name"].ToString() + "\t" +
                                   dr["book_price"].ToString() + "\t" +
                                   dr["book_publisher"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string result = ""; foreach (var input_items in listBox1.Items) { result += string.Format("{0} ", input_items); }
            txtBag.Text = result;

            /*  for (int i = 0; i<= listBox1.Items.Count; i++)
              {
                  listBox2.Items[i].ToString();
              }
  */
        }

        private void txtBag_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPutIn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(txtBag.Text); txtBag.Text = "";
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(txtBag.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPutout_Click(object sender, EventArgs e)
        {
            string result = ""; foreach (var input_items in listBox2.Items) { result += string.Format("{0} ", input_items); }
            txtBag.Text = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("총액을 확인하세요");
                txtTotal.Focus();
                return;
            }
            int a;
            a = Convert.ToInt32(txtMoney.Text) - Convert.ToInt32(txtTotal.Text);
            txtChange.Text = (a.ToString());
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            string s = listBox2.Items.ToString();
            MessageBox.Show(s);
        }
    }
}
