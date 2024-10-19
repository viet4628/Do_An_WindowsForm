@ -0,0 + 1,767 @@
﻿namespace Do_An_WindowsForm.GiaoDien
{
    partial class TinhTienTroo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhTienTroo));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGiuXe = new System.Windows.Forms.CheckBox();
            this.cbRac = new System.Windows.Forms.CheckBox();
            this.cnInternet = new System.Windows.Forms.CheckBox();
            this.cbNuoc = new System.Windows.Forms.CheckBox();
            this.cbDien = new System.Windows.Forms.CheckBox();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.txtTienMang = new System.Windows.Forms.TextBox();
            this.txtTienNha = new System.Windows.Forms.TextBox();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtID_Khach = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID_Phong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeOffsetEdit2 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.ngayDong = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.ngayThu = new System.Windows.Forms.DateTimePicker();
            this.cmbCheckPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ngayThue = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienRac = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSoDien = new System.Windows.Forms.TextBox();
            this.txtNgayO = new System.Windows.Forms.TextBox();
            this.txtSoNuoc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbGiuXe);
            this.groupBox3.Controls.Add(this.txtSoNuoc);
            this.groupBox3.Controls.Add(this.txtTienNuoc);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.txtTienRac);
            this.groupBox3.Controls.Add(this.txtTienMang);
            this.groupBox3.Controls.Add(this.cbRac);
            this.groupBox3.Controls.Add(this.txtNgayO);
            this.groupBox3.Controls.Add(this.txtTienNha);
            this.groupBox3.Controls.Add(this.txtSoDien);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTienDien);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cnInternet);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cbNuoc);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cbDien);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(677, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 310);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dịch Vụ Sử Dụng";
            // 
            // cbGiuXe
            // 
            this.cbGiuXe.AutoSize = true;
            this.cbGiuXe.Location = new System.Drawing.Point(16, 159);
            this.cbGiuXe.Name = "cbGiuXe";
            this.cbGiuXe.Size = new System.Drawing.Size(70, 22);
            this.cbGiuXe.TabIndex = 7;
            this.cbGiuXe.Text = "Giữ Xe";
            this.cbGiuXe.UseVisualStyleBackColor = true;
            // 
            // cbRac
            // 
            this.cbRac.AutoSize = true;
            this.cbRac.Location = new System.Drawing.Point(16, 131);
            this.cbRac.Name = "cbRac";
            this.cbRac.Size = new System.Drawing.Size(51, 22);
            this.cbRac.TabIndex = 7;
            this.cbRac.Text = "Rác";
            this.cbRac.UseVisualStyleBackColor = true;
            // 
            // cnInternet
            // 
            this.cnInternet.AutoSize = true;
            this.cnInternet.Location = new System.Drawing.Point(16, 103);
            this.cnInternet.Name = "cnInternet";
            this.cnInternet.Size = new System.Drawing.Size(80, 22);
            this.cnInternet.TabIndex = 7;
            this.cnInternet.Text = "Internet";
            this.cnInternet.UseVisualStyleBackColor = true;
            // 
            // cbNuoc
            // 
            this.cbNuoc.AutoSize = true;
            this.cbNuoc.Location = new System.Drawing.Point(16, 75);
            this.cbNuoc.Name = "cbNuoc";
            this.cbNuoc.Size = new System.Drawing.Size(61, 22);
            this.cbNuoc.TabIndex = 7;
            this.cbNuoc.Text = "Nước";
            this.cbNuoc.UseVisualStyleBackColor = true;
            // 
            // cbDien
            // 
            this.cbDien.AutoSize = true;
            this.cbDien.Location = new System.Drawing.Point(16, 47);
            this.cbDien.Name = "cbDien";
            this.cbDien.Size = new System.Drawing.Size(60, 22);
            this.cbDien.TabIndex = 7;
            this.cbDien.Text = "Điện ";
            this.cbDien.UseVisualStyleBackColor = true;
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.Location = new System.Drawing.Point(405, 116);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.Size = new System.Drawing.Size(127, 26);
            this.txtTienNuoc.TabIndex = 3;
            // 
            // txtTienMang
            // 
            this.txtTienMang.Location = new System.Drawing.Point(405, 148);
            this.txtTienMang.Name = "txtTienMang";
            this.txtTienMang.Size = new System.Drawing.Size(127, 26);
            this.txtTienMang.TabIndex = 3;
            // 
            // txtTienNha
            // 
            this.txtTienNha.Location = new System.Drawing.Point(405, 48);
            this.txtTienNha.Name = "txtTienNha";
            this.txtTienNha.Size = new System.Drawing.Size(127, 26);
            this.txtTienNha.TabIndex = 3;
            // 
            // txtTienDien
            // 
            this.txtTienDien.Location = new System.Drawing.Point(405, 80);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.Size = new System.Drawing.Size(127, 26);
            this.txtTienDien.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(305, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 18);
            this.label19.TabIndex = 2;
            this.label19.Text = "Tiền Internet";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(329, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 18);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tiền Điện";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(323, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 18);
            this.label17.TabIndex = 2;
            this.label17.Text = "Tiền Nước";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(332, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 18);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tiền Nhà";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Controls.Add(this.txtNgheNghiep);
            this.groupBox2.Controls.Add(this.txtID_Khach);
            this.groupBox2.Controls.Add(this.txtQueQuan);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(367, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 310);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách Thuê";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(117, 124);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(150, 26);
            this.txtCCCD.TabIndex = 3;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(117, 168);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(150, 26);
            this.txtNgheNghiep.TabIndex = 3;
            // 
            // txtID_Khach
            // 
            this.txtID_Khach.Location = new System.Drawing.Point(117, 31);
            this.txtID_Khach.Name = "txtID_Khach";
            this.txtID_Khach.Size = new System.Drawing.Size(150, 26);
            this.txtID_Khach.TabIndex = 3;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(117, 215);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(150, 26);
            this.txtQueQuan.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(117, 75);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(150, 26);
            this.txtHoTen.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nghề Nghiệp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Quê Quán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên Khách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "CCCD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã Khách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTinhTien);
            this.groupBox1.Controls.Add(this.txtID_Phong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ngayThue);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 310);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng Thuê";
            // 
            // txtID_Phong
            // 
            this.txtID_Phong.Location = new System.Drawing.Point(106, 58);
            this.txtID_Phong.Name = "txtID_Phong";
            this.txtID_Phong.Size = new System.Drawing.Size(131, 26);
            this.txtID_Phong.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày Thuê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã Phòng";
            // 
            // dateTimeOffsetEdit2
            // 
            this.dateTimeOffsetEdit2.EditValue = null;
            this.dateTimeOffsetEdit2.Location = new System.Drawing.Point(155, 261);
            this.dateTimeOffsetEdit2.Name = "dateTimeOffsetEdit2";
            this.dateTimeOffsetEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeOffsetEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateTimeOffsetEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOffsetEdit2.Size = new System.Drawing.Size(200, 24);
            this.dateTimeOffsetEdit2.TabIndex = 30;
            // 
            // ngayDong
            // 
            this.ngayDong.EditValue = null;
            this.ngayDong.Location = new System.Drawing.Point(516, 88);
            this.ngayDong.Name = "ngayDong";
            this.ngayDong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayDong.Properties.Appearance.Options.UseFont = true;
            this.ngayDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDong.Size = new System.Drawing.Size(200, 24);
            this.ngayDong.TabIndex = 31;
            // 
            // ngayThu
            // 
            this.ngayThu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayThu.Location = new System.Drawing.Point(875, 86);
            this.ngayThu.Name = "ngayThu";
            this.ngayThu.Size = new System.Drawing.Size(200, 26);
            this.ngayThu.TabIndex = 29;
            // 
            // cmbCheckPhong
            // 
            this.cmbCheckPhong.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCheckPhong.FormattingEnabled = true;
            this.cmbCheckPhong.Location = new System.Drawing.Point(127, 81);
            this.cmbCheckPhong.Name = "cmbCheckPhong";
            this.cmbCheckPhong.Size = new System.Drawing.Size(170, 26);
            this.cmbCheckPhong.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(796, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ngày thu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày bắt đầu đóng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Chọn Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 45);
            this.label2.TabIndex = 24;
            this.label2.Text = "TÍNH TIỀN TRỌ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 23;
            // 
            // ngayThue
            // 
            this.ngayThue.EditValue = null;
            this.ngayThue.Location = new System.Drawing.Point(106, 100);
            this.ngayThue.Name = "ngayThue";
            this.ngayThue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayThue.Properties.Appearance.Options.UseFont = true;
            this.ngayThue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayThue.Size = new System.Drawing.Size(131, 20);
            this.ngayThue.TabIndex = 31;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTinhTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhTien.Image")));
            this.btnTinhTien.Location = new System.Drawing.Point(88, 193);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(149, 54);
            this.btnTinhTien.TabIndex = 32;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTinhTien.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tiền Rác";
            // 
            // txtTienRac
            // 
            this.txtTienRac.Location = new System.Drawing.Point(405, 185);
            this.txtTienRac.Name = "txtTienRac";
            this.txtTienRac.Size = new System.Drawing.Size(127, 26);
            this.txtTienRac.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(246, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tổng Tiền Phải Trả";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(386, 241);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(146, 26);
            this.txtTongTien.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(132, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "Số ngày ở";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(115, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 18);
            this.label20.TabIndex = 2;
            this.label20.Text = "Số khối nước";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(136, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 18);
            this.label21.TabIndex = 2;
            this.label21.Text = "Số kí điện";
            // 
            // txtSoDien
            // 
            this.txtSoDien.Location = new System.Drawing.Point(215, 80);
            this.txtSoDien.Name = "txtSoDien";
            this.txtSoDien.Size = new System.Drawing.Size(81, 26);
            this.txtSoDien.TabIndex = 3;
            // 
            // txtNgayO
            // 
            this.txtNgayO.Location = new System.Drawing.Point(215, 48);
            this.txtNgayO.Name = "txtNgayO";
            this.txtNgayO.Size = new System.Drawing.Size(81, 26);
            this.txtNgayO.TabIndex = 3;
            // 
            // txtSoNuoc
            // 
            this.txtSoNuoc.Location = new System.Drawing.Point(215, 113);
            this.txtSoNuoc.Name = "txtSoNuoc";
            this.txtSoNuoc.Size = new System.Drawing.Size(81, 26);
            this.txtSoNuoc.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column11,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(42, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1196, 278);
            this.dataGridView1.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Khách";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Họ Tên";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Tiền nhà";
            this.Column11.Name = "Column11";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tiền Điện";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tiền Nước";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tiền Internet";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tiền rác";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tiền Giữ Xe";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tổng Tiền";
            this.Column10.Name = "Column10";
            // 
            // TinhTienTroo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 771);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimeOffsetEdit2);
            this.Controls.Add(this.ngayDong);
            this.Controls.Add(this.ngayThu);
            this.Controls.Add(this.cmbCheckPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TinhTienTroo.IconOptions.SvgImage")));
            this.Name = "TinhTienTroo";
            this.Text = "Tính Tiền Trọ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbGiuXe;
        private System.Windows.Forms.CheckBox cbRac;
        private System.Windows.Forms.CheckBox cnInternet;
        private System.Windows.Forms.CheckBox cbNuoc;
        private System.Windows.Forms.CheckBox cbDien;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.TextBox txtTienMang;
        private System.Windows.Forms.TextBox txtTienNha;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtID_Khach;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID_Phong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeOffsetEdit2;
        private DevExpress.XtraEditors.DateTimeOffsetEdit ngayDong;
        private System.Windows.Forms.DateTimePicker ngayThu;
        private System.Windows.Forms.ComboBox cmbCheckPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTien;
        private DevExpress.XtraEditors.DateTimeOffsetEdit ngayThue;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienRac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoNuoc;
        private System.Windows.Forms.TextBox txtNgayO;
        private System.Windows.Forms.TextBox txtSoDien;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}