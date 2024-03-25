namespace WindowsFormsApp2
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmbDienLanh = new Guna.UI.WinForms.GunaComboBox();
            this.cmbDienMay = new Guna.UI.WinForms.GunaComboBox();
            this.cmbXayDungKienTruc = new Guna.UI.WinForms.GunaComboBox();
            this.cmbDienTuGiaDung = new Guna.UI.WinForms.GunaComboBox();
            this.cmbHeThongnuoc = new Guna.UI.WinForms.GunaComboBox();
            this.cmbThongNghet = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cmbDienLanh
            // 
            this.cmbDienLanh.BackColor = System.Drawing.Color.Transparent;
            this.cmbDienLanh.BaseColor = System.Drawing.Color.White;
            this.cmbDienLanh.BorderColor = System.Drawing.Color.Silver;
            this.cmbDienLanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDienLanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDienLanh.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDienLanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDienLanh.ForeColor = System.Drawing.Color.Black;
            this.cmbDienLanh.FormattingEnabled = true;
            this.cmbDienLanh.Items.AddRange(new object[] {
            "điều hòa",
            "bình nóng lạnh",
            "máy tắm nước nóng",
            "tủ lạnh",
            "máy giặt"});
            this.cmbDienLanh.Location = new System.Drawing.Point(166, 26);
            this.cmbDienLanh.Name = "cmbDienLanh";
            this.cmbDienLanh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDienLanh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbDienLanh.Size = new System.Drawing.Size(121, 31);
            this.cmbDienLanh.TabIndex = 2;
            // 
            // cmbDienMay
            // 
            this.cmbDienMay.BackColor = System.Drawing.Color.Transparent;
            this.cmbDienMay.BaseColor = System.Drawing.Color.White;
            this.cmbDienMay.BorderColor = System.Drawing.Color.Silver;
            this.cmbDienMay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDienMay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDienMay.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDienMay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDienMay.ForeColor = System.Drawing.Color.Black;
            this.cmbDienMay.FormattingEnabled = true;
            this.cmbDienMay.Items.AddRange(new object[] {
            "máy quạt",
            "máy lọc không khí",
            "máy lọc nước",
            "máy năng lượng mặt trời",
            "máy sấy"});
            this.cmbDienMay.Location = new System.Drawing.Point(166, 62);
            this.cmbDienMay.Name = "cmbDienMay";
            this.cmbDienMay.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDienMay.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbDienMay.Size = new System.Drawing.Size(121, 31);
            this.cmbDienMay.TabIndex = 4;
            // 
            // cmbXayDungKienTruc
            // 
            this.cmbXayDungKienTruc.BackColor = System.Drawing.Color.Transparent;
            this.cmbXayDungKienTruc.BaseColor = System.Drawing.Color.White;
            this.cmbXayDungKienTruc.BorderColor = System.Drawing.Color.Silver;
            this.cmbXayDungKienTruc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbXayDungKienTruc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXayDungKienTruc.FocusedColor = System.Drawing.Color.Empty;
            this.cmbXayDungKienTruc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbXayDungKienTruc.ForeColor = System.Drawing.Color.Black;
            this.cmbXayDungKienTruc.FormattingEnabled = true;
            this.cmbXayDungKienTruc.Items.AddRange(new object[] {
            "xây mới nhà cửa",
            "phá dỡ công trình",
            "sơn nhà",
            "sửa chữa, cải tạo nhà",
            "thiết kế nội thất",
            "thiết kế cảnh quan"});
            this.cmbXayDungKienTruc.Location = new System.Drawing.Point(166, 100);
            this.cmbXayDungKienTruc.Name = "cmbXayDungKienTruc";
            this.cmbXayDungKienTruc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbXayDungKienTruc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbXayDungKienTruc.Size = new System.Drawing.Size(121, 31);
            this.cmbXayDungKienTruc.TabIndex = 6;
            // 
            // cmbDienTuGiaDung
            // 
            this.cmbDienTuGiaDung.BackColor = System.Drawing.Color.Transparent;
            this.cmbDienTuGiaDung.BaseColor = System.Drawing.Color.White;
            this.cmbDienTuGiaDung.BorderColor = System.Drawing.Color.Silver;
            this.cmbDienTuGiaDung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDienTuGiaDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDienTuGiaDung.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDienTuGiaDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDienTuGiaDung.ForeColor = System.Drawing.Color.Black;
            this.cmbDienTuGiaDung.FormattingEnabled = true;
            this.cmbDienTuGiaDung.Items.AddRange(new object[] {
            "bếp điện",
            "loa",
            "nồi cơm điện",
            "bếp ga",
            "lò nướng",
            "tivi"});
            this.cmbDienTuGiaDung.Location = new System.Drawing.Point(437, 25);
            this.cmbDienTuGiaDung.Name = "cmbDienTuGiaDung";
            this.cmbDienTuGiaDung.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDienTuGiaDung.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbDienTuGiaDung.Size = new System.Drawing.Size(121, 31);
            this.cmbDienTuGiaDung.TabIndex = 8;
            // 
            // cmbHeThongnuoc
            // 
            this.cmbHeThongnuoc.BackColor = System.Drawing.Color.Transparent;
            this.cmbHeThongnuoc.BaseColor = System.Drawing.Color.White;
            this.cmbHeThongnuoc.BorderColor = System.Drawing.Color.Silver;
            this.cmbHeThongnuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHeThongnuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeThongnuoc.FocusedColor = System.Drawing.Color.Empty;
            this.cmbHeThongnuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHeThongnuoc.ForeColor = System.Drawing.Color.Black;
            this.cmbHeThongnuoc.FormattingEnabled = true;
            this.cmbHeThongnuoc.Items.AddRange(new object[] {
            "đường ống nước",
            "bồn nước",
            "thiết bị nhà bếp toilet",
            "máy bơm nước",
            "vòi nước",
            "dò nước rò rỉ"});
            this.cmbHeThongnuoc.Location = new System.Drawing.Point(437, 62);
            this.cmbHeThongnuoc.Name = "cmbHeThongnuoc";
            this.cmbHeThongnuoc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbHeThongnuoc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbHeThongnuoc.Size = new System.Drawing.Size(121, 31);
            this.cmbHeThongnuoc.TabIndex = 10;
            // 
            // cmbThongNghet
            // 
            this.cmbThongNghet.BackColor = System.Drawing.Color.Transparent;
            this.cmbThongNghet.BaseColor = System.Drawing.Color.White;
            this.cmbThongNghet.BorderColor = System.Drawing.Color.Silver;
            this.cmbThongNghet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbThongNghet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThongNghet.FocusedColor = System.Drawing.Color.Empty;
            this.cmbThongNghet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbThongNghet.ForeColor = System.Drawing.Color.Black;
            this.cmbThongNghet.FormattingEnabled = true;
            this.cmbThongNghet.Items.AddRange(new object[] {
            "cống ",
            "bồn cầu",
            "đường ống nước\'"});
            this.cmbThongNghet.Location = new System.Drawing.Point(437, 101);
            this.cmbThongNghet.Name = "cmbThongNghet";
            this.cmbThongNghet.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbThongNghet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbThongNghet.Size = new System.Drawing.Size(121, 31);
            this.cmbThongNghet.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Điện Lạnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Điện Máy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "XâyDựngKiếnTrúc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(292, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "ĐiệnTửGiaDụng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(292, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hệ Thống Nước ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(292, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Thông Nghẹt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbThongNghet);
            this.Controls.Add(this.cmbHeThongnuoc);
            this.Controls.Add(this.cmbDienTuGiaDung);
            this.Controls.Add(this.cmbXayDungKienTruc);
            this.Controls.Add(this.cmbDienMay);
            this.Controls.Add(this.cmbDienLanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(561, 149);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI.WinForms.GunaComboBox cmbDienLanh;
        private Guna.UI.WinForms.GunaComboBox cmbDienMay;
        private Guna.UI.WinForms.GunaComboBox cmbXayDungKienTruc;
        private Guna.UI.WinForms.GunaComboBox cmbDienTuGiaDung;
        private Guna.UI.WinForms.GunaComboBox cmbHeThongnuoc;
        private Guna.UI.WinForms.GunaComboBox cmbThongNghet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
