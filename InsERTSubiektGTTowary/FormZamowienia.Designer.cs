namespace InsERTSubiektGTTowary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.przyciskOk = new DevExpress.XtraEditors.SimpleButton();
            this.przyciskAnuluj = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.przyciskOk);
            this.panelControl1.Controls.Add(this.przyciskAnuluj);
            this.panelControl1.Controls.Add(this.splitterControl1);
            this.panelControl1.Controls.Add(this.comboBoxEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 268);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(816, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // przyciskOk
            // 
            this.przyciskOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.przyciskOk.Location = new System.Drawing.Point(727, 54);
            this.przyciskOk.Name = "przyciskOk";
            this.przyciskOk.Size = new System.Drawing.Size(87, 44);
            this.przyciskOk.TabIndex = 3;
            this.przyciskOk.Text = "OK";
            this.przyciskOk.Click += new System.EventHandler(this.przyciskOk_Click);
            // 
            // przyciskAnuluj
            // 
            this.przyciskAnuluj.Dock = System.Windows.Forms.DockStyle.Left;
            this.przyciskAnuluj.Location = new System.Drawing.Point(2, 54);
            this.przyciskAnuluj.Name = "przyciskAnuluj";
            this.przyciskAnuluj.Size = new System.Drawing.Size(94, 44);
            this.przyciskAnuluj.TabIndex = 2;
            this.przyciskAnuluj.Text = "Anuluj";
            this.przyciskAnuluj.Click += new System.EventHandler(this.przyciskAnuluj_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(2, 42);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(812, 12);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxEdit1.EditValue = "Wybierz Kontrahenta";
            this.comboBoxEdit1.Location = new System.Drawing.Point(2, 2);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(812, 40);
            this.comboBoxEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(816, 268);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FormZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 368);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormZamowienia";
            this.Load += new System.EventHandler(this.FormZamowienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton przyciskOk;
        private DevExpress.XtraEditors.SimpleButton przyciskAnuluj;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}
