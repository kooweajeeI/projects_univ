namespace 도서판매관리_1612077_이재욱
{
    partial class Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select));
            this.btnBook = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("문체부 궁체 정자체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBook.Location = new System.Drawing.Point(298, 22);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(174, 60);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "도서관리";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.SystemColors.Info;
            this.btnSale.Font = new System.Drawing.Font("문체부 궁체 정자체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSale.Location = new System.Drawing.Point(298, 88);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(174, 57);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "판매관리";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("문체부 궁체 정자체", 24F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Yellow;
            this.btnClose.Location = new System.Drawing.Point(298, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 66);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "종료";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gold;
            this.btnReport.Font = new System.Drawing.Font("문체부 궁체 정자체", 24F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.Maroon;
            this.btnReport.Location = new System.Drawing.Point(12, 283);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(183, 66);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "보고서";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서/판매관리";
            this.Load += new System.EventHandler(this.Select_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReport;
    }
}