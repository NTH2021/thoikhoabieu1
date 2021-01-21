
namespace TKB
{
    partial class QL_GiangDay
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
            this.dgv_quanlygiangvien = new System.Windows.Forms.DataGridView();
            this.txt_mamonhoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.txt_magd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_kt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_xóa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_quanlygiaovien = new System.Windows.Forms.DataGridView();
            this.dgv_quanlylop = new System.Windows.Forms.DataGridView();
            this.dgv_quanlymon = new System.Windows.Forms.DataGridView();
            this.btn_chitiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlygiangvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlygiaovien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlylop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlymon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_quanlygiangvien
            // 
            this.dgv_quanlygiangvien.AllowUserToAddRows = false;
            this.dgv_quanlygiangvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_quanlygiangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanlygiangvien.Location = new System.Drawing.Point(12, 40);
            this.dgv_quanlygiangvien.Name = "dgv_quanlygiangvien";
            this.dgv_quanlygiangvien.Size = new System.Drawing.Size(400, 177);
            this.dgv_quanlygiangvien.TabIndex = 18;
            this.dgv_quanlygiangvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_quanlygiangvien_CellContentClick);
            // 
            // txt_mamonhoc
            // 
            this.txt_mamonhoc.Location = new System.Drawing.Point(537, 52);
            this.txt_mamonhoc.Name = "txt_mamonhoc";
            this.txt_mamonhoc.Size = new System.Drawing.Size(167, 26);
            this.txt_mamonhoc.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(443, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã Môn";
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(537, 15);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(167, 26);
            this.txt_malop.TabIndex = 1;
            // 
            // txt_magv
            // 
            this.txt_magv.Location = new System.Drawing.Point(186, 51);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(167, 26);
            this.txt_magv.TabIndex = 1;
            // 
            // txt_magd
            // 
            this.txt_magd.Location = new System.Drawing.Point(186, 15);
            this.txt_magd.Name = "txt_magd";
            this.txt_magd.Size = new System.Drawing.Size(167, 26);
            this.txt_magd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Giảng Dạy";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txt_kt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_bd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_mamonhoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.txt_magv);
            this.groupBox1.Controls.Add(this.txt_magd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 129);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý Giảng Dạy";
            // 
            // txt_kt
            // 
            this.txt_kt.Location = new System.Drawing.Point(537, 84);
            this.txt_kt.Name = "txt_kt";
            this.txt_kt.Size = new System.Drawing.Size(167, 26);
            this.txt_kt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(389, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thời Gian Kết Thúc";
            // 
            // txt_bd
            // 
            this.txt_bd.Location = new System.Drawing.Point(186, 83);
            this.txt_bd.Name = "txt_bd";
            this.txt_bd.Size = new System.Drawing.Size(167, 26);
            this.txt_bd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thời Gian Bắt Đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(443, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Lớp";
            // 
            // btn_xóa
            // 
            this.btn_xóa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xóa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xóa.Location = new System.Drawing.Point(557, 358);
            this.btn_xóa.Name = "btn_xóa";
            this.btn_xóa.Size = new System.Drawing.Size(81, 29);
            this.btn_xóa.TabIndex = 21;
            this.btn_xóa.Text = "Xóa";
            this.btn_xóa.UseVisualStyleBackColor = true;
            this.btn_xóa.Click += new System.EventHandler(this.btn_xóa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(459, 358);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 29);
            this.btn_them.TabIndex = 22;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quản Lý Giảng Dạy";
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(644, 358);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 29);
            this.btn_sua.TabIndex = 23;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(731, 358);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(81, 29);
            this.btn_thoat.TabIndex = 20;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_quanlygiaovien
            // 
            this.dgv_quanlygiaovien.AllowUserToAddRows = false;
            this.dgv_quanlygiaovien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_quanlygiaovien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanlygiaovien.Location = new System.Drawing.Point(418, 40);
            this.dgv_quanlygiaovien.Name = "dgv_quanlygiaovien";
            this.dgv_quanlygiaovien.Size = new System.Drawing.Size(394, 177);
            this.dgv_quanlygiaovien.TabIndex = 18;
            // 
            // dgv_quanlylop
            // 
            this.dgv_quanlylop.AllowUserToAddRows = false;
            this.dgv_quanlylop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_quanlylop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanlylop.Location = new System.Drawing.Point(12, 358);
            this.dgv_quanlylop.Name = "dgv_quanlylop";
            this.dgv_quanlylop.Size = new System.Drawing.Size(180, 164);
            this.dgv_quanlylop.TabIndex = 18;
            // 
            // dgv_quanlymon
            // 
            this.dgv_quanlymon.AllowUserToAddRows = false;
            this.dgv_quanlymon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_quanlymon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanlymon.Location = new System.Drawing.Point(198, 358);
            this.dgv_quanlymon.Name = "dgv_quanlymon";
            this.dgv_quanlymon.Size = new System.Drawing.Size(180, 164);
            this.dgv_quanlymon.TabIndex = 18;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.Location = new System.Drawing.Point(731, 402);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(75, 23);
            this.btn_chitiet.TabIndex = 24;
            this.btn_chitiet.Text = "Chi Tiết";
            this.btn_chitiet.UseVisualStyleBackColor = true;
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // QL_GiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TKB.Properties.Resources.teacher;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 532);
            this.Controls.Add(this.btn_chitiet);
            this.Controls.Add(this.dgv_quanlymon);
            this.Controls.Add(this.dgv_quanlylop);
            this.Controls.Add(this.dgv_quanlygiaovien);
            this.Controls.Add(this.dgv_quanlygiangvien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xóa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_thoat);
            this.Name = "QL_GiangDay";
            this.Text = "QL_GiangDay";
            this.Load += new System.EventHandler(this.QL_GiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlygiangvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlygiaovien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlylop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlymon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_quanlygiangvien;
        private System.Windows.Forms.TextBox txt_mamonhoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.TextBox txt_magd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_xóa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_kt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_quanlygiaovien;
        private System.Windows.Forms.DataGridView dgv_quanlylop;
        private System.Windows.Forms.DataGridView dgv_quanlymon;
        private System.Windows.Forms.Button btn_chitiet;
    }
}