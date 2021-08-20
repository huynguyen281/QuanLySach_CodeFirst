
namespace QLSach
{
    partial class ListSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSach));
            this.dgv_DSSach = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_Authors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Header = new System.Windows.Forms.Panel();
            this.pB_Minimize = new System.Windows.Forms.PictureBox();
            this.pB_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DSSach
            // 
            this.dgv_DSSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSach.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_DSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSach.Location = new System.Drawing.Point(17, 129);
            this.dgv_DSSach.Name = "dgv_DSSach";
            this.dgv_DSSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSSach.Size = new System.Drawing.Size(685, 360);
            this.dgv_DSSach.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(581, 495);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 29);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(455, 495);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(120, 29);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Sort);
            this.panel1.Controls.Add(this.cbb_Sort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbb_Authors);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_DSSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 561);
            this.panel1.TabIndex = 1;
            // 
            // btn_Sort
            // 
            this.btn_Sort.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sort.Location = new System.Drawing.Point(16, 495);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(120, 29);
            this.btn_Sort.TabIndex = 13;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Items.AddRange(new object[] {
            "Theo tên",
            "Theo NXB"});
            this.cbb_Sort.Location = new System.Drawing.Point(143, 495);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(152, 29);
            this.cbb_Sort.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search:";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(619, 94);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(82, 29);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(329, 94);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(278, 29);
            this.txt_Search.TabIndex = 6;
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(329, 495);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(120, 29);
            this.btn_Del.TabIndex = 11;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authors:";
            // 
            // cbb_Authors
            // 
            this.cbb_Authors.FormattingEnabled = true;
            this.cbb_Authors.Location = new System.Drawing.Point(17, 94);
            this.cbb_Authors.Name = "cbb_Authors";
            this.cbb_Authors.Size = new System.Drawing.Size(278, 29);
            this.cbb_Authors.TabIndex = 3;
            this.cbb_Authors.SelectedIndexChanged += new System.EventHandler(this.cbb_Authors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(192, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIST BOOKS IN DATABASE";
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
            this.pn_Header.Size = new System.Drawing.Size(720, 42);
            this.pn_Header.TabIndex = 0;
            this.pn_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown_1);
            // 
            // pB_Minimize
            // 
            this.pB_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pB_Minimize.Image")));
            this.pB_Minimize.Location = new System.Drawing.Point(638, 2);
            this.pB_Minimize.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pB_Minimize.Name = "pB_Minimize";
            this.pB_Minimize.Size = new System.Drawing.Size(36, 36);
            this.pB_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Minimize.TabIndex = 1;
            this.pB_Minimize.TabStop = false;
            this.pB_Minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // pB_Exit
            // 
            this.pB_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pB_Exit.Image")));
            this.pB_Exit.Location = new System.Drawing.Point(673, -3);
            this.pB_Exit.Name = "pB_Exit";
            this.pB_Exit.Size = new System.Drawing.Size(45, 45);
            this.pB_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Exit.TabIndex = 0;
            this.pB_Exit.TabStop = false;
            this.pB_Exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ListSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSSach;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.ComboBox cbb_Authors;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_Header;
        private System.Windows.Forms.PictureBox pB_Exit;
        private System.Windows.Forms.PictureBox pB_Minimize;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.ComboBox cbb_Sort;
    }
}

