namespace DOPFNS_RealWorld
{
    partial class antique_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(antique_Login));
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.textBox_kata_sandi = new System.Windows.Forms.TextBox();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_ks = new System.Windows.Forms.Label();
            this.label_antique = new System.Windows.Forms.Label();
            this.button_log_in = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_lupa_pass_daftar = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_nama
            // 
            this.textBox_nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nama.BackColor = System.Drawing.Color.White;
            this.textBox_nama.ForeColor = System.Drawing.Color.Coral;
            this.textBox_nama.Location = new System.Drawing.Point(690, 528);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(393, 32);
            this.textBox_nama.TabIndex = 1;
            this.textBox_nama.TextChanged += new System.EventHandler(this.textBox_nama_TextChanged);
            // 
            // textBox_kata_sandi
            // 
            this.textBox_kata_sandi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_kata_sandi.BackColor = System.Drawing.Color.White;
            this.textBox_kata_sandi.ForeColor = System.Drawing.Color.Coral;
            this.textBox_kata_sandi.Location = new System.Drawing.Point(690, 593);
            this.textBox_kata_sandi.Name = "textBox_kata_sandi";
            this.textBox_kata_sandi.Size = new System.Drawing.Size(393, 32);
            this.textBox_kata_sandi.TabIndex = 1;
            this.textBox_kata_sandi.UseSystemPasswordChar = true;
            this.textBox_kata_sandi.TextChanged += new System.EventHandler(this.textBox_kata_sandi_TextChanged);
            // 
            // label_nama
            // 
            this.label_nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.ForeColor = System.Drawing.Color.Coral;
            this.label_nama.Location = new System.Drawing.Point(687, 503);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(77, 23);
            this.label_nama.TabIndex = 0;
            this.label_nama.Text = "Nama:";
            // 
            // label_ks
            // 
            this.label_ks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ks.AutoSize = true;
            this.label_ks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ks.ForeColor = System.Drawing.Color.Coral;
            this.label_ks.Location = new System.Drawing.Point(687, 569);
            this.label_ks.Name = "label_ks";
            this.label_ks.Size = new System.Drawing.Size(121, 23);
            this.label_ks.TabIndex = 0;
            this.label_ks.Text = "Kata Sandi:";
            // 
            // label_antique
            // 
            this.label_antique.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_antique.AutoSize = true;
            this.label_antique.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_antique.ForeColor = System.Drawing.Color.Coral;
            this.label_antique.Location = new System.Drawing.Point(734, 391);
            this.label_antique.Name = "label_antique";
            this.label_antique.Size = new System.Drawing.Size(304, 47);
            this.label_antique.TabIndex = 0;
            this.label_antique.Text = "ANTIQUE SHOP";
            // 
            // button_log_in
            // 
            this.button_log_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_log_in.BackColor = System.Drawing.Color.White;
            this.button_log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_log_in.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_log_in.ForeColor = System.Drawing.Color.Coral;
            this.button_log_in.Location = new System.Drawing.Point(691, 664);
            this.button_log_in.Name = "button_log_in";
            this.button_log_in.Size = new System.Drawing.Size(392, 41);
            this.button_log_in.TabIndex = 3;
            this.button_log_in.Text = "Log in";
            this.button_log_in.UseVisualStyleBackColor = false;
            this.button_log_in.Click += new System.EventHandler(this.button_log_in_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(1676, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_lupa_pass_daftar
            // 
            this.label_lupa_pass_daftar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_lupa_pass_daftar.AutoSize = true;
            this.label_lupa_pass_daftar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lupa_pass_daftar.ForeColor = System.Drawing.Color.Coral;
            this.label_lupa_pass_daftar.Location = new System.Drawing.Point(872, 723);
            this.label_lupa_pass_daftar.Name = "label_lupa_pass_daftar";
            this.label_lupa_pass_daftar.Size = new System.Drawing.Size(215, 21);
            this.label_lupa_pass_daftar.TabIndex = 4;
            this.label_lupa_pass_daftar.Text = "Lupa Password?/ Top up";
            this.label_lupa_pass_daftar.Click += new System.EventHandler(this.label_lupa_pass_daftar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Coral;
            this.checkBox1.Location = new System.Drawing.Point(798, 631);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 27);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // antique_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1733, 1037);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_lupa_pass_daftar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_log_in);
            this.Controls.Add(this.textBox_kata_sandi);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.label_ks);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.label_antique);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "antique_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.TextBox textBox_kata_sandi;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_ks;
        private System.Windows.Forms.Label label_antique;
        private System.Windows.Forms.Button button_log_in;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_lupa_pass_daftar;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

