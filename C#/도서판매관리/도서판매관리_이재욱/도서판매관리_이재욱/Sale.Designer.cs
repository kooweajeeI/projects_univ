namespace 도서판매관리_1612077_이재욱
{
    partial class Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.btnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.총액 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.e마감ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.o매출액확인후종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtBag = new System.Windows.Forms.TextBox();
            this.btnPutIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 136);
            this.listBox1.TabIndex = 0;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(573, 445);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(47, 16);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "현금";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(626, 445);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(47, 16);
            this.rbCard.TabIndex = 2;
            this.rbCard.Text = "카드";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(163, 312);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(48, 23);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "↓";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "결제수단";
            // 
            // 총액
            // 
            this.총액.AutoSize = true;
            this.총액.Location = new System.Drawing.Point(515, 421);
            this.총액.Name = "총액";
            this.총액.Size = new System.Drawing.Size(29, 12);
            this.총액.TabIndex = 7;
            this.총액.Text = "총액";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(572, 418);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 8;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(74, 60);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 21);
            this.txtCode.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(74, 101);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 21);
            this.txtTitle.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "바코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "제목";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(180, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(678, 395);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "총액";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "받은 돈";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "거스름돈";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(572, 470);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 15;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(572, 497);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 21);
            this.txtChange.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "장바구니";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(628, 534);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(116, 23);
            this.btnReceipt.TabIndex = 18;
            this.btnReceipt.Text = "결제완료(영수증)";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.e마감ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // e마감ToolStripMenuItem
            // 
            this.e마감ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.o매출액확인후종료ToolStripMenuItem,
            this.x종료ToolStripMenuItem});
            this.e마감ToolStripMenuItem.Name = "e마감ToolStripMenuItem";
            this.e마감ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.e마감ToolStripMenuItem.Text = "(&E)마감";
            // 
            // o매출액확인후종료ToolStripMenuItem
            // 
            this.o매출액확인후종료ToolStripMenuItem.Name = "o매출액확인후종료ToolStripMenuItem";
            this.o매출액확인후종료ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.o매출액확인후종료ToolStripMenuItem.Text = "(&O)매출 확인";
            this.o매출액확인후종료ToolStripMenuItem.Click += new System.EventHandler(this.o매출액확인후종료ToolStripMenuItem_Click);
            // 
            // x종료ToolStripMenuItem
            // 
            this.x종료ToolStripMenuItem.Name = "x종료ToolStripMenuItem";
            this.x종료ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.x종료ToolStripMenuItem.Text = "(&X)종료";
            this.x종료ToolStripMenuItem.Click += new System.EventHandler(this.x종료ToolStripMenuItem_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnFind);
            this.gbSearch.Controls.Add(this.listBox1);
            this.gbSearch.Controls.Add(this.txtCode);
            this.gbSearch.Controls.Add(this.txtTitle);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Location = new System.Drawing.Point(23, 27);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(316, 279);
            this.gbSearch.TabIndex = 20;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "상품조회";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(180, 99);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "조회";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(420, 116);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(333, 244);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // txtBag
            // 
            this.txtBag.Location = new System.Drawing.Point(29, 339);
            this.txtBag.Name = "txtBag";
            this.txtBag.Size = new System.Drawing.Size(304, 21);
            this.txtBag.TabIndex = 21;
            this.txtBag.TextChanged += new System.EventHandler(this.txtBag_TextChanged);
            // 
            // btnPutIn
            // 
            this.btnPutIn.Location = new System.Drawing.Point(339, 337);
            this.btnPutIn.Name = "btnPutIn";
            this.btnPutIn.Size = new System.Drawing.Size(75, 23);
            this.btnPutIn.TabIndex = 22;
            this.btnPutIn.Text = "→";
            this.btnPutIn.UseVisualStyleBackColor = true;
            this.btnPutIn.Click += new System.EventHandler(this.btnPutIn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(678, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(678, 468);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(75, 23);
            this.btnMoney.TabIndex = 25;
            this.btnMoney.Text = "계산";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 585);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPutIn);
            this.Controls.Add(this.txtBag);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.총액);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sale";
            this.Text = "판매";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 총액;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem e마감ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem o매출액확인후종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x종료ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtBag;
        private System.Windows.Forms.Button btnPutIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMoney;
    }
}