namespace WindowsFormsApplication11
{
    partial class Form_Admin
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
            this.panel_pembeli = new System.Windows.Forms.Panel();
            this.panel_penjual = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_pembeli
            // 
            this.panel_pembeli.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_pembeli.Location = new System.Drawing.Point(13, 13);
            this.panel_pembeli.Name = "panel_pembeli";
            this.panel_pembeli.Size = new System.Drawing.Size(866, 965);
            this.panel_pembeli.TabIndex = 0;
            // 
            // panel_penjual
            // 
            this.panel_penjual.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_penjual.Location = new System.Drawing.Point(904, 13);
            this.panel_penjual.Name = "panel_penjual";
            this.panel_penjual.Size = new System.Drawing.Size(866, 965);
            this.panel_penjual.TabIndex = 1;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1785, 990);
            this.Controls.Add(this.panel_penjual);
            this.Controls.Add(this.panel_pembeli);
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pembeli;
        private System.Windows.Forms.Panel panel_penjual;
    }
}