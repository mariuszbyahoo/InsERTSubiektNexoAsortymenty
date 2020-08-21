namespace InsERTSubiektNexoAsortymenty
{
    partial class FormPotwierdzeniaZamowienia
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
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.numerUtworzonegoZamowienia = new DevExpress.XtraEditors.LabelControl();
            this.listaZamowionychProduktow = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.listaZamowionychProduktow)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton.Appearance.Options.UseFont = true;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okButton.Location = new System.Drawing.Point(0, 394);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(800, 56);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 382);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(800, 12);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            // 
            // numerUtworzonegoZamowienia
            // 
            this.numerUtworzonegoZamowienia.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numerUtworzonegoZamowienia.Appearance.Options.UseFont = true;
            this.numerUtworzonegoZamowienia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numerUtworzonegoZamowienia.Location = new System.Drawing.Point(0, 349);
            this.numerUtworzonegoZamowienia.Name = "numerUtworzonegoZamowienia";
            this.numerUtworzonegoZamowienia.Size = new System.Drawing.Size(294, 33);
            this.numerUtworzonegoZamowienia.TabIndex = 5;
            this.numerUtworzonegoZamowienia.Text = "Utworzono zamowienie: ";
            // 
            // listaZamowionychProduktow
            // 
            this.listaZamowionychProduktow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaZamowionychProduktow.Location = new System.Drawing.Point(0, 12);
            this.listaZamowionychProduktow.Name = "listaZamowionychProduktow";
            this.listaZamowionychProduktow.Size = new System.Drawing.Size(800, 337);
            this.listaZamowionychProduktow.TabIndex = 6;
            // 
            // FormPotwierdzeniaZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaZamowionychProduktow);
            this.Controls.Add(this.numerUtworzonegoZamowienia);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.okButton);
            this.Name = "FormPotwierdzeniaZamowienia";
            this.Text = "FormPotwierdzeniaZamowienia";
            this.Load += new System.EventHandler(this.FormPotwierdzeniaZamowienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaZamowionychProduktow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.LabelControl numerUtworzonegoZamowienia;
        private DevExpress.XtraEditors.ListBoxControl listaZamowionychProduktow;
    }
}