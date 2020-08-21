namespace InsERTSubiektNexoAsortymenty
{
    partial class FormBlednegoZamawiajacego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlednegoZamawiajacego));
            this.infoOBledzie = new DevExpress.XtraEditors.LabelControl();
            this.okButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // infoOBledzie
            // 
            this.infoOBledzie.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoOBledzie.Appearance.Options.UseFont = true;
            this.infoOBledzie.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoOBledzie.Location = new System.Drawing.Point(0, 0);
            this.infoOBledzie.Name = "infoOBledzie";
            this.infoOBledzie.Size = new System.Drawing.Size(439, 33);
            this.infoOBledzie.TabIndex = 0;
            this.infoOBledzie.Text = "Wybierz poprawnego zamawiajacego";
            // 
            // okButton2
            // 
            this.okButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.okButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.okButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.okButton2.Appearance.Options.UseBackColor = true;
            this.okButton2.Appearance.Options.UseBorderColor = true;
            this.okButton2.Appearance.Options.UseFont = true;
            this.okButton2.Appearance.Options.UseForeColor = true;
            this.okButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.okButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("okButton2.ImageOptions.Image")));
            this.okButton2.Location = new System.Drawing.Point(0, 33);
            this.okButton2.Name = "okButton2";
            this.okButton2.Size = new System.Drawing.Size(454, 50);
            this.okButton2.TabIndex = 1;
            this.okButton2.Text = "Zrozumiałem";
            this.okButton2.Click += new System.EventHandler(this.okButton2_Click);
            // 
            // FormBlednegoZamawiajacego
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(454, 84);
            this.Controls.Add(this.okButton2);
            this.Controls.Add(this.infoOBledzie);
            this.Name = "FormBlednegoZamawiajacego";
            this.Text = "FormBlednegoZamawiajacego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl infoOBledzie;
        private DevExpress.XtraEditors.SimpleButton okButton2;
    }
}