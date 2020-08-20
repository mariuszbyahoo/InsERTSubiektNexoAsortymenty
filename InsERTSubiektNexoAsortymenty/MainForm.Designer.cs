using System;

namespace InsERTSubiektNexoAsortymenty
{
    partial class MainForm
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
            this.mainTable = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelsSplitter = new DevExpress.XtraEditors.SplitterControl();
            this.orderButton = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSplitter1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(2, 63);
            this.mainTable.MainView = this.gridView1;
            this.mainTable.Name = "mainTable";
            this.mainTable.Size = new System.Drawing.Size(733, 277);
            this.mainTable.TabIndex = 0;
            this.mainTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.mainTable.Load += new System.EventHandler(this.MainForm_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.mainTable;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelsSplitter);
            this.panelControl1.Controls.Add(this.mainTable);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(737, 342);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.buttonSplitter1);
            this.panelControl2.Controls.Add(this.orderButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(733, 61);
            this.panelControl2.TabIndex = 0;
            // 
            // panelsSplitter
            // 
            this.panelsSplitter.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelsSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsSplitter.Enabled = false;
            this.panelsSplitter.Location = new System.Drawing.Point(2, 63);
            this.panelsSplitter.Name = "panelsSplitter";
            this.panelsSplitter.Size = new System.Drawing.Size(733, 12);
            this.panelsSplitter.TabIndex = 1;
            this.panelsSplitter.TabStop = false;
            // 
            // orderButton
            // 
            this.orderButton.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.orderButton.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderButton.Appearance.Options.UseBackColor = true;
            this.orderButton.Appearance.Options.UseFont = true;
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderButton.Location = new System.Drawing.Point(2, 2);
            this.orderButton.Margin = new System.Windows.Forms.Padding(10);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(94, 57);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Zamów";
            // 
            // buttonSplitter1
            // 
            this.buttonSplitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSplitter1.Enabled = false;
            this.buttonSplitter1.Location = new System.Drawing.Point(96, 2);
            this.buttonSplitter1.Name = "buttonSplitter1";
            this.buttonSplitter1.Size = new System.Drawing.Size(12, 57);
            this.buttonSplitter1.TabIndex = 1;
            this.buttonSplitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Asortyment";
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.mainTable.DataSource = _dto.PodajWszystkieAsortymenty();

            for (int i = 0; i < this.gridView1.Columns.Count; i++)
            {
                if(this.gridView1.Columns[i].FieldName.Equals("Nazwa") ||
                    this.gridView1.Columns[i].FieldName.Equals("CenaEwidencyjna") ||
                    this.gridView1.Columns[i].FieldName.Equals("Symbol") ||
                    this.gridView1.Columns[i].FieldName.Equals("Id") ||
                    this.gridView1.Columns[i].FieldName.Equals("Opis"))
                {
                    var columnName = this.gridView1.Columns[i].FieldName;
                    this.gridView1.Columns[i].Visible = true;
                }
                else
                {
                    this.gridView1.Columns[i].Visible = false;
                }
            }
        }

        private DevExpress.XtraGrid.GridControl mainTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitterControl panelsSplitter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton orderButton;
        private DevExpress.XtraEditors.SplitterControl buttonSplitter1;
    }
}

