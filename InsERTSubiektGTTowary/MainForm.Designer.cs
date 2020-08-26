using System;

namespace InsERTSubiektGTTowary
{
    partial class MainView
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
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.przyciskZamowienia = new DevExpress.XtraEditors.SimpleButton();
            this.tabelaTowarow = new DevExpress.XtraGrid.GridControl();
            this.tabelaWszystkichTowarow = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTowarow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaWszystkichTowarow)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.przyciskZamowienia);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(737, 88);
            this.mainPanel.TabIndex = 0;
            // 
            // przyciskZamowienia
            // 
            this.przyciskZamowienia.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskZamowienia.Appearance.Options.UseFont = true;
            this.przyciskZamowienia.Dock = System.Windows.Forms.DockStyle.Left;
            this.przyciskZamowienia.Location = new System.Drawing.Point(2, 2);
            this.przyciskZamowienia.Name = "przyciskZamowienia";
            this.przyciskZamowienia.Size = new System.Drawing.Size(94, 84);
            this.przyciskZamowienia.TabIndex = 0;
            this.przyciskZamowienia.Text = "Zamów";
            this.przyciskZamowienia.Click += new System.EventHandler(this.przyciskZamowienia_Click);
            // 
            // tabelaTowarow
            // 
            this.tabelaTowarow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaTowarow.Location = new System.Drawing.Point(0, 88);
            this.tabelaTowarow.MainView = this.tabelaWszystkichTowarow;
            this.tabelaTowarow.Name = "tabelaTowarow";
            this.tabelaTowarow.Size = new System.Drawing.Size(737, 254);
            this.tabelaTowarow.TabIndex = 1;
            this.tabelaTowarow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tabelaWszystkichTowarow});
            // 
            // tabelaWszystkichTowarow
            // 
            this.tabelaWszystkichTowarow.GridControl = this.tabelaTowarow;
            this.tabelaWszystkichTowarow.Name = "tabelaWszystkichTowarow";
            this.tabelaWszystkichTowarow.OptionsSelection.MultiSelect = true;
            this.tabelaWszystkichTowarow.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.tabelaTowarow_CellValueChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.tabelaTowarow);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainView";
            this.Text = "Subiekt GT Towary";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTowarow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaWszystkichTowarow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraGrid.GridControl tabelaTowarow;
        private DevExpress.XtraGrid.Views.Grid.GridView tabelaWszystkichTowarow;
        private DevExpress.XtraEditors.SimpleButton przyciskZamowienia;
    }
}

