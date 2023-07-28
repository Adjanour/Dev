namespace HostelApp.Hs.Notifications
{
    partial class xfrmNotify
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtMobileNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            this.vwHrPeoplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbHostelRoomAllocatorDataSet = new HostelApp.dbHostelRoomAllocatorDataSet();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.vwHrPeoplesTableAdapter = new HostelApp.dbHostelRoomAllocatorDataSetTableAdapters.vwHrPeoplesTableAdapter();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnNew2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.gdcMain = new DevExpress.XtraGrid.GridControl();
            this.gdvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHrPeoplesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHostelRoomAllocatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(321, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Message:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mobile N&o:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(69, 93);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(208, 20);
            this.txtMobileNumber.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(374, 61);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(549, 130);
            this.txtMessage.TabIndex = 6;
            // 
            // vwHrPeoplesBindingSource
            // 
            this.vwHrPeoplesBindingSource.DataMember = "vwHrPeoples";
            this.vwHrPeoplesBindingSource.DataSource = this.dbHostelRoomAllocatorDataSet;
            // 
            // dbHostelRoomAllocatorDataSet
            // 
            this.dbHostelRoomAllocatorDataSet.DataSetName = "dbHostelRoomAllocatorDataSet";
            this.dbHostelRoomAllocatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // vwHrPeoplesTableAdapter
            // 
            this.vwHrPeoplesTableAdapter.ClearBeforeFill = true;
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
            this.tablePanel1.Size = new System.Drawing.Size(935, 32);
            this.tablePanel1.TabIndex = 128;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // btnRefresh
            // 
            this.tablePanel1.SetColumn(this.btnRefresh, 5);
            this.btnRefresh.ImageOptions.Image = global::HostelApp.Properties.Resources.refresh_16x16;
            this.btnRefresh.Location = new System.Drawing.Point(443, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.tablePanel1.SetRow(this.btnRefresh, 0);
            this.btnRefresh.Size = new System.Drawing.Size(26, 26);
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
            this.labelControl13.Size = new System.Drawing.Size(58, 26);
            this.labelControl13.TabIndex = 128;
            this.labelControl13.Text = "Search Text";
            // 
            // btnNew2
            // 
            this.btnNew2.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew2.Appearance.Options.UseBorderColor = true;
            this.tablePanel1.SetColumn(this.btnNew2, 1);
            this.btnNew2.ImageOptions.Image = global::HostelApp.Properties.Resources.newemployee_16x16;
            this.btnNew2.Location = new System.Drawing.Point(93, 3);
            this.btnNew2.Name = "btnNew2";
            this.tablePanel1.SetRow(this.btnNew2, 0);
            this.btnNew2.Size = new System.Drawing.Size(76, 26);
            this.btnNew2.TabIndex = 127;
            this.btnNew2.Text = "New";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.txtSearch, 3);
            this.txtSearch.Location = new System.Drawing.Point(273, 6);
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
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.tablePanel1.SetRow(this.btnEdit, 0);
            this.btnEdit.Size = new System.Drawing.Size(86, 26);
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
            this.btnSearch.Size = new System.Drawing.Size(66, 18);
            this.btnSearch.TabIndex = 124;
            this.btnSearch.Text = "Search";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 20);
            this.txtEmail.TabIndex = 130;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 129;
            this.labelControl4.Text = "Email:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(69, 169);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 131;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(183, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 132;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gdcMain
            // 
            this.gdcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcMain.Location = new System.Drawing.Point(12, 212);
            this.gdcMain.MainView = this.gdvMain;
            this.gdcMain.Name = "gdcMain";
            this.gdcMain.Size = new System.Drawing.Size(911, 326);
            this.gdcMain.TabIndex = 133;
            this.gdcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvMain});
            this.gdcMain.Click += new System.EventHandler(this.gdcMain_Click);
            // 
            // gdvMain
            // 
            this.gdvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gdvMain.GridControl = this.gdcMain;
            this.gdvMain.Name = "gdvMain";
            this.gdvMain.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvMain_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "pplName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mobile";
            this.gridColumn2.FieldName = "pplMobileNo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "EMAIL";
            this.gridColumn3.FieldName = "pplEmail";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "DoB";
            this.gridColumn4.FieldName = "pplDoB";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // xfrmNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 550);
            this.Controls.Add(this.gdcMain);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "xfrmNotify";
            this.Text = "Notify";
            this.Load += new System.EventHandler(this.Notify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHrPeoplesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHostelRoomAllocatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtMobileNumber;
        private DevExpress.XtraEditors.MemoEdit txtMessage;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private dbHostelRoomAllocatorDataSet dbHostelRoomAllocatorDataSet;
        private System.Windows.Forms.BindingSource vwHrPeoplesBindingSource;
        private dbHostelRoomAllocatorDataSetTableAdapters.vwHrPeoplesTableAdapter vwHrPeoplesTableAdapter;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnNew2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraGrid.GridControl gdcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}