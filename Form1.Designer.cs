namespace AtıkOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cikis = new System.Windows.Forms.Button();
            this.yeniOyun = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sure_label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.organikProgress = new System.Windows.Forms.ProgressBar();
            this.organik_button = new System.Windows.Forms.Button();
            this.organik_bosalt = new System.Windows.Forms.Button();
            this.organik_listbox = new System.Windows.Forms.ListBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.kagitProgress = new System.Windows.Forms.ProgressBar();
            this.kagit_button = new System.Windows.Forms.Button();
            this.kagit_bosalt = new System.Windows.Forms.Button();
            this.kagit_listbox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.cam_bosalt = new System.Windows.Forms.Button();
            this.cam_button = new System.Windows.Forms.Button();
            this.camProgress = new System.Windows.Forms.ProgressBar();
            this.cam_listbox = new System.Windows.Forms.ListBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.metal_bosalt = new System.Windows.Forms.Button();
            this.metal_button = new System.Windows.Forms.Button();
            this.metalProgress = new System.Windows.Forms.ProgressBar();
            this.metal_listbox = new System.Windows.Forms.ListBox();
            this.puan_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 159);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cikis);
            this.panel2.Controls.Add(this.yeniOyun);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(13, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 256);
            this.panel2.TabIndex = 1;
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cikis.Location = new System.Drawing.Point(18, 200);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(171, 38);
            this.cikis.TabIndex = 2;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // yeniOyun
            // 
            this.yeniOyun.BackColor = System.Drawing.Color.DarkSlateGray;
            this.yeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniOyun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yeniOyun.Location = new System.Drawing.Point(18, 3);
            this.yeniOyun.Name = "yeniOyun";
            this.yeniOyun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yeniOyun.Size = new System.Drawing.Size(171, 42);
            this.yeniOyun.TabIndex = 1;
            this.yeniOyun.Text = "Yeni Oyun";
            this.yeniOyun.UseVisualStyleBackColor = false;
            this.yeniOyun.Click += new System.EventHandler(this.yeniOyun_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.puan_label);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(18, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 67);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(-1, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 32);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(57, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PUAN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sure_label);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.ForeColor = System.Drawing.Color.Cyan;
            this.panel3.Location = new System.Drawing.Point(18, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 70);
            this.panel3.TabIndex = 0;
            // 
            // sure_label
            // 
            this.sure_label.AutoSize = true;
            this.sure_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure_label.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.sure_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sure_label.Location = new System.Drawing.Point(55, 35);
            this.sure_label.Name = "sure_label";
            this.sure_label.Size = new System.Drawing.Size(29, 31);
            this.sure_label.TabIndex = 1;
            this.sure_label.Text = "0";
            this.sure_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(-1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 32);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(57, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SÜRE";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.GhostWhite;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(227, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 40);
            this.panel7.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(67, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ATIK KUTULARI";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.AliceBlue;
            this.panel8.Controls.Add(this.organikProgress);
            this.panel8.Controls.Add(this.organik_button);
            this.panel8.Controls.Add(this.organik_bosalt);
            this.panel8.Controls.Add(this.organik_listbox);
            this.panel8.Location = new System.Drawing.Point(229, 61);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(129, 187);
            this.panel8.TabIndex = 3;
            // 
            // organikProgress
            // 
            this.organikProgress.Location = new System.Drawing.Point(7, 133);
            this.organikProgress.Name = "organikProgress";
            this.organikProgress.Size = new System.Drawing.Size(113, 23);
            this.organikProgress.TabIndex = 2;
            // 
            // organik_button
            // 
            this.organik_button.Location = new System.Drawing.Point(7, 3);
            this.organik_button.Name = "organik_button";
            this.organik_button.Size = new System.Drawing.Size(113, 28);
            this.organik_button.TabIndex = 1;
            this.organik_button.Text = "ORGANİK ATIK";
            this.organik_button.UseVisualStyleBackColor = true;
            this.organik_button.Click += new System.EventHandler(this.organik_button_Click);
            // 
            // organik_bosalt
            // 
            this.organik_bosalt.Location = new System.Drawing.Point(7, 156);
            this.organik_bosalt.Name = "organik_bosalt";
            this.organik_bosalt.Size = new System.Drawing.Size(113, 28);
            this.organik_bosalt.TabIndex = 1;
            this.organik_bosalt.Text = "BOŞALT";
            this.organik_bosalt.UseVisualStyleBackColor = true;
            this.organik_bosalt.Click += new System.EventHandler(this.organik_bosalt_Click);
            // 
            // organik_listbox
            // 
            this.organik_listbox.FormattingEnabled = true;
            this.organik_listbox.Location = new System.Drawing.Point(7, 36);
            this.organik_listbox.Name = "organik_listbox";
            this.organik_listbox.Size = new System.Drawing.Size(113, 95);
            this.organik_listbox.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.AliceBlue;
            this.panel9.Controls.Add(this.kagitProgress);
            this.panel9.Controls.Add(this.kagit_button);
            this.panel9.Controls.Add(this.kagit_bosalt);
            this.panel9.Controls.Add(this.kagit_listbox);
            this.panel9.Location = new System.Drawing.Point(385, 61);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(127, 187);
            this.panel9.TabIndex = 3;
            // 
            // kagitProgress
            // 
            this.kagitProgress.Location = new System.Drawing.Point(7, 132);
            this.kagitProgress.Name = "kagitProgress";
            this.kagitProgress.Size = new System.Drawing.Size(113, 23);
            this.kagitProgress.TabIndex = 2;
            // 
            // kagit_button
            // 
            this.kagit_button.Location = new System.Drawing.Point(7, 3);
            this.kagit_button.Name = "kagit_button";
            this.kagit_button.Size = new System.Drawing.Size(113, 28);
            this.kagit_button.TabIndex = 1;
            this.kagit_button.Text = "KAĞIT";
            this.kagit_button.UseVisualStyleBackColor = true;
            this.kagit_button.Click += new System.EventHandler(this.kagit_button_Click);
            // 
            // kagit_bosalt
            // 
            this.kagit_bosalt.Location = new System.Drawing.Point(7, 156);
            this.kagit_bosalt.Name = "kagit_bosalt";
            this.kagit_bosalt.Size = new System.Drawing.Size(113, 28);
            this.kagit_bosalt.TabIndex = 1;
            this.kagit_bosalt.Text = "BOŞALT";
            this.kagit_bosalt.UseVisualStyleBackColor = true;
            this.kagit_bosalt.Click += new System.EventHandler(this.kagit_bosalt_Click);
            // 
            // kagit_listbox
            // 
            this.kagit_listbox.FormattingEnabled = true;
            this.kagit_listbox.Location = new System.Drawing.Point(7, 36);
            this.kagit_listbox.Name = "kagit_listbox";
            this.kagit_listbox.Size = new System.Drawing.Size(113, 95);
            this.kagit_listbox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.AliceBlue;
            this.panel10.Controls.Add(this.cam_bosalt);
            this.panel10.Controls.Add(this.cam_button);
            this.panel10.Controls.Add(this.camProgress);
            this.panel10.Controls.Add(this.cam_listbox);
            this.panel10.Location = new System.Drawing.Point(229, 254);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(129, 187);
            this.panel10.TabIndex = 3;
            // 
            // cam_bosalt
            // 
            this.cam_bosalt.Location = new System.Drawing.Point(7, 156);
            this.cam_bosalt.Name = "cam_bosalt";
            this.cam_bosalt.Size = new System.Drawing.Size(113, 28);
            this.cam_bosalt.TabIndex = 4;
            this.cam_bosalt.Text = "BOŞALT";
            this.cam_bosalt.UseVisualStyleBackColor = true;
            this.cam_bosalt.Click += new System.EventHandler(this.cam_bosalt_Click_1);
            // 
            // cam_button
            // 
            this.cam_button.Location = new System.Drawing.Point(7, 3);
            this.cam_button.Name = "cam_button";
            this.cam_button.Size = new System.Drawing.Size(113, 30);
            this.cam_button.TabIndex = 3;
            this.cam_button.Text = "CAM";
            this.cam_button.UseVisualStyleBackColor = true;
            this.cam_button.Click += new System.EventHandler(this.cam_button_Click_1);
            // 
            // camProgress
            // 
            this.camProgress.Location = new System.Drawing.Point(7, 133);
            this.camProgress.Name = "camProgress";
            this.camProgress.Size = new System.Drawing.Size(113, 23);
            this.camProgress.TabIndex = 2;
            // 
            // cam_listbox
            // 
            this.cam_listbox.FormattingEnabled = true;
            this.cam_listbox.Location = new System.Drawing.Point(7, 36);
            this.cam_listbox.Name = "cam_listbox";
            this.cam_listbox.Size = new System.Drawing.Size(113, 95);
            this.cam_listbox.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.AliceBlue;
            this.panel11.Controls.Add(this.metal_bosalt);
            this.panel11.Controls.Add(this.metal_button);
            this.panel11.Controls.Add(this.metalProgress);
            this.panel11.Controls.Add(this.metal_listbox);
            this.panel11.Location = new System.Drawing.Point(385, 254);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(127, 187);
            this.panel11.TabIndex = 3;
            // 
            // metal_bosalt
            // 
            this.metal_bosalt.Location = new System.Drawing.Point(7, 156);
            this.metal_bosalt.Name = "metal_bosalt";
            this.metal_bosalt.Size = new System.Drawing.Size(113, 28);
            this.metal_bosalt.TabIndex = 4;
            this.metal_bosalt.Text = "BOŞALT";
            this.metal_bosalt.UseVisualStyleBackColor = true;
            this.metal_bosalt.Click += new System.EventHandler(this.metal_bosalt_Click);
            // 
            // metal_button
            // 
            this.metal_button.Location = new System.Drawing.Point(7, 3);
            this.metal_button.Name = "metal_button";
            this.metal_button.Size = new System.Drawing.Size(113, 30);
            this.metal_button.TabIndex = 3;
            this.metal_button.Text = "METAL";
            this.metal_button.UseVisualStyleBackColor = true;
            this.metal_button.Click += new System.EventHandler(this.metal_button_Click_1);
            // 
            // metalProgress
            // 
            this.metalProgress.Location = new System.Drawing.Point(7, 132);
            this.metalProgress.Name = "metalProgress";
            this.metalProgress.Size = new System.Drawing.Size(113, 23);
            this.metalProgress.TabIndex = 2;
            // 
            // metal_listbox
            // 
            this.metal_listbox.FormattingEnabled = true;
            this.metal_listbox.Location = new System.Drawing.Point(7, 36);
            this.metal_listbox.Name = "metal_listbox";
            this.metal_listbox.Size = new System.Drawing.Size(113, 95);
            this.metal_listbox.TabIndex = 0;
            // 
            // puan_label
            // 
            this.puan_label.AutoSize = true;
            this.puan_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan_label.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.puan_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.puan_label.Location = new System.Drawing.Point(55, 34);
            this.puan_label.Name = "puan_label";
            this.puan_label.Size = new System.Drawing.Size(29, 31);
            this.puan_label.TabIndex = 1;
            this.puan_label.Text = "0";
            this.puan_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button yeniOyun;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label sure_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button organik_button;
        private System.Windows.Forms.Button organik_bosalt;
        private System.Windows.Forms.ListBox organik_listbox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button kagit_button;
        private System.Windows.Forms.Button kagit_bosalt;
        private System.Windows.Forms.ListBox kagit_listbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar organikProgress;
        private System.Windows.Forms.ProgressBar kagitProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ProgressBar metalProgress;
        private System.Windows.Forms.ListBox metal_listbox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ProgressBar camProgress;
        private System.Windows.Forms.ListBox cam_listbox;
        private System.Windows.Forms.Button cam_button;
        private System.Windows.Forms.Button metal_button;
        private System.Windows.Forms.Button cam_bosalt;
        private System.Windows.Forms.Button metal_bosalt;
        private System.Windows.Forms.Label puan_label;
    }
}

