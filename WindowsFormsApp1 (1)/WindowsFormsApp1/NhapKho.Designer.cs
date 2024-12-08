namespace WindowsFormsApp1
{
    partial class NhapKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bkBTN = new System.Windows.Forms.RadioButton();
            this.rmitBtn = new System.Windows.Forms.RadioButton();
            this.tdtBtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bkBTN);
            this.groupBox1.Controls.Add(this.rmitBtn);
            this.groupBox1.Controls.Add(this.tdtBtn);
            this.groupBox1.Location = new System.Drawing.Point(18, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(240, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Địa Điểm";
            // 
            // bkBTN
            // 
            this.bkBTN.AutoSize = true;
            this.bkBTN.Location = new System.Drawing.Point(8, 94);
            this.bkBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bkBTN.Name = "bkBTN";
            this.bkBTN.Size = new System.Drawing.Size(173, 24);
            this.bkBTN.TabIndex = 1;
            this.bkBTN.TabStop = true;
            this.bkBTN.Text = "Đại Học Bách Khoa";
            this.bkBTN.UseVisualStyleBackColor = true;
            // 
            // rmitBtn
            // 
            this.rmitBtn.AutoSize = true;
            this.rmitBtn.Location = new System.Drawing.Point(8, 61);
            this.rmitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rmitBtn.Name = "rmitBtn";
            this.rmitBtn.Size = new System.Drawing.Size(134, 24);
            this.rmitBtn.TabIndex = 1;
            this.rmitBtn.TabStop = true;
            this.rmitBtn.Text = "Đại Học RMIT";
            this.rmitBtn.UseVisualStyleBackColor = true;
            // 
            // tdtBtn
            // 
            this.tdtBtn.AutoSize = true;
            this.tdtBtn.Location = new System.Drawing.Point(8, 28);
            this.tdtBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tdtBtn.Name = "tdtBtn";
            this.tdtBtn.Size = new System.Drawing.Size(204, 24);
            this.tdtBtn.TabIndex = 0;
            this.tdtBtn.TabStop = true;
            this.tdtBtn.Text = "Đại Học Tôn Đức Thắng";
            this.tdtBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Nhập Kho";
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(989, 330);
            this.dataGridView1.TabIndex = 5;
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
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "date";
            this.Column2.HeaderText = "Ngày Nhập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TongTien";
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Expire Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(668, 130);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 26);
            this.dateTimePicker2.TabIndex = 43;
            this.dateTimePicker2.Value = new System.DateTime(2024, 12, 13, 0, 0, 0, 0);
            // 
            // soLuongThuoc
            // 
            this.soLuongThuoc.Location = new System.Drawing.Point(668, 95);
            this.soLuongThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soLuongThuoc.Name = "soLuongThuoc";
            this.soLuongThuoc.Size = new System.Drawing.Size(86, 26);
            this.soLuongThuoc.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Số Lượng";
            // 
            // tenThuoc
            // 
            this.tenThuoc.Location = new System.Drawing.Point(666, 60);
            this.tenThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.Size = new System.Drawing.Size(345, 26);
            this.tenThuoc.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tên Thuốc";
            // 
            // maThuoc
            // 
            this.maThuoc.Location = new System.Drawing.Point(660, 19);
            this.maThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.Size = new System.Drawing.Size(138, 26);
            this.maThuoc.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mã Thuốc";
            // 
            // giaThuoc
            // 
            this.giaThuoc.Location = new System.Drawing.Point(668, 181);
            this.giaThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.giaThuoc.Name = "giaThuoc";
            this.giaThuoc.Size = new System.Drawing.Size(138, 26);
            this.giaThuoc.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(339, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 58);
            this.button1.TabIndex = 48;
            this.button1.Text = "Nhập Kho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(843, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 65);
            this.button2.TabIndex = 49;
            this.button2.Text = "Thêm vào kho tạm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thực Phẩm Chức Năng",
            "Giảm Đau Hạ Sốt",
            "Mắt Mũi Miệng"});
            this.comboBox1.Location = new System.Drawing.Point(818, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 28);
            this.comboBox1.TabIndex = 50;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 576);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhapKho";
            this.Text = "Thông Tin Nhập Kho";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bkBTN;
        private System.Windows.Forms.RadioButton rmitBtn;
        private System.Windows.Forms.RadioButton tdtBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}