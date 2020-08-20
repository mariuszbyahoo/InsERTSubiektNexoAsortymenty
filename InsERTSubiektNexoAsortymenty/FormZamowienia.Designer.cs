namespace InsERTSubiektNexoAsortymenty
{
    partial class FormZamowienia
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
            this.panelPrzyciskowFormyZamowienia = new DevExpress.XtraEditors.PanelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.createOrderButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelDanychFormyZamowienia = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrzyciskowFormyZamowienia)).BeginInit();
            this.panelPrzyciskowFormyZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDanychFormyZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrzyciskowFormyZamowienia
            // 
            this.panelPrzyciskowFormyZamowienia.Controls.Add(this.createOrderButton);
            this.panelPrzyciskowFormyZamowienia.Controls.Add(this.cancelButton);
            this.panelPrzyciskowFormyZamowienia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrzyciskowFormyZamowienia.Location = new System.Drawing.Point(0, 194);
            this.panelPrzyciskowFormyZamowienia.Name = "panelPrzyciskowFormyZamowienia";
            this.panelPrzyciskowFormyZamowienia.Size = new System.Drawing.Size(298, 66);
            this.panelPrzyciskowFormyZamowienia.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelButton.Location = new System.Drawing.Point(2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 62);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Anuluj";
            // 
            // createOrderButton
            // 
            this.createOrderButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createOrderButton.Location = new System.Drawing.Point(202, 2);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(94, 62);
            this.createOrderButton.TabIndex = 1;
            this.createOrderButton.Text = "Zapisz";
            this.createOrderButton.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panelDanychFormyZamowienia
            // 
            this.panelDanychFormyZamowienia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanychFormyZamowienia.Location = new System.Drawing.Point(0, 0);
            this.panelDanychFormyZamowienia.Name = "panelDanychFormyZamowienia";
            this.panelDanychFormyZamowienia.Size = new System.Drawing.Size(298, 194);
            this.panelDanychFormyZamowienia.TabIndex = 1;
            // 
            // FormZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 260);
            this.Controls.Add(this.panelDanychFormyZamowienia);
            this.Controls.Add(this.panelPrzyciskowFormyZamowienia);
            this.Name = "FormZamowienia";
            this.Text = "FormZamowienia";
            ((System.ComponentModel.ISupportInitialize)(this.panelPrzyciskowFormyZamowienia)).EndInit();
            this.panelPrzyciskowFormyZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDanychFormyZamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelPrzyciskowFormyZamowienia;
        private DevExpress.XtraEditors.SimpleButton createOrderButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.PanelControl panelDanychFormyZamowienia;
    }
}