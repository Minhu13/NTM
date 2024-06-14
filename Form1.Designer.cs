namespace NTM
{
    partial class Form1
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
            this.tbSK = new System.Windows.Forms.DataGridView();
            this.cb_tenKH = new System.Windows.Forms.ComboBox();
            this.btAddKH = new System.Windows.Forms.Button();
            this.txtmkh = new System.Windows.Forms.TextBox();
            this.txttkh = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.btDangKy = new System.Windows.Forms.Button();
            this.tbAll = new System.Windows.Forms.DataGridView();
            this.btTTDK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAll)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSK
            // 
            this.tbSK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbSK.Location = new System.Drawing.Point(21, 162);
            this.tbSK.Name = "tbSK";
            this.tbSK.RowHeadersWidth = 51;
            this.tbSK.RowTemplate.Height = 24;
            this.tbSK.Size = new System.Drawing.Size(976, 164);
            this.tbSK.TabIndex = 0;
            // 
            // cb_tenKH
            // 
            this.cb_tenKH.FormattingEnabled = true;
            this.cb_tenKH.Location = new System.Drawing.Point(89, 359);
            this.cb_tenKH.Name = "cb_tenKH";
            this.cb_tenKH.Size = new System.Drawing.Size(121, 24);
            this.cb_tenKH.TabIndex = 1;
            // 
            // btAddKH
            // 
            this.btAddKH.Location = new System.Drawing.Point(361, 70);
            this.btAddKH.Name = "btAddKH";
            this.btAddKH.Size = new System.Drawing.Size(75, 48);
            this.btAddKH.TabIndex = 2;
            this.btAddKH.Text = "Thêm";
            this.btAddKH.UseVisualStyleBackColor = true;
            this.btAddKH.Click += new System.EventHandler(this.btAddKH_Click);
            // 
            // txtmkh
            // 
            this.txtmkh.Location = new System.Drawing.Point(89, 23);
            this.txtmkh.Multiline = true;
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new System.Drawing.Size(202, 35);
            this.txtmkh.TabIndex = 3;
            // 
            // txttkh
            // 
            this.txttkh.Location = new System.Drawing.Point(89, 83);
            this.txttkh.Multiline = true;
            this.txttkh.Name = "txttkh";
            this.txttkh.Size = new System.Drawing.Size(202, 35);
            this.txttkh.TabIndex = 4;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(380, 23);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(202, 35);
            this.txtsdt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên KH:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(89, 419);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(202, 35);
            this.txtSoLuong.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày đăng ký:";
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Location = new System.Drawing.Point(467, 356);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(253, 22);
            this.dtpNgayDangKy.TabIndex = 13;
            // 
            // btDangKy
            // 
            this.btDangKy.Location = new System.Drawing.Point(361, 406);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(189, 48);
            this.btDangKy.TabIndex = 14;
            this.btDangKy.Text = "Đăng ký";
            this.btDangKy.UseVisualStyleBackColor = true;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // tbAll
            // 
            this.tbAll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbAll.Location = new System.Drawing.Point(21, 587);
            this.tbAll.Name = "tbAll";
            this.tbAll.RowHeadersWidth = 60;
            this.tbAll.RowTemplate.Height = 24;
            this.tbAll.Size = new System.Drawing.Size(976, 164);
            this.tbAll.TabIndex = 16;
            // 
            // btTTDK
            // 
            this.btTTDK.Location = new System.Drawing.Point(744, 514);
            this.btTTDK.Name = "btTTDK";
            this.btTTDK.Size = new System.Drawing.Size(189, 48);
            this.btTTDK.TabIndex = 17;
            this.btTTDK.Text = "Hiển thị thông tin đăng ký";
            this.btTTDK.UseVisualStyleBackColor = true;
            this.btTTDK.Click += new System.EventHandler(this.btTTDK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1040, 607);
            this.Controls.Add(this.btTTDK);
            this.Controls.Add(this.tbAll);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txttkh);
            this.Controls.Add(this.txtmkh);
            this.Controls.Add(this.btAddKH);
            this.Controls.Add(this.cb_tenKH);
            this.Controls.Add(this.tbSK);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbSK;
        private System.Windows.Forms.ComboBox cb_tenKH;
        private System.Windows.Forms.Button btAddKH;
        private System.Windows.Forms.TextBox txtmkh;
        private System.Windows.Forms.TextBox txttkh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.DataGridView tbAll;
        private System.Windows.Forms.Button btTTDK;
    }
}

