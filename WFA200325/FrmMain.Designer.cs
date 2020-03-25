namespace WFA200325
{
    partial class FrmMain
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
            this.rbKV = new System.Windows.Forms.RadioButton();
            this.cbTej = new System.Windows.Forms.CheckBox();
            this.btnKeszit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFcsoki = new System.Windows.Forms.RadioButton();
            this.rbTea = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCukor = new System.Windows.Forms.CheckBox();
            this.cbPohar = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAr = new System.Windows.Forms.Label();
            this.lblEgs = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbTea);
            this.groupBox1.Controls.Add(this.rbFcsoki);
            this.groupBox1.Controls.Add(this.rbKV);
            this.groupBox1.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ital";
            // 
            // rbKV
            // 
            this.rbKV.AutoSize = true;
            this.rbKV.BackColor = System.Drawing.Color.Peru;
            this.rbKV.Checked = true;
            this.rbKV.Location = new System.Drawing.Point(16, 39);
            this.rbKV.Name = "rbKV";
            this.rbKV.Size = new System.Drawing.Size(80, 28);
            this.rbKV.TabIndex = 0;
            this.rbKV.TabStop = true;
            this.rbKV.Text = "Kávé";
            this.rbKV.UseVisualStyleBackColor = false;
            // 
            // cbTej
            // 
            this.cbTej.AutoSize = true;
            this.cbTej.BackColor = System.Drawing.Color.Peru;
            this.cbTej.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTej.Location = new System.Drawing.Point(16, 44);
            this.cbTej.Name = "cbTej";
            this.cbTej.Size = new System.Drawing.Size(72, 28);
            this.cbTej.TabIndex = 1;
            this.cbTej.Text = "+ tej";
            this.cbTej.UseVisualStyleBackColor = false;
            // 
            // btnKeszit
            // 
            this.btnKeszit.BackColor = System.Drawing.Color.PeachPuff;
            this.btnKeszit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKeszit.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKeszit.Location = new System.Drawing.Point(24, 471);
            this.btnKeszit.Name = "btnKeszit";
            this.btnKeszit.Size = new System.Drawing.Size(280, 68);
            this.btnKeszit.TabIndex = 2;
            this.btnKeszit.Text = "Elkészít!";
            this.btnKeszit.UseVisualStyleBackColor = false;
            this.btnKeszit.Click += new System.EventHandler(this.btnKeszit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ár:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.cbPohar);
            this.groupBox2.Controls.Add(this.cbCukor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbTej);
            this.groupBox2.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(24, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 180);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra";
            // 
            // rbFcsoki
            // 
            this.rbFcsoki.AutoSize = true;
            this.rbFcsoki.BackColor = System.Drawing.Color.Peru;
            this.rbFcsoki.Location = new System.Drawing.Point(16, 73);
            this.rbFcsoki.Name = "rbFcsoki";
            this.rbFcsoki.Size = new System.Drawing.Size(138, 28);
            this.rbFcsoki.TabIndex = 0;
            this.rbFcsoki.TabStop = true;
            this.rbFcsoki.Text = "Forró csoki";
            this.rbFcsoki.UseVisualStyleBackColor = false;
            // 
            // rbTea
            // 
            this.rbTea.AutoSize = true;
            this.rbTea.BackColor = System.Drawing.Color.Peru;
            this.rbTea.Location = new System.Drawing.Point(16, 107);
            this.rbTea.Name = "rbTea";
            this.rbTea.Size = new System.Drawing.Size(65, 28);
            this.rbTea.TabIndex = 0;
            this.rbTea.TabStop = true;
            this.rbTea.Text = "Tea";
            this.rbTea.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(204, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "80 Ft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(193, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "100 Ft";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(193, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "120 Ft";
            // 
            // cbCukor
            // 
            this.cbCukor.AutoSize = true;
            this.cbCukor.BackColor = System.Drawing.Color.Peru;
            this.cbCukor.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCukor.Location = new System.Drawing.Point(16, 78);
            this.cbCukor.Name = "cbCukor";
            this.cbCukor.Size = new System.Drawing.Size(102, 28);
            this.cbCukor.TabIndex = 1;
            this.cbCukor.Text = "+ cukor";
            this.cbCukor.UseVisualStyleBackColor = false;
            // 
            // cbPohar
            // 
            this.cbPohar.AutoSize = true;
            this.cbPohar.BackColor = System.Drawing.Color.Peru;
            this.cbPohar.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPohar.Location = new System.Drawing.Point(16, 112);
            this.cbPohar.Name = "cbPohar";
            this.cbPohar.Size = new System.Drawing.Size(109, 28);
            this.cbPohar.TabIndex = 1;
            this.cbPohar.Text = "s. pohár";
            this.cbPohar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(191, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "+ 10 Ft";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Peru;
            this.label6.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(190, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "+ 20 Ft";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Peru;
            this.label7.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(192, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "- 10 Ft";
            // 
            // lblAr
            // 
            this.lblAr.BackColor = System.Drawing.Color.PeachPuff;
            this.lblAr.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAr.Location = new System.Drawing.Point(153, 424);
            this.lblAr.Name = "lblAr";
            this.lblAr.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblAr.Size = new System.Drawing.Size(151, 24);
            this.lblAr.TabIndex = 3;
            this.lblAr.Text = "### Ft";
            this.lblAr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEgs
            // 
            this.lblEgs.BackColor = System.Drawing.Color.PeachPuff;
            this.lblEgs.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEgs.Location = new System.Drawing.Point(24, 565);
            this.lblEgs.Name = "lblEgs";
            this.lblEgs.Size = new System.Drawing.Size(280, 24);
            this.lblEgs.TabIndex = 3;
            this.lblEgs.Text = "Egészségedre!";
            this.lblEgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEgs.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(332, 618);
            this.Controls.Add(this.lblEgs);
            this.Controls.Add(this.lblAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeszit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kávégép";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKV;
        private System.Windows.Forms.CheckBox cbTej;
        private System.Windows.Forms.Button btnKeszit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTea;
        private System.Windows.Forms.RadioButton rbFcsoki;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPohar;
        private System.Windows.Forms.CheckBox cbCukor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAr;
        private System.Windows.Forms.Label lblEgs;
    }
}

