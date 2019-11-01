namespace Dangkyvephim
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbGhe = new System.Windows.Forms.ComboBox();
            this.cbSuat = new System.Windows.Forms.ComboBox();
            this.cbPhim = new System.Windows.Forms.ComboBox();
            this.txtNDK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Số ghế:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Suất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phim:";
            // 
            // dtpDat
            // 
            this.dtpDat.Location = new System.Drawing.Point(185, 101);
            this.dtpDat.Name = "dtpDat";
            this.dtpDat.Size = new System.Drawing.Size(200, 20);
            this.dtpDat.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày đặt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên người đăng ký:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(310, 217);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(185, 217);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 23;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // cbGhe
            // 
            this.cbGhe.FormattingEnabled = true;
            this.cbGhe.Items.AddRange(new object[] {
            "---Chọn Ghế Ngồi---",
            "Test 7",
            "Test 8",
            "Test 9"});
            this.cbGhe.Location = new System.Drawing.Point(185, 181);
            this.cbGhe.Name = "cbGhe";
            this.cbGhe.Size = new System.Drawing.Size(200, 21);
            this.cbGhe.TabIndex = 21;
            // 
            // cbSuat
            // 
            this.cbSuat.FormattingEnabled = true;
            this.cbSuat.Items.AddRange(new object[] {
            "---Chọn Suất---",
            "Test 4",
            "Test 5",
            "Test 6"});
            this.cbSuat.Location = new System.Drawing.Point(185, 154);
            this.cbSuat.Name = "cbSuat";
            this.cbSuat.Size = new System.Drawing.Size(200, 21);
            this.cbSuat.TabIndex = 20;
            // 
            // cbPhim
            // 
            this.cbPhim.FormattingEnabled = true;
            this.cbPhim.Items.AddRange(new object[] {
            "---Chọn Phim---",
            "Test 1",
            "Test 2",
            "Test 3"});
            this.cbPhim.Location = new System.Drawing.Point(185, 127);
            this.cbPhim.Name = "cbPhim";
            this.cbPhim.Size = new System.Drawing.Size(200, 21);
            this.cbPhim.TabIndex = 19;
            // 
            // txtNDK
            // 
            this.txtNDK.Location = new System.Drawing.Point(185, 75);
            this.txtNDK.Name = "txtNDK";
            this.txtNDK.Size = new System.Drawing.Size(200, 20);
            this.txtNDK.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "ĐĂNG KÍ VÉ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 253);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbGhe);
            this.Controls.Add(this.cbSuat);
            this.Controls.Add(this.cbPhim);
            this.Controls.Add(this.txtNDK);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbGhe;
        private System.Windows.Forms.ComboBox cbSuat;
        private System.Windows.Forms.ComboBox cbPhim;
        private System.Windows.Forms.TextBox txtNDK;
        private System.Windows.Forms.Label label1;
    }
}

