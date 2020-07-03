namespace QLBV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RB_Nam = new System.Windows.Forms.RadioButton();
            this.RB_Nu = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLoaiDV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_BN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_BHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_DV_Kham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(144, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Bệnh Nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bệnh nhân";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(118, 51);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(112, 20);
            this.txtTenBN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số thẻ BHYT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(118, 79);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(112, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtBHYT
            // 
            this.txtBHYT.Location = new System.Drawing.Point(118, 107);
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.Size = new System.Drawing.Size(112, 20);
            this.txtBHYT.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giới tính";
            // 
            // RB_Nam
            // 
            this.RB_Nam.AutoSize = true;
            this.RB_Nam.Location = new System.Drawing.Point(389, 80);
            this.RB_Nam.Name = "RB_Nam";
            this.RB_Nam.Size = new System.Drawing.Size(47, 17);
            this.RB_Nam.TabIndex = 12;
            this.RB_Nam.TabStop = true;
            this.RB_Nam.Text = "Nam";
            this.RB_Nam.UseVisualStyleBackColor = true;
            // 
            // RB_Nu
            // 
            this.RB_Nu.AutoSize = true;
            this.RB_Nu.Location = new System.Drawing.Point(453, 79);
            this.RB_Nu.Name = "RB_Nu";
            this.RB_Nu.Size = new System.Drawing.Size(39, 17);
            this.RB_Nu.TabIndex = 13;
            this.RB_Nu.TabStop = true;
            this.RB_Nu.Text = "Nữ";
            this.RB_Nu.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Loại dịch vụ khám";
            // 
            // txtLoaiDV
            // 
            this.txtLoaiDV.Location = new System.Drawing.Point(393, 106);
            this.txtLoaiDV.Name = "txtLoaiDV";
            this.txtLoaiDV.Size = new System.Drawing.Size(112, 20);
            this.txtLoaiDV.TabIndex = 19;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 158);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 20);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(81, 158);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(64, 20);
            this.btnIn.TabIndex = 23;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dgv_Data
            // 
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.Ten_BN,
            this.Gioi_Tinh,
            this.Dia_Chi,
            this.Ngay_Sinh,
            this.So_BHYT,
            this.Loai_DV_Kham});
            this.dgv_Data.Location = new System.Drawing.Point(14, 184);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(517, 175);
            this.dgv_Data.TabIndex = 24;
            this.dgv_Data.SelectionChanged += new System.EventHandler(this.dgv_Data_SelectionChanged);
            // 
            // MaBN
            // 
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã bệnh nhân";
            this.MaBN.Name = "MaBN";
            // 
            // Ten_BN
            // 
            this.Ten_BN.DataPropertyName = "Ten_BN";
            this.Ten_BN.HeaderText = "Tên bệnh nhân";
            this.Ten_BN.Name = "Ten_BN";
            // 
            // Gioi_Tinh
            // 
            this.Gioi_Tinh.DataPropertyName = "Gioi_Tinh";
            this.Gioi_Tinh.HeaderText = "Giới Tính";
            this.Gioi_Tinh.Name = "Gioi_Tinh";
            // 
            // Dia_Chi
            // 
            this.Dia_Chi.DataPropertyName = "Dia_Chi";
            this.Dia_Chi.HeaderText = "Địa Chỉ";
            this.Dia_Chi.Name = "Dia_Chi";
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.DataPropertyName = "Ngay_Sinh";
            this.Ngay_Sinh.HeaderText = "Ngày Sinh";
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            // 
            // So_BHYT
            // 
            this.So_BHYT.DataPropertyName = "So_BHYT";
            this.So_BHYT.HeaderText = "Số BHYT";
            this.So_BHYT.Name = "So_BHYT";
            // 
            // Loai_DV_Kham
            // 
            this.Loai_DV_Kham.DataPropertyName = "Loai_DV_Kham";
            this.Loai_DV_Kham.HeaderText = "Dịch vụ khám";
            this.Loai_DV_Kham.Name = "Loai_DV_Kham";
            // 
            // dTPNgaySinh
            // 
            this.dTPNgaySinh.CustomFormat = "yyyy  -  MM  -  dd";
            this.dTPNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgaySinh.Location = new System.Drawing.Point(389, 49);
            this.dTPNgaySinh.Name = "dTPNgaySinh";
            this.dTPNgaySinh.Size = new System.Drawing.Size(116, 20);
            this.dTPNgaySinh.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 371);
            this.Controls.Add(this.dTPNgaySinh);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLoaiDV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RB_Nu);
            this.Controls.Add(this.RB_Nam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBHYT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản Lý Thông Tin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RB_Nam;
        private System.Windows.Forms.RadioButton RB_Nu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoaiDV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_BN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_BHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_DV_Kham;
        private System.Windows.Forms.DateTimePicker dTPNgaySinh;
    }
}

