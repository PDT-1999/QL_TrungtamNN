namespace QL_TTNN
{
    partial class QL_LOP
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtmalp = new System.Windows.Forms.TextBox();
            this.txttenlp = new System.Windows.Forms.TextBox();
            this.txtgv = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.lblQuanLyPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(270, 106);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(208, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtmalp
            // 
            this.txtmalp.Location = new System.Drawing.Point(270, 170);
            this.txtmalp.Name = "txtmalp";
            this.txtmalp.Size = new System.Drawing.Size(208, 22);
            this.txtmalp.TabIndex = 2;
            // 
            // txttenlp
            // 
            this.txttenlp.Location = new System.Drawing.Point(270, 237);
            this.txttenlp.Name = "txttenlp";
            this.txttenlp.Size = new System.Drawing.Size(208, 22);
            this.txttenlp.TabIndex = 3;
            // 
            // txtgv
            // 
            this.txtgv.Location = new System.Drawing.Point(650, 172);
            this.txtgv.Name = "txtgv";
            this.txtgv.Size = new System.Drawing.Size(208, 22);
            this.txtgv.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(181, 109);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Khóa học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã giảng viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(968, 92);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 50);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(968, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 50);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(968, 237);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 50);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 206);
            this.panel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lớp Học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblQuanLyPhong);
            this.panel2.Controls.Add(this.txtmamon);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.txtmalp);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.txttenlp);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtgv);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 327);
            this.panel2.TabIndex = 15;
            // 
            // txtmamon
            // 
            this.txtmamon.Location = new System.Drawing.Point(650, 109);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(208, 22);
            this.txtmamon.TabIndex = 4;
            // 
            // lblQuanLyPhong
            // 
            this.lblQuanLyPhong.BackColor = System.Drawing.Color.Azure;
            this.lblQuanLyPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanLyPhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyPhong.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuanLyPhong.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyPhong.Name = "lblQuanLyPhong";
            this.lblQuanLyPhong.Size = new System.Drawing.Size(1222, 75);
            this.lblQuanLyPhong.TabIndex = 14;
            this.lblQuanLyPhong.Text = "THÔNG TIN LỚP HỌC";
            this.lblQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QL_LOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1222, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "QL_LOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_Lop";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtmalp;
        private System.Windows.Forms.TextBox txttenlp;
        private System.Windows.Forms.TextBox txtgv;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuanLyPhong;

    }
}

