namespace C__hinhtron
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
            this.lblkq = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btndientich = new System.Windows.Forms.Button();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbdt1 = new System.Windows.Forms.RadioButton();
            this.rdbcv1 = new System.Windows.Forms.RadioButton();
            this.btntinh1 = new System.Windows.Forms.Button();
            this.btntinh2 = new System.Windows.Forms.Button();
            this.chkdt2 = new System.Windows.Forms.CheckBox();
            this.chkcv2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập bán kính";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(62, 105);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 1;
            this.lblkq.Text = "kết quả";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(140, 65);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(140, 98);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 3;
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(31, 144);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(75, 23);
            this.btndientich.TabIndex = 4;
            this.btndientich.Text = "Diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(165, 144);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 5;
            this.btnchuvi.Text = "Chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tính Diện Tích,CHu Vi Hình Tròn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbcv1);
            this.groupBox1.Controls.Add(this.rdbdt1);
            this.groupBox1.Location = new System.Drawing.Point(326, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkcv2);
            this.groupBox2.Controls.Add(this.chkdt2);
            this.groupBox2.Location = new System.Drawing.Point(652, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng";
            // 
            // rdbdt1
            // 
            this.rdbdt1.AutoSize = true;
            this.rdbdt1.Location = new System.Drawing.Point(6, 19);
            this.rdbdt1.Name = "rdbdt1";
            this.rdbdt1.Size = new System.Drawing.Size(95, 17);
            this.rdbdt1.TabIndex = 9;
            this.rdbdt1.TabStop = true;
            this.rdbdt1.Text = "Tính Diện tích";
            this.rdbdt1.UseVisualStyleBackColor = true;
            // 
            // rdbcv1
            // 
            this.rdbcv1.AutoSize = true;
            this.rdbcv1.Location = new System.Drawing.Point(6, 58);
            this.rdbcv1.Name = "rdbcv1";
            this.rdbcv1.Size = new System.Drawing.Size(81, 17);
            this.rdbcv1.TabIndex = 10;
            this.rdbcv1.TabStop = true;
            this.rdbcv1.Text = "Tính Chu vi";
            this.rdbcv1.UseVisualStyleBackColor = true;
            // 
            // btntinh1
            // 
            this.btntinh1.Location = new System.Drawing.Point(397, 189);
            this.btntinh1.Name = "btntinh1";
            this.btntinh1.Size = new System.Drawing.Size(75, 23);
            this.btntinh1.TabIndex = 9;
            this.btntinh1.Text = "Tính 1";
            this.btntinh1.UseVisualStyleBackColor = true;
            this.btntinh1.Click += new System.EventHandler(this.btntinh1_Click);
            // 
            // btntinh2
            // 
            this.btntinh2.Location = new System.Drawing.Point(721, 189);
            this.btntinh2.Name = "btntinh2";
            this.btntinh2.Size = new System.Drawing.Size(75, 23);
            this.btntinh2.TabIndex = 10;
            this.btntinh2.Text = "Tính 2";
            this.btntinh2.UseVisualStyleBackColor = true;
            this.btntinh2.Click += new System.EventHandler(this.btntinh2_Click);
            // 
            // chkdt2
            // 
            this.chkdt2.AutoSize = true;
            this.chkdt2.Location = new System.Drawing.Point(7, 19);
            this.chkdt2.Name = "chkdt2";
            this.chkdt2.Size = new System.Drawing.Size(96, 17);
            this.chkdt2.TabIndex = 0;
            this.chkdt2.Text = "Tính Diện tích";
            this.chkdt2.UseVisualStyleBackColor = true;
            // 
            // chkcv2
            // 
            this.chkcv2.AutoSize = true;
            this.chkcv2.Location = new System.Drawing.Point(7, 58);
            this.chkcv2.Name = "chkcv2";
            this.chkcv2.Size = new System.Drawing.Size(82, 17);
            this.chkcv2.TabIndex = 1;
            this.chkcv2.Text = "Tính Chu vi";
            this.chkcv2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.btntinh2);
            this.Controls.Add(this.btntinh1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HÌNH TRÒN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbcv1;
        private System.Windows.Forms.RadioButton rdbdt1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntinh1;
        private System.Windows.Forms.Button btntinh2;
        private System.Windows.Forms.CheckBox chkcv2;
        private System.Windows.Forms.CheckBox chkdt2;
    }
}

