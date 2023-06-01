namespace HostelApp.Hs
{
    partial class xfrmHostel
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
            this.gdcMain = new DevExpress.XtraGrid.GridControl();
            this.gdvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.txtHostelNo = new DevExpress.XtraEditors.TextEdit();
            this.txtHostelCapacity = new DevExpress.XtraEditors.TextEdit();
            this.txtHostelLocation = new DevExpress.XtraEditors.TextEdit();
            this.txtHostelName = new DevExpress.XtraEditors.TextEdit();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtHostelDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnNew2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdcMain
            // 
            this.gdcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcMain.Location = new System.Drawing.Point(10, 229);
            this.gdcMain.MainView = this.gdvMain;
            this.gdcMain.Name = "gdcMain";
            this.gdcMain.Size = new System.Drawing.Size(867, 277);
            this.gdcMain.TabIndex = 7;
            this.gdcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvMain});
            // 
            // gdvMain
            // 
            this.gdvMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gdvMain.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gdvMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gdvMain.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gdvMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gdvMain.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gdvMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gdvMain.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gdvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gdvMain.GridControl = this.gdcMain;
            this.gdvMain.Name = "gdvMain";
            this.gdvMain.OptionsFind.AlwaysVisible = true;
            this.gdvMain.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvMain_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "HOSTEL NO";
            this.gridColumn1.FieldName = "hstNumber";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 124;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "HOSTEL NAME";
            this.gridColumn2.FieldName = "hstName";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 124;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "HOSTEL LOCATION";
            this.gridColumn3.FieldName = "hstLocation";
            this.gridColumn3.MinWidth = 21;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 124;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "HOSTEL DESCRIPTION";
            this.gridColumn4.FieldName = "hstDescription";
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 124;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "REMARKS ";
            this.gridColumn5.FieldName = "hstRmks";
            this.gridColumn5.MinWidth = 21;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 857;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "CAPACITY";
            this.gridColumn6.FieldName = "hstCapacity";
            this.gridColumn6.MinWidth = 21;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 135;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 61);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Hostel N&o:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Hostel Name:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 124);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Hostel Location:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 160);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Hostel Capacity:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(350, 124);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(402, 123);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtRemarks.Size = new System.Drawing.Size(475, 89);
            this.txtRemarks.TabIndex = 5;
            // 
            // txtHostelNo
            // 
            this.txtHostelNo.Location = new System.Drawing.Point(93, 56);
            this.txtHostelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHostelNo.Name = "txtHostelNo";
            this.txtHostelNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtHostelNo.Size = new System.Drawing.Size(198, 20);
            this.txtHostelNo.TabIndex = 0;
            // 
            // txtHostelCapacity
            // 
            this.txtHostelCapacity.Location = new System.Drawing.Point(93, 154);
            this.txtHostelCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHostelCapacity.Name = "txtHostelCapacity";
            this.txtHostelCapacity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtHostelCapacity.Size = new System.Drawing.Size(198, 20);
            this.txtHostelCapacity.TabIndex = 3;
            // 
            // txtHostelLocation
            // 
            this.txtHostelLocation.Location = new System.Drawing.Point(93, 121);
            this.txtHostelLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHostelLocation.Name = "txtHostelLocation";
            this.txtHostelLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtHostelLocation.Size = new System.Drawing.Size(198, 20);
            this.txtHostelLocation.TabIndex = 2;
            // 
            // txtHostelName
            // 
            this.txtHostelName.Location = new System.Drawing.Point(93, 89);
            this.txtHostelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHostelName.Name = "txtHostelName";
            this.txtHostelName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtHostelName.Size = new System.Drawing.Size(198, 20);
            this.txtHostelName.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = global::HostelApp.Properties.Resources.newemployee_16x16;
            this.btnNew.Location = new System.Drawing.Point(230, 187);
            this.btnNew.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(61, 24);
            this.btnNew.TabIndex = 120;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::HostelApp.Properties.Resources.save_16x16;
            this.btnSave.Location = new System.Drawing.Point(138, 187);
            this.btnSave.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(306, 59);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 13);
            this.labelControl6.TabIndex = 121;
            this.labelControl6.Text = "Hostel Description:";
            // 
            // txtHostelDescription
            // 
            this.txtHostelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostelDescription.Location = new System.Drawing.Point(402, 56);
            this.txtHostelDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHostelDescription.Name = "txtHostelDescription";
            this.txtHostelDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtHostelDescription.Size = new System.Drawing.Size(356, 50);
            this.txtHostelDescription.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.Image = global::HostelApp.Properties.Resources.delete_16x16;
            this.btnDelete.Location = new System.Drawing.Point(809, 56);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 24);
            this.btnDelete.TabIndex = 122;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AllowFocus = false;
            this.tablePanel1.SetColumn(this.btnEdit, 0);
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.ImageOptions.Image = global::HostelApp.Properties.Resources.edit_16x16;
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.tablePanel1.SetRow(this.btnEdit, 0);
            this.btnEdit.Size = new System.Drawing.Size(83, 28);
            this.btnEdit.TabIndex = 123;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.tablePanel1.SetColumn(this.btnSearch, 4);
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.ImageOptions.Image = global::HostelApp.Properties.Resources.search_16x16;
            this.btnSearch.Location = new System.Drawing.Point(373, 3);
            this.btnSearch.Name = "btnSearch";
            this.tablePanel1.SetRow(this.btnSearch, 0);
            this.btnSearch.Size = new System.Drawing.Size(83, 28);
            this.btnSearch.TabIndex = 124;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.txtSearch, 3);
            this.txtSearch.Location = new System.Drawing.Point(274, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetRow(this.txtSearch, 0);
            this.txtSearch.Size = new System.Drawing.Size(94, 20);
            this.txtSearch.TabIndex = 125;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 90F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.btnNew2);
            this.tablePanel1.Controls.Add(this.txtSearch);
            this.tablePanel1.Controls.Add(this.btnEdit);
            this.tablePanel1.Controls.Add(this.btnSearch);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(890, 34);
            this.tablePanel1.TabIndex = 126;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 2);
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl7.Location = new System.Drawing.Point(210, 3);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 0);
            this.labelControl7.Size = new System.Drawing.Size(58, 28);
            this.labelControl7.TabIndex = 128;
            this.labelControl7.Text = "Search Text";
            // 
            // btnNew2
            // 
            this.btnNew2.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew2.Appearance.Options.UseBorderColor = true;
            this.tablePanel1.SetColumn(this.btnNew2, 1);
            this.btnNew2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew2.ImageOptions.Image = global::HostelApp.Properties.Resources.newemployee_16x16;
            this.btnNew2.Location = new System.Drawing.Point(93, 3);
            this.btnNew2.Name = "btnNew2";
            this.tablePanel1.SetRow(this.btnNew2, 0);
            this.btnNew2.Size = new System.Drawing.Size(76, 28);
            this.btnNew2.TabIndex = 127;
            this.btnNew2.Text = "New";
            this.btnNew2.Click += new System.EventHandler(this.btnNew2_Click);
            // 
            // xfrmHostel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 518);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtHostelDescription);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHostelName);
            this.Controls.Add(this.txtHostelLocation);
            this.Controls.Add(this.txtHostelCapacity);
            this.Controls.Add(this.txtHostelNo);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gdcMain);
            this.Controls.Add(this.tablePanel1);
            this.Name = "xfrmHostel";
            this.Text = "Hostels";
            this.Load += new System.EventHandler(this.xfrmHostel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostelDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMain;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraEditors.TextEdit txtHostelNo;
        private DevExpress.XtraEditors.TextEdit txtHostelCapacity;
        private DevExpress.XtraEditors.TextEdit txtHostelLocation;
        private DevExpress.XtraEditors.TextEdit txtHostelName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtHostelDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnNew2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}