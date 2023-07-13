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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
           // this.btnBook.Click += btnSale_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 새로운 창 초기화
            Book newForm = new Book();
            // 새로운 창 띄우기
            newForm.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Sale newForm = new Sale();
            newForm.Show();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report newForm = new Report();
            newForm.Show();
        }
    }
}
