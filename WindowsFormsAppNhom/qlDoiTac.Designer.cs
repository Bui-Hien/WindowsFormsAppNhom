//namespace WindowsFormsAppNhom
//{
//    partial class qlDoiTac
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.button1 = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(376, 127);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(98, 115);
//            this.button1.TabIndex = 0;
//            this.button1.Text = "button1";
//            this.button1.UseVisualStyleBackColor = true;
//            // 
//            // qlDoiTac
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Controls.Add(this.button1);
//            this.Name = "qlDoiTac";
//            this.Text = "qlDoiTac";
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Button button1;
//    }
//}
namespace WindowsFormsAppNhom
{
    partial class qlDoiTac
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbtendt = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.tbmadt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.tbmasp = new System.Windows.Forms.TextBox();
            this.tbtensp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
<<<<<<< HEAD
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
<<<<<<< HEAD
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(599, 363);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.SplitterWidth = 3;
=======
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Size = new System.Drawing.Size(1181, 450);
            this.splitContainer1.SplitterDistance = 182;
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
<<<<<<< HEAD
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
=======
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.tbtendt);
            this.splitContainer2.Panel1.Controls.Add(this.btThem);
            this.splitContainer2.Panel1.Controls.Add(this.btSua);
            this.splitContainer2.Panel1.Controls.Add(this.tbmadt);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.btThoat);
            this.splitContainer2.Panel2.Controls.Add(this.btXoa);
            this.splitContainer2.Panel2.Controls.Add(this.tbmasp);
            this.splitContainer2.Panel2.Controls.Add(this.tbtensp);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
<<<<<<< HEAD
            this.splitContainer2.Size = new System.Drawing.Size(599, 143);
            this.splitContainer2.SplitterDistance = 296;
            this.splitContainer2.SplitterWidth = 3;
=======
            this.splitContainer2.Size = new System.Drawing.Size(1181, 182);
            this.splitContainer2.SplitterDistance = 600;
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            this.splitContainer2.TabIndex = 0;
            // 
            // tbtendt
            // 
            this.tbtendt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.textBox2.Location = new System.Drawing.Point(67, 51);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 3;
=======
            this.tbtendt.Location = new System.Drawing.Point(89, 63);
            this.tbtendt.Name = "tbtendt";
            this.tbtendt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbtendt.Size = new System.Drawing.Size(469, 22);
            this.tbtendt.TabIndex = 2;
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            // 
            // btThem
            // 
<<<<<<< HEAD
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(67, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
=======
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btThem.ForeColor = System.Drawing.Color.Black;
            this.btThem.Location = new System.Drawing.Point(89, 117);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 45);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btSua.Location = new System.Drawing.Point(215, 95);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 37);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // tbmadt
            // 
            this.tbmadt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.textBox1.Location = new System.Drawing.Point(67, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 2;
=======
            this.tbmadt.Location = new System.Drawing.Point(89, 22);
            this.tbmadt.Name = "tbmadt";
            this.tbmadt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbmadt.Size = new System.Drawing.Size(469, 22);
            this.tbmadt.TabIndex = 1;
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đối tác ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đối tác ";
            // 
            // btThoat
            // 
<<<<<<< HEAD
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(149, 95);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.btThoat.Location = new System.Drawing.Point(243, 117);
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(56, 37);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXoa.Location = new System.Drawing.Point(51, 95);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(56, 37);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tbmasp
            // 
            this.tbmasp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.textBox3.Location = new System.Drawing.Point(96, 20);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 4;
=======
            this.tbmasp.Location = new System.Drawing.Point(128, 25);
            this.tbmasp.Name = "tbmasp";
            this.tbmasp.Size = new System.Drawing.Size(410, 22);
            this.tbmasp.TabIndex = 3;
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            // 
            // tbtensp
            // 
            this.tbtensp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.textBox4.Location = new System.Drawing.Point(96, 60);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 5;
=======
            this.tbtensp.Location = new System.Drawing.Point(128, 74);
            this.tbtensp.Name = "tbtensp";
            this.tbtensp.Size = new System.Drawing.Size(410, 22);
            this.tbtensp.TabIndex = 4;
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hàng hóa ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
<<<<<<< HEAD
            this.label4.Size = new System.Drawing.Size(78, 13);
=======
            this.label4.Size = new System.Drawing.Size(90, 16);
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên hàng hóa";
            // 
            // dgv
            // 
<<<<<<< HEAD
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 214);
            this.dataGridView1.TabIndex = 9;
=======
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1180, 262);
            this.dgv.TabIndex = 9;
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            // 
            // qlDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(600, 366);
=======
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1181, 450);
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "qlDoiTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.qlDoiTac_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbtendt;
        private System.Windows.Forms.TextBox tbmadt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmasp;
        private System.Windows.Forms.TextBox tbtensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btThoat;
    }
}