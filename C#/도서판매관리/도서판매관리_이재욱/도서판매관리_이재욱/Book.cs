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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select book_code, book_name, book_price, book_publisher,book_number from book order by book_publisher";

            BookDBConn conn = new BookDBConn();
            OleDbDataReader dr = conn.ExecuteReader(sql);
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["book_code"].ToString() + "\t" +
                                   dr["book_name"].ToString() + "\t" +
                                   dr["book_price"].ToString() + "\t" +
                                    dr["book_publisher"].ToString() + "\t" +
                                   dr["book_number"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookcode.Text == "")
            {
                MessageBox.Show("바코드를 입력하세요");
                txtBookcode.Focus();
                return;
            }

            if (txtBookname.Text == "")
            {
                MessageBox.Show("제목을 입력하세요");
                txtBookname.Focus();
                return;
            }

            if (txtBookprice.Text == "")
            {
                MessageBox.Show("가격을 입력하세요");
                txtBookprice.Focus();
                return;
            }
            if (txtBookpublisher.Text == "")
            {
                MessageBox.Show("출판사를 입력하세요");
                txtBookpublisher.Focus();
                return;
            }
            if (txtBookNumber.Text == "")
            {
                MessageBox.Show("재고를 입력하세요");
                txtBookNumber.Focus();
                return;
            }

            string sql = "insert into book(book_code,book_name,book_price,book_publisher,book_number) " +
                "values(@book_code,@book_name, @book_price, @book_publisher, @book_number)";
            BookDBConn conn = new BookDBConn();
            OleDbCommand cmmd = new OleDbCommand(sql, conn.GetConn());
            cmmd.Parameters.AddWithValue("@book_code", txtBookcode.Text);
            cmmd.Parameters.AddWithValue("@book_name", txtBookname.Text);
            cmmd.Parameters.AddWithValue("@book_price", txtBookprice.Text);
            cmmd.Parameters.AddWithValue("@book_publisher", txtBookpublisher.Text);
            cmmd.Parameters.AddWithValue("@book_publisher", txtBookNumber.Text);

            try
            {
                cmmd.ExecuteNonQuery();
                MessageBox.Show("저장되었습니다");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listBox1.SelectedItem.ToString();
            string[] ss = s.Split('\t'); // Tab 문자로 분리
            txtBookcode.Text = ss[0];
            txtBookname.Text = ss[1];
            txtBookprice.Text = ss[2];
            txtBookpublisher.Text = ss[3];
            txtBookNumber.Text = ss[4];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookcode.Text == "")
            {
                MessageBox.Show("바코드를 입력하세요");
                txtBookcode.Focus();
                return;
            }
            string sql = "update book set book_code=@book_code,book_name=@book_name,book_price=@book_price,book_publisher=@book_publisher,book_number=@book_number where book_code=@book_code";
            BookDBConn conn = new BookDBConn();
            OleDbCommand cmmd = new OleDbCommand(sql, conn.GetConn());
            cmmd.Parameters.AddWithValue("@book_code", txtBookcode.Text);
            cmmd.Parameters.AddWithValue("@book_name", txtBookname.Text);
            cmmd.Parameters.AddWithValue("@book_price", txtBookprice.Text);
            cmmd.Parameters.AddWithValue("@book_publisher", txtBookpublisher.Text);
            cmmd.Parameters.AddWithValue("@book_number", txtBookNumber.Text);

            try
            {
                cmmd.ExecuteNonQuery();
                MessageBox.Show("변경되었습니다");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBookcode.Text == "")
            {
                MessageBox.Show("바코드를 입력하세요");
                txtBookcode.Focus();
                return;
            }
            string sql = "delete from book where book_code='" + txtBookcode.Text + "'";

            BookDBConn conn = new BookDBConn();
            try
            {
                conn.ExecuteNonQuery(sql);

                MessageBox.Show("삭제되었습니다");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtBookcode.Text == "")
            {
                MessageBox.Show("바코드를 입력하세요");
                txtBookcode.Focus();
                return;
            }

            string sql = "select * from book where book_code='" + txtBookcode.Text + "'";
        }
    }
}
