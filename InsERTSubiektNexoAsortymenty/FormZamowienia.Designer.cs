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
            this.poleWyboruKlienta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabelaWybranychProduktow = new DevExpress.XtraGrid.GridControl();
            this.widokTabeliWybranychProduktow = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrzyciskowFormyZamowienia)).BeginInit();
            this.panelPrzyciskowFormyZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDanychFormyZamowienia)).BeginInit();
            this.panelDanychFormyZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poleWyboruKlienta.Properties)).BeginInit();
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
            this.panelDanychFormyZamowienia.Controls.Add(this.poleWyboruKlienta);
            this.panelDanychFormyZamowienia.Controls.Add(this.splitterControl1);
            this.panelDanychFormyZamowienia.Controls.Add(this.splitter1);
            this.panelDanychFormyZamowienia.Controls.Add(this.tabelaWybranychProduktow);
            this.panelDanychFormyZamowienia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanychFormyZamowienia.Location = new System.Drawing.Point(0, 0);
            this.panelDanychFormyZamowienia.Name = "panelDanychFormyZamowienia";
            this.panelDanychFormyZamowienia.Size = new System.Drawing.Size(1182, 516);
            this.panelDanychFormyZamowienia.TabIndex = 1;
            // 
            // poleWyboruKlienta
            // 
            this.poleWyboruKlienta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poleWyboruKlienta.EditValue = "Zamawiający:";
            this.poleWyboruKlienta.Location = new System.Drawing.Point(10, 476);
            this.poleWyboruKlienta.Name = "poleWyboruKlienta";
            this.poleWyboruKlienta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleWyboruKlienta.Properties.Appearance.Options.UseFont = true;
            this.poleWyboruKlienta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.poleWyboruKlienta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.poleWyboruKlienta.Size = new System.Drawing.Size(1167, 34);
            this.poleWyboruKlienta.TabIndex = 3;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(10, 458);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1170, 12);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(2, 458);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 56);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // tabelaWybranychProduktow
            // 
            this.tabelaWybranychProduktow.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabelaWybranychProduktow.Location = new System.Drawing.Point(2, 2);
            this.tabelaWybranychProduktow.MainView = this.widokTabeliWybranychProduktow;
            this.tabelaWybranychProduktow.Name = "tabelaWybranychProduktow";
            this.tabelaWybranychProduktow.Size = new System.Drawing.Size(1178, 456);
            this.tabelaWybranychProduktow.TabIndex = 0;
            this.tabelaWybranychProduktow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.widokTabeliWybranychProduktow});
            this.tabelaWybranychProduktow.Load += new System.EventHandler(this.tabelaWybranychProduktow_Load);
            this.tabelaWybranychProduktow.Click += new System.EventHandler(this.tabelaWybranychProduktow_Click);
            // 
            // widokTabeliWybranychProduktow
            // 
            this.widokTabeliWybranychProduktow.GridControl = this.tabelaWybranychProduktow;
            this.widokTabeliWybranychProduktow.Name = "widokTabeliWybranychProduktow";
            this.widokTabeliWybranychProduktow.OptionsView.ShowGroupPanel = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.poleWyboruKlienta.Properties)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit poleWyboruKlienta;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.Splitter splitter1;
    }
}