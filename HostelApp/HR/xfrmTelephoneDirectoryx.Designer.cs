namespace HostelApp.HR
{
    partial class xfrmTelephoneDirectoryx
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
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbxGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gdcMain = new DevExpress.XtraGrid.GridControl();
            this.gdvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.txtOtherName = new DevExpress.XtraEditors.TextEdit();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtMobileNo = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(418, 31);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(82, 74);
            this.pictureEdit1.TabIndex = 120;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(371, 33);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 119;
            this.labelControl3.Text = "Picture:";
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = global::HostelApp.Properties.Resources.newemployee_16x16;
            this.btnNew.Location = new System.Drawing.Point(178, 231);
            this.btnNew.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(66, 29);
            this.btnNew.TabIndex = 118;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.Image = global::HostelApp.Properties.Resources.delete_16x16;
            this.btnDelete.Location = new System.Drawing.Point(871, 31);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 29);
            this.btnDelete.TabIndex = 117;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::HostelApp.Properties.Resources.save_16x16;
            this.btnSave.Location = new System.Drawing.Point(95, 231);
            this.btnSave.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 29);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(49, 115);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 115;
            this.labelControl2.Text = "Gender:";
            // 
            // cbxGender
            // 
            this.cbxGender.Location = new System.Drawing.Point(95, 113);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGender.Size = new System.Drawing.Size(232, 20);
            this.cbxGender.TabIndex = 114;
            this.cbxGender.SelectedIndexChanged += new System.EventHandler(this.cbxGender_SelectedIndexChanged);
            // 
            // gdcMain
            // 
            this.gdcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.gdcMain.Location = new System.Drawing.Point(20, 282);
            this.gdcMain.MainView = this.gdvMain;
            this.gdcMain.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.gdcMain.Name = "gdcMain";
            this.gdcMain.Size = new System.Drawing.Size(918, 335);
            this.gdcMain.TabIndex = 113;
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
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gdvMain.DetailHeight = 1002;
            this.gdvMain.GridControl = this.gdcMain;
            this.gdvMain.Name = "gdvMain";
            this.gdvMain.OptionsFind.AlwaysVisible = true;
            this.gdvMain.OptionsView.ColumnAutoWidth = false;
            this.gdvMain.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvMain_FocusedRowChanged_1);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "NAME";
            this.gridColumn1.FieldName = "pplName";
            this.gridColumn1.MinWidth = 76;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 154;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MOBILE No";
            this.gridColumn2.FieldName = "pplMobileNo";
            this.gridColumn2.MinWidth = 76;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 171;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ADDRESS";
            this.gridColumn3.MinWidth = 76;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 142;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "EMAIL";
            this.gridColumn4.FieldName = "pplEmail";
            this.gridColumn4.MinWidth = 76;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 167;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "GENDER";
            this.gridColumn5.FieldName = "gndName";
            this.gridColumn5.MinWidth = 76;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "REMARKS";
            this.gridColumn6.FieldName = "pplRmks";
            this.gridColumn6.MinWidth = 76;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 10000;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "REMARKS";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 64;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "GENDER";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 64;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(95, 198);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 20);
            this.txtAddress.TabIndex = 112;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 201);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 111;
            this.labelControl1.Text = "Address:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(418, 113);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(520, 147);
            this.txtRemarks.TabIndex = 110;
            // 
            // txtOtherName
            // 
            this.txtOtherName.Location = new System.Drawing.Point(95, 85);
            this.txtOtherName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtOtherName.Name = "txtOtherName";
            this.txtOtherName.Size = new System.Drawing.Size(232, 20);
            this.txtOtherName.TabIndex = 109;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 31);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(232, 20);
            this.txtFirstName.TabIndex = 108;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 58);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(232, 20);
            this.txtLastName.TabIndex = 107;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(95, 141);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(232, 20);
            this.txtMobileNo.TabIndex = 106;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 170);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 20);
            this.txtEmail.TabIndex = 105;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(57, 171);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 104;
            this.labelControl4.Text = "Email:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(363, 115);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 13);
            this.labelControl11.TabIndex = 103;
            this.labelControl11.Text = "Remarks:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(36, 149);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 13);
            this.labelControl9.TabIndex = 102;
            this.labelControl9.Text = "Mobile &No:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 88);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 101;
            this.labelControl6.Text = "Other Names:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 58);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 100;
            this.labelControl5.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(31, 33);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 99;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowFocus = false;
            this.btnUpdate.ImageOptions.Image = global::HostelApp.Properties.Resources.updatefield_16x16;
            this.btnUpdate.Location = new System.Drawing.Point(261, 231);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 29);
            this.btnUpdate.TabIndex = 124;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // xfrmTelephoneDirectoryx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 636);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.gdcMain);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtOtherName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblFirstName);
            this.Name = "xfrmTelephoneDirectoryx";
            this.Text = "Telephone Directory";
            this.Load += new System.EventHandler(this.xfrmTelephoneDirectoryx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGender;
        private DevExpress.XtraGrid.GridControl gdcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraEditors.TextEdit txtOtherName;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtMobileNo;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
    }
}