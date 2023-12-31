﻿using System;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // 사용자 캘린더 날짜 변경하면 텍스트 박스 내용 변경
            txtStartDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            txtEndDate.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // 초기 선택 범위 지정
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now.AddDays(3);

            // MaxSelectionCount 디폴트 값은 7일            
            monthCalendar1.MaxSelectionCount = 31;
        }
    }
}
