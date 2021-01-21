
namespace TKB
{
    partial class QL_MonHoc
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
            this.dgv_quanlymonhoc = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_sotiet = new System.Windows.Forms.TextBox();
            this.txt_tenmonhoc = new System.Windows.Forms.TextBox();
            this.txt_mamonhoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_xóa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlymonhoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_quanlymonhoc
            // 
            this.dgv_quanlymonhoc.AllowUserToAddRows = false;
            this.dgv_quanlymonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_quanlymonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanlymonhoc.Location = new System.Drawing.Point(15, 189);
            this.dgv_quanlymonhoc.Name = "dgv_quanlymonhoc";
            this.dgv_quanlymonhoc.Size = new System.Drawing.Size(776, 177);
            this.dgv_quanlymonhoc.TabIndex = 25;
            this.dgv_quanlymonhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_quanlymonhoc_CellContentClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(706, 154);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(81, 29);
            this.btn_thoat.TabIndex = 27;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_sotiet
            // 
            this.txt_sotiet.Location = new System.Drawing.Point(537, 15);
            this.txt_sotiet.Name = "txt_sotiet";
            this.txt_sotiet.Size = new System.Drawing.Size(167, 26);
            this.txt_sotiet.TabIndex = 1;
            // 
            // txt_tenmonhoc
            // 
            this.txt_tenmonhoc.Location = new System.Drawing.Point(186, 51);
            this.txt_tenmonhoc.Name = "txt_tenmonhoc";
            this.txt_tenmonhoc.Size = new System.Drawing.Size(167, 26);
            this.txt_tenmonhoc.TabIndex = 1;
            // 
            // txt_mamonhoc
            // 
            this.txt_mamonhoc.Location = new System.Drawing.Point(186, 15);
            this.txt_mamonhoc.Name = "txt_mamonhoc";
            this.txt_mamonhoc.Size = new System.Drawing.Size(167, 26);
            this.txt_mamonhoc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Môn Học";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txt_sotiet);
            this.groupBox1.Controls.Add(this.txt_tenmonhoc);
            this.groupBox1.Controls.Add(this.txt_mamonhoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 96);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Môn Học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(443, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Tiết";
            // 
            // btn_xóa
            // 
            this.btn_xóa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xóa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xóa.Location = new System.Drawing.Point(523, 154);
            this.btn_xóa.Name = "btn_xóa";
            this.btn_xóa.Size = new System.Drawing.Size(81, 29);
            this.btn_xóa.TabIndex = 28;
            this.btn_xóa.Text = "Xóa";
            this.btn_xóa.UseVisualStyleBackColor = true;
            this.btn_xóa.Click += new System.EventHandler(this.btn_xóa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(425, 154);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 29);
            this.btn_them.TabIndex = 29;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Quản Lý Môn Học";
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(619, 154);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 29);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // QL_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TKB.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_quanlymonhoc);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xóa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_sua);
            this.Name = "QL_MonHoc";
            this.Text = "QL_MonHoc";
            this.Load += new System.EventHandler(this.QL_MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlymonhoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_quanlymonhoc;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_sotiet;
        private System.Windows.Forms.TextBox txt_tenmonhoc;
        private System.Windows.Forms.TextBox txt_mamonhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_xóa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sua;
    }
}