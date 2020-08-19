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
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.MainView = this.gridView1;
            this.mainTable.Name = "mainTable";
            this.mainTable.Size = new System.Drawing.Size(737, 342);
            this.mainTable.TabIndex = 0;
            this.mainTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.mainTable.Load += new System.EventHandler(this.MainForm_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.mainTable;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.mainTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Asortyment";
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.mainTable.DataSource = _dto.PodajAsortyment();

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
    }
}

