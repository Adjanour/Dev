namespace HostelApp.SysAdmin
{
    partial class xfrmUserMangement
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
            this.colrmRoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblcBlockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrmtRoomTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrmRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrmOccupancyStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrmRoomDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpplName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpplMobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgndName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrmRmks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colflrFloorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtMobileNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cbxGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.ckeStatus = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxRoomCapacity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gdvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrmRoomNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcMain = new DevExpress.XtraGrid.GridControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnNew2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtRoomName = new DevExpress.XtraEditors.TextEdit();
            this.txtRoomNumber = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRoomCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colrmRoomName
            // 
            this.colrmRoomName.Caption = "ROOM NAME";
            this.colrmRoomName.FieldName = "rmRoomName";
            this.colrmRoomName.Name = "colrmRoomName";
            this.colrmRoomName.Visible = true;
            this.colrmRoomName.VisibleIndex = 1;
            this.colrmRoomName.Width = 105;
            // 
            // colblcBlockName
            // 
            this.colblcBlockName.Caption = "BLOCK";
            this.colblcBlockName.FieldName = "blcBlockName";
            this.colblcBlockName.Name = "colblcBlockName";
            this.colblcBlockName.Visible = true;
            this.colblcBlockName.VisibleIndex = 3;
            this.colblcBlockName.Width = 101;
            // 
            // colrmtRoomTypeName
            // 
            this.colrmtRoomTypeName.Caption = "ROOM TYPE";
            this.colrmtRoomTypeName.FieldName = "rmtRoomTypeName";
            this.colrmtRoomTypeName.Name = "colrmtRoomTypeName";
            this.colrmtRoomTypeName.Visible = true;
            this.colrmtRoomTypeName.VisibleIndex = 4;
            this.colrmtRoomTypeName.Width = 80;
            // 
            // colrmRate
            // 
            this.colrmRate.Caption = "RATE";
            this.colrmRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colrmRate.FieldName = "rmRate";
            this.colrmRate.Name = "colrmRate";
            this.colrmRate.Visible = true;
            this.colrmRate.VisibleIndex = 5;
            this.colrmRate.Width = 72;
            // 
            // colrmOccupancyStatus
            // 
            this.colrmOccupancyStatus.Caption = "OCCUPANCY STATUS";
            this.colrmOccupancyStatus.FieldName = "rmOccupancyStatus";
            this.colrmOccupancyStatus.Name = "colrmOccupancyStatus";
            this.colrmOccupancyStatus.Visible = true;
            this.colrmOccupancyStatus.VisibleIndex = 6;
            this.colrmOccupancyStatus.Width = 100;
            // 
            // colrmRoomDescription
            // 
            this.colrmRoomDescription.Caption = "DESCRIPTION";
            this.colrmRoomDescription.FieldName = "rmRoomDescription";
            this.colrmRoomDescription.Name = "colrmRoomDescription";
            this.colrmRoomDescription.Visible = true;
            this.colrmRoomDescription.VisibleIndex = 7;
            this.colrmRoomDescription.Width = 86;
            // 
            // colpplName
            // 
            this.colpplName.Caption = "NAME";
            this.colpplName.FieldName = "pplName";
            this.colpplName.Name = "colpplName";
            this.colpplName.Visible = true;
            this.colpplName.VisibleIndex = 8;
            this.colpplName.Width = 32;
            // 
            // colpplMobileNo
            // 
            this.colpplMobileNo.Caption = "MOBILE No";
            this.colpplMobileNo.FieldName = "pplMobileNo";
            this.colpplMobileNo.Name = "colpplMobileNo";
            this.colpplMobileNo.Visible = true;
            this.colpplMobileNo.VisibleIndex = 9;
            this.colpplMobileNo.Width = 70;
            // 
            // colgndName
            // 
            this.colgndName.Caption = "GENDER";
            this.colgndName.FieldName = "gndName";
            this.colgndName.Name = "colgndName";
            this.colgndName.Visible = true;
            this.colgndName.VisibleIndex = 10;
            this.colgndName.Width = 61;
            // 
            // colrmRmks
            // 
            this.colrmRmks.Caption = "REMARKS";
            this.colrmRmks.FieldName = "rmRmks";
            this.colrmRmks.Name = "colrmRmks";
            this.colrmRmks.Visible = true;
            this.colrmRmks.VisibleIndex = 11;
            this.colrmRmks.Width = 800;
            // 
            // colflrFloorName
            // 
            this.colflrFloorName.Caption = "FLOOR";
            this.colflrFloorName.FieldName = "flrFloorName";
            this.colflrFloorName.Name = "colflrFloorName";
            this.colflrFloorName.Visible = true;
            this.colflrFloorName.VisibleIndex = 2;
            this.colflrFloorName.Width = 104;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(45, 139);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(51, 13);
            this.labelControl15.TabIndex = 224;
            this.labelControl15.Text = "Mobile N&o:";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(101, 136);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(202, 20);
            this.txtMobileNo.TabIndex = 223;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(588, 88);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(38, 13);
            this.labelControl11.TabIndex = 218;
            this.labelControl11.Text = "Gender:";
            // 
            // cbxGender
            // 
            this.cbxGender.Location = new System.Drawing.Point(633, 82);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGender.Size = new System.Drawing.Size(112, 20);
            this.cbxGender.TabIndex = 217;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.Image = global::HostelApp.Properties.Resources.delete_16x16;
            this.btnDelete.Location = new System.Drawing.Point(867, 58);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 28);
            this.btnDelete.TabIndex = 214;
            this.btnDelete.Text = "Delete";
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = global::HostelApp.Properties.Resources.newemployee_16x16;
            this.btnNew.Location = new System.Drawing.Point(234, 219);
            this.btnNew.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 28);
            this.btnNew.TabIndex = 213;
            this.btnNew.Text = "New";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::HostelApp.Properties.Resources.save_16x16;
            this.btnSave.Location = new System.Drawing.Point(129, 219);
            this.btnSave.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 28);
            this.btnSave.TabIndex = 212;
            this.btnSave.Text = "Save";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(381, 137);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Size = new System.Drawing.Size(555, 110);
            this.txtDescription.TabIndex = 211;
            // 
            // ckeStatus
            // 
            this.ckeStatus.Location = new System.Drawing.Point(465, 79);
            this.ckeStatus.Name = "ckeStatus";
            this.ckeStatus.Properties.Caption = "checkEdit1";
            this.ckeStatus.Size = new System.Drawing.Size(17, 19);
            this.ckeStatus.TabIndex = 210;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(318, 138);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 13);
            this.labelControl9.TabIndex = 209;
            this.labelControl9.Text = "Remarks:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(424, 307);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(3, 13);
            this.labelControl6.TabIndex = 206;
            this.labelControl6.Text = " ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(368, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 13);
            this.labelControl4.TabIndex = 204;
            this.labelControl4.Text = "Occupancy Status:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 203;
            this.labelControl3.Text = "Password:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(67, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 202;
            this.labelControl2.Text = "Email:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 201;
            this.labelControl1.Text = "Username:";
            // 
            // cbxRoomCapacity
            // 
            this.cbxRoomCapacity.Location = new System.Drawing.Point(101, 107);
            this.cbxRoomCapacity.Name = "cbxRoomCapacity";
            this.cbxRoomCapacity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxRoomCapacity.Size = new System.Drawing.Size(202, 20);
            this.cbxRoomCapacity.TabIndex = 200;
            // 
            // gdvMain
            // 
            this.gdvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrmRoomNo,
            this.colrmRoomName,
            this.colflrFloorName,
            this.colblcBlockName,
            this.colrmtRoomTypeName,
            this.colrmRate,
            this.colrmOccupancyStatus,
            this.colrmRoomDescription,
            this.colpplName,
            this.colpplMobileNo,
            this.colgndName,
            this.colrmRmks});
            this.gdvMain.GridControl = this.gdcMain;
            this.gdvMain.Name = "gdvMain";
            this.gdvMain.OptionsBehavior.Editable = false;
            this.gdvMain.OptionsFind.AlwaysVisible = true;
            this.gdvMain.OptionsPrint.UsePrintStyles = false;
            this.gdvMain.OptionsView.ColumnAutoWidth = false;
            // 
            // colrmRoomNo
            // 
            this.colrmRoomNo.Caption = "ROOM NUMBER";
            this.colrmRoomNo.FieldName = "rmRoomNo";
            this.colrmRoomNo.Name = "colrmRoomNo";
            this.colrmRoomNo.Visible = true;
            this.colrmRoomNo.VisibleIndex = 0;
            this.colrmRoomNo.Width = 93;
            // 
            // gdcMain
            // 
            this.gdcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcMain.Location = new System.Drawing.Point(12, 278);
            this.gdcMain.MainView = this.gdvMain;
            this.gdcMain.Name = "gdcMain";
            this.gdcMain.Size = new System.Drawing.Size(924, 424);
            this.gdcMain.TabIndex = 194;
            this.gdcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvMain});
            // 
            // btnRefresh
            // 
            this.tablePanel1.SetColumn(this.btnRefresh, 5);
            this.btnRefresh.ImageOptions.Image = global::HostelApp.Properties.Resources.refresh_16x16;
            this.btnRefresh.Location = new System.Drawing.Point(443, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.tablePanel1.SetRow(this.btnRefresh, 0);
            this.btnRefresh.Size = new System.Drawing.Size(26, 19);
            this.btnRefresh.TabIndex = 132;
            // 
            // labelControl13
            // 
            this.tablePanel1.SetColumn(this.labelControl13, 2);
            this.labelControl13.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl13.Location = new System.Drawing.Point(210, 3);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.tablePanel1.SetRow(this.labelControl13, 0);
            this.labelControl13.Size = new System.Drawing.Size(58, 28);
            this.labelControl13.TabIndex = 128;
            this.labelControl13.Text = "Search Text";
            // 
            // btnNew2
            // 
            this.btnNew2.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew2.Appearance.Options.UseBorderColor = true;
            this.tablePanel1.SetColumn(this.btnNew2, 1);
            this.btnNew2.ImageOptions.Image = global::HostelApp.Properties.Resources.newemployee_16x16;
            this.btnNew2.Location = new System.Drawing.Point(93, 7);
            this.btnNew2.Name = "btnNew2";
            this.tablePanel1.SetRow(this.btnNew2, 0);
            this.btnNew2.Size = new System.Drawing.Size(76, 20);
            this.btnNew2.TabIndex = 127;
            this.btnNew2.Text = "New";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.txtSearch, 3);
            this.txtSearch.Location = new System.Drawing.Point(273, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSearch.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Properties.Appearance.Options.UseBackColor = true;
            this.txtSearch.Properties.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetRow(this.txtSearch, 0);
            this.txtSearch.Size = new System.Drawing.Size(96, 20);
            this.txtSearch.TabIndex = 125;
            // 
            // btnEdit
            // 
            this.btnEdit.AllowFocus = false;
            this.tablePanel1.SetColumn(this.btnEdit, 0);
            this.btnEdit.ImageOptions.Image = global::HostelApp.Properties.Resources.edit_16x16;
            this.btnEdit.Location = new System.Drawing.Point(3, 6);
            this.btnEdit.Name = "btnEdit";
            this.tablePanel1.SetRow(this.btnEdit, 0);
            this.btnEdit.Size = new System.Drawing.Size(86, 21);
            this.btnEdit.TabIndex = 123;
            this.btnEdit.Text = "Edit";
            // 
            // btnSearch
            // 
            this.tablePanel1.SetColumn(this.btnSearch, 4);
            this.btnSearch.ImageOptions.Image = global::HostelApp.Properties.Resources.search_16x16;
            this.btnSearch.Location = new System.Drawing.Point(373, 7);
            this.btnSearch.Name = "btnSearch";
            this.tablePanel1.SetRow(this.btnSearch, 0);
            this.btnSearch.Size = new System.Drawing.Size(66, 20);
            this.btnSearch.TabIndex = 124;
            this.btnSearch.Text = "Search";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 90F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 70F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 170.28F)});
            this.tablePanel1.Controls.Add(this.btnRefresh);
            this.tablePanel1.Controls.Add(this.labelControl13);
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
            this.tablePanel1.Size = new System.Drawing.Size(948, 34);
            this.tablePanel1.TabIndex = 193;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ROOM TYPE";
            this.gridColumn1.FieldName = "rmtRoomTypeName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 119;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(101, 81);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(202, 20);
            this.txtRoomName.TabIndex = 198;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(101, 55);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(202, 20);
            this.txtRoomNumber.TabIndex = 195;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(363, 51);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 225;
            // 
            // xfrmUserMangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.ckeStatus);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbxRoomCapacity);
            this.Controls.Add(this.gdcMain);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtRoomNumber);
            this.Name = "xfrmUserMangement";
            this.Text = "xfrmUserMangement";
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRoomCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colrmRoomName;
        private DevExpress.XtraGrid.Columns.GridColumn colblcBlockName;
        private DevExpress.XtraGrid.Columns.GridColumn colrmtRoomTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colrmRate;
        private DevExpress.XtraGrid.Columns.GridColumn colrmOccupancyStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colrmRoomDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colpplName;
        private DevExpress.XtraGrid.Columns.GridColumn colpplMobileNo;
        private DevExpress.XtraGrid.Columns.GridColumn colgndName;
        private DevExpress.XtraGrid.Columns.GridColumn colrmRmks;
        private DevExpress.XtraGrid.Columns.GridColumn colflrFloorName;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtMobileNo;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGender;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.CheckEdit ckeStatus;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxRoomCapacity;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMain;
        private DevExpress.XtraGrid.Columns.GridColumn colrmRoomNo;
        private DevExpress.XtraGrid.GridControl gdcMain;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnNew2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txtRoomName;
        private DevExpress.XtraEditors.TextEdit txtRoomNumber;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}