
namespace TKB
{
    partial class ChitietTKB
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_quanlytkb = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlytkb)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Chi Tiết Thời Khóa Biều";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(845, 294);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(81, 29);
            this.btn_thoat.TabIndex = 27;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_quanlytkb
            // 
            this.dgv_quanlytkb.AllowUserToAddRows = false;
            this.dgv_quanlytkb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_quanlytkb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanlytkb.Location = new System.Drawing.Point(12, 53);
            this.dgv_quanlytkb.Name = "dgv_quanlytkb";
            this.dgv_quanlytkb.Size = new System.Drawing.Size(914, 203);
            this.dgv_quanlytkb.TabIndex = 25;
            // 
            // ChitietTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TKB.Properties.Resources.tkb;
            this.ClientSize = new System.Drawing.Size(938, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dgv_quanlytkb);
            this.Name = "ChitietTKB";
            this.Text = "ChitietTKB";
            this.Load += new System.EventHandler(this.ChitietTKB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlytkb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_quanlytkb;
    }
}