
namespace QLSach
{
    partial class DetailSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailSach));
            this.pn_InfoDetail = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_Authors = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Het = new System.Windows.Forms.RadioButton();
            this.rb_Con = new System.Windows.Forms.RadioButton();
            this.dtp_NXB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Header = new System.Windows.Forms.Panel();
            this.pB_Minimize = new System.Windows.Forms.PictureBox();
            this.pB_Exit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_InfoDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pn_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_InfoDetail
            // 
            this.pn_InfoDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_InfoDetail.Controls.Add(this.label5);
            this.pn_InfoDetail.Controls.Add(this.label4);
            this.pn_InfoDetail.Controls.Add(this.cbb_Authors);
            this.pn_InfoDetail.Controls.Add(this.btn_Cancel);
            this.pn_InfoDetail.Controls.Add(this.btn_OK);
            this.pn_InfoDetail.Controls.Add(this.groupBox1);
            this.pn_InfoDetail.Controls.Add(this.dtp_NXB);
            this.pn_InfoDetail.Controls.Add(this.label3);
            this.pn_InfoDetail.Controls.Add(this.txt_Name);
            this.pn_InfoDetail.Controls.Add(this.label2);
            this.pn_InfoDetail.Controls.Add(this.txt_MS);
            this.pn_InfoDetail.Controls.Add(this.label1);
            this.pn_InfoDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_InfoDetail.Location = new System.Drawing.Point(0, 35);
            this.pn_InfoDetail.Name = "pn_InfoDetail";
            this.pn_InfoDetail.Size = new System.Drawing.Size(490, 449);
            this.pn_InfoDetail.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(24, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tác giả";
            // 
            // cbb_Authors
            // 
            this.cbb_Authors.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbb_Authors.FormattingEnabled = true;
            this.cbb_Authors.Location = new System.Drawing.Point(117, 224);
            this.cbb_Authors.Name = "cbb_Authors";
            this.cbb_Authors.Size = new System.Drawing.Size(324, 29);
            this.cbb_Authors.TabIndex = 6;
            this.cbb_Authors.Text = "Chọn tác giả";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(239, 377);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(98, 29);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btn_OK.Location = new System.Drawing.Point(343, 377);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(98, 29);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OKE";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Het);
            this.groupBox1.Controls.Add(this.rb_Con);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.groupBox1.Location = new System.Drawing.Point(27, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình trạng";
            // 
            // rb_Het
            // 
            this.rb_Het.AutoSize = true;
            this.rb_Het.Location = new System.Drawing.Point(148, 36);
            this.rb_Het.Name = "rb_Het";
            this.rb_Het.Size = new System.Drawing.Size(99, 25);
            this.rb_Het.TabIndex = 1;
            this.rb_Het.TabStop = true;
            this.rb_Het.Text = "Hết hàng";
            this.rb_Het.UseVisualStyleBackColor = true;
            // 
            // rb_Con
            // 
            this.rb_Con.AutoSize = true;
            this.rb_Con.Location = new System.Drawing.Point(7, 36);
            this.rb_Con.Name = "rb_Con";
            this.rb_Con.Size = new System.Drawing.Size(103, 25);
            this.rb_Con.TabIndex = 0;
            this.rb_Con.TabStop = true;
            this.rb_Con.Text = "Còn hàng";
            this.rb_Con.UseVisualStyleBackColor = true;
            // 
            // dtp_NXB
            // 
            this.dtp_NXB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtp_NXB.Location = new System.Drawing.Point(117, 172);
            this.dtp_NXB.Name = "dtp_NXB";
            this.dtp_NXB.Size = new System.Drawing.Size(324, 29);
            this.dtp_NXB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày XB";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_Name.Location = new System.Drawing.Point(117, 124);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(324, 29);
            this.txt_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // txt_MS
            // 
            this.txt_MS.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_MS.Location = new System.Drawing.Point(117, 77);
            this.txt_MS.Name = "txt_MS";
            this.txt_MS.Size = new System.Drawing.Size(324, 29);
            this.txt_MS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // pn_Header
            // 
            this.pn_Header.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pn_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Header.Controls.Add(this.pB_Minimize);
            this.pn_Header.Controls.Add(this.pB_Exit);
            this.pn_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Header.Location = new System.Drawing.Point(0, 0);
            this.pn_Header.Name = "pn_Header";
            this.pn_Header.Size = new System.Drawing.Size(490, 35);
            this.pn_Header.TabIndex = 1;
            this.pn_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown_1);
            // 
            // pB_Minimize
            // 
            this.pB_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pB_Minimize.Image")));
            this.pB_Minimize.Location = new System.Drawing.Point(430, 7);
            this.pB_Minimize.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pB_Minimize.Name = "pB_Minimize";
            this.pB_Minimize.Size = new System.Drawing.Size(24, 24);
            this.pB_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Minimize.TabIndex = 1;
            this.pB_Minimize.TabStop = false;
            this.pB_Minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // pB_Exit
            // 
            this.pB_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pB_Exit.Image")));
            this.pB_Exit.Location = new System.Drawing.Point(455, 3);
            this.pB_Exit.Name = "pB_Exit";
            this.pB_Exit.Size = new System.Drawing.Size(30, 30);
            this.pB_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Exit.TabIndex = 0;
            this.pB_Exit.TabStop = false;
            this.pB_Exit.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(129, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "INFO DETAIL";
            // 
            // DetailSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 484);
            this.Controls.Add(this.pn_InfoDetail);
            this.Controls.Add(this.pn_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailSach";
            this.Text = "DetailSach";
            this.Load += new System.EventHandler(this.DetailSach_Load);
            this.pn_InfoDetail.ResumeLayout(false);
            this.pn_InfoDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_InfoDetail;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Het;
        private System.Windows.Forms.RadioButton rb_Con;
        private System.Windows.Forms.DateTimePicker dtp_NXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_Authors;
        private System.Windows.Forms.Panel pn_Header;
        private System.Windows.Forms.PictureBox pB_Minimize;
        private System.Windows.Forms.PictureBox pB_Exit;
        private System.Windows.Forms.Label label5;
    }
}