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
            this.createOrderButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelDanychFormyZamowienia = new DevExpress.XtraEditors.PanelControl();
            this.tabelaWybranychProduktow = new DevExpress.XtraGrid.GridControl();
            this.widokTabeliWybranychProduktow = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrzyciskowFormyZamowienia)).BeginInit();
            this.panelPrzyciskowFormyZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDanychFormyZamowienia)).BeginInit();
            this.panelDanychFormyZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaWybranychProduktow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokTabeliWybranychProduktow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrzyciskowFormyZamowienia
            // 
            this.panelPrzyciskowFormyZamowienia.Controls.Add(this.createOrderButton);
            this.panelPrzyciskowFormyZamowienia.Controls.Add(this.cancelButton);
            this.panelPrzyciskowFormyZamowienia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrzyciskowFormyZamowienia.Location = new System.Drawing.Point(0, 516);
            this.panelPrzyciskowFormyZamowienia.Name = "panelPrzyciskowFormyZamowienia";
            this.panelPrzyciskowFormyZamowienia.Size = new System.Drawing.Size(1182, 66);
            this.panelPrzyciskowFormyZamowienia.TabIndex = 0;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createOrderButton.Location = new System.Drawing.Point(1086, 2);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(94, 62);
            this.createOrderButton.TabIndex = 1;
            this.createOrderButton.Text = "Zapisz";
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelButton.Location = new System.Drawing.Point(2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 62);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panelDanychFormyZamowienia
            // 
            this.panelDanychFormyZamowienia.Controls.Add(this.tabelaWybranychProduktow);
            this.panelDanychFormyZamowienia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanychFormyZamowienia.Location = new System.Drawing.Point(0, 0);
            this.panelDanychFormyZamowienia.Name = "panelDanychFormyZamowienia";
            this.panelDanychFormyZamowienia.Size = new System.Drawing.Size(1182, 516);
            this.panelDanychFormyZamowienia.TabIndex = 1;
            // 
            // tabelaWybranychProduktow
            // 
            this.tabelaWybranychProduktow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaWybranychProduktow.Location = new System.Drawing.Point(2, 2);
            this.tabelaWybranychProduktow.MainView = this.widokTabeliWybranychProduktow;
            this.tabelaWybranychProduktow.Name = "tabelaWybranychProduktow";
            this.tabelaWybranychProduktow.Size = new System.Drawing.Size(1178, 512);
            this.tabelaWybranychProduktow.TabIndex = 0;
            this.tabelaWybranychProduktow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.widokTabeliWybranychProduktow});
            this.tabelaWybranychProduktow.Load += new System.EventHandler(this.tabelaWybranychProduktow_Load);
            // 
            // widokTabeliWybranychProduktow
            // 
            this.widokTabeliWybranychProduktow.GridControl = this.tabelaWybranychProduktow;
            this.widokTabeliWybranychProduktow.Name = "widokTabeliWybranychProduktow";
            this.widokTabeliWybranychProduktow.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.widokTabeliWybranychProduktow_CustomUnboundColumnData);
            // 
            // FormZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 582);
            this.Controls.Add(this.panelDanychFormyZamowienia);
            this.Controls.Add(this.panelPrzyciskowFormyZamowienia);
            this.Name = "FormZamowienia";
            this.Text = "FormZamowienia";
            ((System.ComponentModel.ISupportInitialize)(this.panelPrzyciskowFormyZamowienia)).EndInit();
            this.panelPrzyciskowFormyZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDanychFormyZamowienia)).EndInit();
            this.panelDanychFormyZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaWybranychProduktow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokTabeliWybranychProduktow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelPrzyciskowFormyZamowienia;
        private DevExpress.XtraEditors.SimpleButton createOrderButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.PanelControl panelDanychFormyZamowienia;
        private DevExpress.XtraGrid.GridControl tabelaWybranychProduktow;
        private DevExpress.XtraGrid.Views.Grid.GridView widokTabeliWybranychProduktow;
    }
}