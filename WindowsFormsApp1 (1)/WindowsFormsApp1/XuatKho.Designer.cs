namespace WindowsFormsApp1
{
    partial class XuatKho
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.soLuongThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maThuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.giaThuoc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bkBTN = new System.Windows.Forms.RadioButton();
            this.rmitBtn = new System.Windows.Forms.RadioButton();
            this.tdtBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thực Phẩm Chức Năng",
            "Giảm Đau Hạ Sốt",
            "Mắt Mũi Miệng"});
            this.comboBox1.Location = new System.Drawing.Point(720, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 68;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "soLuong";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "date";
            this.Column2.HeaderText = "Ngày Nhập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "location";
            this.Column1.HeaderText = "Địa Điểm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(742, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 52);
            this.button2.TabIndex = 67;
            this.button2.Text = "Thêm vào kho tạm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(294, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 46);
            this.button1.TabIndex = 66;
            this.button1.Text = "Xuất Kho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Expire Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(587, 114);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker2.TabIndex = 61;
            this.dateTimePicker2.Value = new System.DateTime(2024, 12, 13, 0, 0, 0, 0);
            // 
            // soLuongThuoc
            // 
            this.soLuongThuoc.Location = new System.Drawing.Point(587, 86);
            this.soLuongThuoc.Name = "soLuongThuoc";
            this.soLuongThuoc.Size = new System.Drawing.Size(77, 22);
            this.soLuongThuoc.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Số Lượng";
            // 
            // tenThuoc
            // 
            this.tenThuoc.Location = new System.Drawing.Point(585, 58);
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.Size = new System.Drawing.Size(307, 22);
            this.tenThuoc.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tên Thuốc";
            // 
            // maThuoc
            // 
            this.maThuoc.Location = new System.Drawing.Point(580, 25);
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.Size = new System.Drawing.Size(123, 22);
            this.maThuoc.TabIndex = 56;
            this.maThuoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maThuoc_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Mã Thuốc";
            // 
            // giaThuoc
            // 
            this.giaThuoc.Location = new System.Drawing.Point(587, 155);
            this.giaThuoc.Name = "giaThuoc";
            this.giaThuoc.Size = new System.Drawing.Size(123, 22);
            this.giaThuoc.TabIndex = 64;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(5, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(879, 264);
            this.dataGridView1.TabIndex = 54;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TongTien";
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ngày Xuất Kho";
            // 
            // bkBTN
            // 
            this.bkBTN.AutoSize = true;
            this.bkBTN.Location = new System.Drawing.Point(7, 75);
            this.bkBTN.Name = "bkBTN";
            this.bkBTN.Size = new System.Drawing.Size(144, 20);
            this.bkBTN.TabIndex = 1;
            this.bkBTN.TabStop = true;
            this.bkBTN.Text = "Đại Học Bách Khoa";
            this.bkBTN.UseVisualStyleBackColor = true;
            // 
            // rmitBtn
            // 
            this.rmitBtn.AutoSize = true;
            this.rmitBtn.Location = new System.Drawing.Point(7, 49);
            this.rmitBtn.Name = "rmitBtn";
            this.rmitBtn.Size = new System.Drawing.Size(112, 20);
            this.rmitBtn.TabIndex = 1;
            this.rmitBtn.TabStop = true;
            this.rmitBtn.Text = "Đại Học RMIT";
            this.rmitBtn.UseVisualStyleBackColor = true;
            // 
            // tdtBtn
            // 
            this.tdtBtn.AutoSize = true;
            this.tdtBtn.Location = new System.Drawing.Point(7, 22);
            this.tdtBtn.Name = "tdtBtn";
            this.tdtBtn.Size = new System.Drawing.Size(171, 20);
            this.tdtBtn.TabIndex = 0;
            this.tdtBtn.TabStop = true;
            this.tdtBtn.Text = "Đại Học Tôn Đức Thắng";
            this.tdtBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bkBTN);
            this.groupBox1.Controls.Add(this.rmitBtn);
            this.groupBox1.Controls.Add(this.tdtBtn);
            this.groupBox1.Location = new System.Drawing.Point(9, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 105);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Địa Điểm";
            // 
            // XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 480);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.soLuongThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenThuoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maThuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.giaThuoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XuatKho";
            this.Text = "Thông Tin Xuất Kho";
            this.Load += new System.EventHandler(this.XuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox soLuongThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox giaThuoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton bkBTN;
        private System.Windows.Forms.RadioButton rmitBtn;
        private System.Windows.Forms.RadioButton tdtBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}