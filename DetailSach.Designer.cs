
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MS = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NXB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Con = new System.Windows.Forms.RadioButton();
            this.rb_Het = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_OK);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtp_NXB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_MS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 361);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // txt_MS
            // 
            this.txt_MS.Location = new System.Drawing.Point(105, 39);
            this.txt_MS.Name = "txt_MS";
            this.txt_MS.Size = new System.Drawing.Size(200, 20);
            this.txt_MS.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(105, 74);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NXB";
            // 
            // dtp_NXB
            // 
            this.dtp_NXB.Location = new System.Drawing.Point(105, 122);
            this.dtp_NXB.Name = "dtp_NXB";
            this.dtp_NXB.Size = new System.Drawing.Size(200, 20);
            this.dtp_NXB.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Het);
            this.groupBox1.Controls.Add(this.rb_Con);
            this.groupBox1.Location = new System.Drawing.Point(31, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình trạng";
            // 
            // rb_Con
            // 
            this.rb_Con.AutoSize = true;
            this.rb_Con.Location = new System.Drawing.Point(7, 36);
            this.rb_Con.Name = "rb_Con";
            this.rb_Con.Size = new System.Drawing.Size(71, 17);
            this.rb_Con.TabIndex = 0;
            this.rb_Con.TabStop = true;
            this.rb_Con.Text = "Còn hàng";
            this.rb_Con.UseVisualStyleBackColor = true;
            // 
            // rb_Het
            // 
            this.rb_Het.AutoSize = true;
            this.rb_Het.Location = new System.Drawing.Point(118, 36);
            this.rb_Het.Name = "rb_Het";
            this.rb_Het.Size = new System.Drawing.Size(69, 17);
            this.rb_Het.TabIndex = 1;
            this.rb_Het.TabStop = true;
            this.rb_Het.Text = "Hết hàng";
            this.rb_Het.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(229, 312);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "OKE";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(143, 312);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // DetailSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 428);
            this.Controls.Add(this.panel1);
            this.Name = "DetailSach";
            this.Text = "DetailSach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}