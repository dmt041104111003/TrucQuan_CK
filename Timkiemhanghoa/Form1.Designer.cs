namespace Timkiemhanghoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMahang = new System.Windows.Forms.TextBox();
            this.tbTu = new System.Windows.Forms.TextBox();
            this.tbTenhang = new System.Windows.Forms.TextBox();
            this.tbDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbChatlieu = new System.Windows.Forms.ComboBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btExcel = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM HÀNG HOÁ";
            // 
            // tbMahang
            // 
            this.tbMahang.Location = new System.Drawing.Point(187, 120);
            this.tbMahang.Name = "tbMahang";
            this.tbMahang.Size = new System.Drawing.Size(291, 22);
            this.tbMahang.TabIndex = 1;
            this.tbMahang.Enter += new System.EventHandler(this.tbMahang_Enter);
            this.tbMahang.Leave += new System.EventHandler(this.tbMahang_Leave);
            // 
            // tbTu
            // 
            this.tbTu.Location = new System.Drawing.Point(225, 163);
            this.tbTu.Name = "tbTu";
            this.tbTu.Size = new System.Drawing.Size(100, 22);
            this.tbTu.TabIndex = 2;
            this.tbTu.Enter += new System.EventHandler(this.tbTu_Enter);
            this.tbTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTu_KeyPress);
            this.tbTu.Leave += new System.EventHandler(this.tbTu_Leave);
            // 
            // tbTenhang
            // 
            this.tbTenhang.Location = new System.Drawing.Point(581, 120);
            this.tbTenhang.Name = "tbTenhang";
            this.tbTenhang.Size = new System.Drawing.Size(116, 22);
            this.tbTenhang.TabIndex = 4;
            this.tbTenhang.Enter += new System.EventHandler(this.tbTenhang_Enter);
            this.tbTenhang.Leave += new System.EventHandler(this.tbTenhang_Leave);
            // 
            // tbDen
            // 
            this.tbDen.Location = new System.Drawing.Point(378, 163);
            this.tbDen.Name = "tbDen";
            this.tbDen.Size = new System.Drawing.Size(100, 22);
            this.tbDen.TabIndex = 5;
            this.tbDen.Enter += new System.EventHandler(this.tbDen_Enter);
            this.tbDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDen_KeyPress);
            this.tbDen.Leave += new System.EventHandler(this.tbDen_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chất liệu";
            // 
            // cbChatlieu
            // 
            this.cbChatlieu.FormattingEnabled = true;
            this.cbChatlieu.Location = new System.Drawing.Point(581, 166);
            this.cbChatlieu.Name = "cbChatlieu";
            this.cbChatlieu.Size = new System.Drawing.Size(116, 24);
            this.cbChatlieu.TabIndex = 12;
            this.cbChatlieu.SelectedIndexChanged += new System.EventHandler(this.cbChatlieu_SelectedIndexChanged);
            this.cbChatlieu.Enter += new System.EventHandler(this.cbChatlieu_Enter);
            this.cbChatlieu.Leave += new System.EventHandler(this.cbChatlieu_Leave);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(110, 208);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(78, 37);
            this.btTimkiem.TabIndex = 13;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(213, 208);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(78, 37);
            this.btExcel.TabIndex = 14;
            this.btExcel.Text = "In ra excel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(311, 208);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(78, 37);
            this.btThoat.TabIndex = 15;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(110, 261);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(587, 150);
            this.data.TabIndex = 16;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.cbChatlieu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDen);
            this.Controls.Add(this.tbTenhang);
            this.Controls.Add(this.tbTu);
            this.Controls.Add(this.tbMahang);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMahang;
        private System.Windows.Forms.TextBox tbTu;
        private System.Windows.Forms.TextBox tbTenhang;
        private System.Windows.Forms.TextBox tbDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbChatlieu;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView data;
    }
}

