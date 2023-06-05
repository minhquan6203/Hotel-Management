namespace HotelManager
{
    partial class fAccess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccess));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbAccessManage = new System.Windows.Forms.Label();
            this.gbxAccessCurrent = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAccessRemain = new System.Windows.Forms.GroupBox();
            this.dataGridViewAccessRest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gbxStaffList = new System.Windows.Forms.GroupBox();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInsertStaffType = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbbStaffType = new MetroFramework.Controls.MetroComboBox();
            this.lbStaffTypeName = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddAllFromAccessRemain = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddFromAccessRemain = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddAllFromAccessCurrent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddFromAccessCurrent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxAccessCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxAccessRemain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessRest)).BeginInit();
            this.gbxStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 53);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(796, 15);
            this.bunifuSeparator1.TabIndex = 64;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbAccessManage
            // 
            this.lbAccessManage.AutoSize = true;
            this.lbAccessManage.BackColor = System.Drawing.Color.Transparent;
            this.lbAccessManage.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAccessManage.ForeColor = System.Drawing.Color.Black;
            this.lbAccessManage.Location = new System.Drawing.Point(93, 7);
            this.lbAccessManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccessManage.Name = "lbAccessManage";
            this.lbAccessManage.Size = new System.Drawing.Size(257, 45);
            this.lbAccessManage.TabIndex = 63;
            this.lbAccessManage.Text = "Quyền Truy Cập";
            this.lbAccessManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxAccessCurrent
            // 
            this.gbxAccessCurrent.Controls.Add(this.dataGridView1);
            this.gbxAccessCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAccessCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxAccessCurrent.ForeColor = System.Drawing.Color.Black;
            this.gbxAccessCurrent.Location = new System.Drawing.Point(20, 193);
            this.gbxAccessCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAccessCurrent.Name = "gbxAccessCurrent";
            this.gbxAccessCurrent.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAccessCurrent.Size = new System.Drawing.Size(333, 415);
            this.gbxAccessCurrent.TabIndex = 65;
            this.gbxAccessCurrent.TabStop = false;
            this.gbxAccessCurrent.Text = "Quyền hiện tại";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(4, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(325, 380);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // gbxAccessRemain
            // 
            this.gbxAccessRemain.Controls.Add(this.dataGridViewAccessRest);
            this.gbxAccessRemain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAccessRemain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxAccessRemain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxAccessRemain.Location = new System.Drawing.Point(469, 193);
            this.gbxAccessRemain.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAccessRemain.Name = "gbxAccessRemain";
            this.gbxAccessRemain.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAccessRemain.Size = new System.Drawing.Size(333, 415);
            this.gbxAccessRemain.TabIndex = 66;
            this.gbxAccessRemain.TabStop = false;
            this.gbxAccessRemain.Text = "Các quyền còn lại";
            // 
            // dataGridViewAccessRest
            // 
            this.dataGridViewAccessRest.AllowUserToAddRows = false;
            this.dataGridViewAccessRest.AllowUserToDeleteRows = false;
            this.dataGridViewAccessRest.AllowUserToResizeRows = false;
            this.dataGridViewAccessRest.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAccessRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessRest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAccessRest.ColumnHeadersHeight = 29;
            this.dataGridViewAccessRest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAccessRest.ColumnHeadersVisible = false;
            this.dataGridViewAccessRest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colIdRest});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccessRest.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAccessRest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccessRest.GridColor = System.Drawing.Color.White;
            this.dataGridViewAccessRest.Location = new System.Drawing.Point(4, 31);
            this.dataGridViewAccessRest.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAccessRest.Name = "dataGridViewAccessRest";
            this.dataGridViewAccessRest.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessRest.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAccessRest.RowHeadersVisible = false;
            this.dataGridViewAccessRest.RowHeadersWidth = 51;
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewAccessRest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccessRest.Size = new System.Drawing.Size(325, 380);
            this.dataGridViewAccessRest.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colIdRest
            // 
            this.colIdRest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIdRest.DataPropertyName = "Id";
            this.colIdRest.HeaderText = "Column1";
            this.colIdRest.MinimumWidth = 6;
            this.colIdRest.Name = "colIdRest";
            this.colIdRest.ReadOnly = true;
            this.colIdRest.Visible = false;
            this.colIdRest.Width = 125;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // gbxStaffList
            // 
            this.gbxStaffList.Controls.Add(this.btnClose_);
            this.gbxStaffList.Controls.Add(this.btnInsertStaffType);
            this.gbxStaffList.Controls.Add(this.btnUpdate);
            this.gbxStaffList.Controls.Add(this.cbbStaffType);
            this.gbxStaffList.Controls.Add(this.lbStaffTypeName);
            this.gbxStaffList.Controls.Add(this.btnDelete);
            this.gbxStaffList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxStaffList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxStaffList.Location = new System.Drawing.Point(20, 64);
            this.gbxStaffList.Margin = new System.Windows.Forms.Padding(4);
            this.gbxStaffList.Name = "gbxStaffList";
            this.gbxStaffList.Padding = new System.Windows.Forms.Padding(4);
            this.gbxStaffList.Size = new System.Drawing.Size(783, 129);
            this.gbxStaffList.TabIndex = 67;
            this.gbxStaffList.TabStop = false;
            this.gbxStaffList.Text = "Loại Nhân Viên";
            // 
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose_.BackColor = System.Drawing.Color.White;
            this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
            this.btnClose_.ButtonText = "Đóng";
            this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose_.IdleBorderThickness = 1;
            this.btnClose_.IdleCornerRadius = 20;
            this.btnClose_.IdleFillColor = System.Drawing.Color.White;
            this.btnClose_.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose_.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose_.Location = new System.Drawing.Point(540, 74);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(233, 49);
            this.btnClose_.TabIndex = 55;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose_.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsertStaffType
            // 
            this.btnInsertStaffType.ActiveBorderThickness = 1;
            this.btnInsertStaffType.ActiveCornerRadius = 20;
            this.btnInsertStaffType.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsertStaffType.ActiveForecolor = System.Drawing.Color.White;
            this.btnInsertStaffType.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsertStaffType.BackColor = System.Drawing.Color.White;
            this.btnInsertStaffType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertStaffType.BackgroundImage")));
            this.btnInsertStaffType.ButtonText = "Thêm mới";
            this.btnInsertStaffType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertStaffType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertStaffType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsertStaffType.IdleBorderThickness = 1;
            this.btnInsertStaffType.IdleCornerRadius = 20;
            this.btnInsertStaffType.IdleFillColor = System.Drawing.Color.White;
            this.btnInsertStaffType.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsertStaffType.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsertStaffType.Location = new System.Drawing.Point(540, 17);
            this.btnInsertStaffType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnInsertStaffType.Name = "btnInsertStaffType";
            this.btnInsertStaffType.Size = new System.Drawing.Size(233, 49);
            this.btnInsertStaffType.TabIndex = 54;
            this.btnInsertStaffType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsertStaffType.Click += new System.EventHandler(this.btnInsertStaffType_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Sửa tên";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(283, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(233, 49);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbbStaffType
            // 
            this.cbbStaffType.BackColor = System.Drawing.Color.White;
            this.cbbStaffType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbStaffType.FormattingEnabled = true;
            this.cbbStaffType.ItemHeight = 24;
            this.cbbStaffType.Location = new System.Drawing.Point(25, 66);
            this.cbbStaffType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStaffType.Name = "cbbStaffType";
            this.cbbStaffType.Size = new System.Drawing.Size(232, 30);
            this.cbbStaffType.Style = MetroFramework.MetroColorStyle.Green;
            this.cbbStaffType.TabIndex = 51;
            this.cbbStaffType.UseCustomBackColor = true;
            this.cbbStaffType.UseCustomForeColor = true;
            this.cbbStaffType.UseSelectable = true;
            this.cbbStaffType.UseStyleColors = true;
            this.cbbStaffType.SelectedIndexChanged += new System.EventHandler(this.cbbStaffType_SelectedIndexChanged);
            // 
            // lbStaffTypeName
            // 
            this.lbStaffTypeName.AutoSize = true;
            this.lbStaffTypeName.BackColor = System.Drawing.Color.Transparent;
            this.lbStaffTypeName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStaffTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbStaffTypeName.Location = new System.Drawing.Point(20, 36);
            this.lbStaffTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStaffTypeName.Name = "lbStaffTypeName";
            this.lbStaffTypeName.Size = new System.Drawing.Size(166, 25);
            this.lbStaffTypeName.TabIndex = 28;
            this.lbStaffTypeName.Text = "Tên loại nhân viên:";
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Xoá";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(283, 74);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(233, 49);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddAllFromAccessRemain
            // 
            this.btnAddAllFromAccessRemain.ActiveBorderThickness = 1;
            this.btnAddAllFromAccessRemain.ActiveCornerRadius = 1;
            this.btnAddAllFromAccessRemain.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnAddAllFromAccessRemain.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddAllFromAccessRemain.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnAddAllFromAccessRemain.BackColor = System.Drawing.Color.White;
            this.btnAddAllFromAccessRemain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAllFromAccessRemain.BackgroundImage")));
            this.btnAddAllFromAccessRemain.ButtonText = "<<";
            this.btnAddAllFromAccessRemain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAllFromAccessRemain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAllFromAccessRemain.ForeColor = System.Drawing.Color.Black;
            this.btnAddAllFromAccessRemain.IdleBorderThickness = 1;
            this.btnAddAllFromAccessRemain.IdleCornerRadius = 1;
            this.btnAddAllFromAccessRemain.IdleFillColor = System.Drawing.Color.White;
            this.btnAddAllFromAccessRemain.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddAllFromAccessRemain.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddAllFromAccessRemain.Location = new System.Drawing.Point(388, 262);
            this.btnAddAllFromAccessRemain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddAllFromAccessRemain.Name = "btnAddAllFromAccessRemain";
            this.btnAddAllFromAccessRemain.Size = new System.Drawing.Size(52, 49);
            this.btnAddAllFromAccessRemain.TabIndex = 71;
            this.btnAddAllFromAccessRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAllFromAccessRemain.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnAddFromAccessRemain
            // 
            this.btnAddFromAccessRemain.ActiveBorderThickness = 1;
            this.btnAddFromAccessRemain.ActiveCornerRadius = 1;
            this.btnAddFromAccessRemain.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnAddFromAccessRemain.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddFromAccessRemain.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAddFromAccessRemain.BackColor = System.Drawing.Color.White;
            this.btnAddFromAccessRemain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFromAccessRemain.BackgroundImage")));
            this.btnAddFromAccessRemain.ButtonText = "<";
            this.btnAddFromAccessRemain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFromAccessRemain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFromAccessRemain.ForeColor = System.Drawing.Color.Black;
            this.btnAddFromAccessRemain.IdleBorderThickness = 1;
            this.btnAddFromAccessRemain.IdleCornerRadius = 1;
            this.btnAddFromAccessRemain.IdleFillColor = System.Drawing.Color.White;
            this.btnAddFromAccessRemain.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddFromAccessRemain.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddFromAccessRemain.Location = new System.Drawing.Point(388, 324);
            this.btnAddFromAccessRemain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddFromAccessRemain.Name = "btnAddFromAccessRemain";
            this.btnAddFromAccessRemain.Size = new System.Drawing.Size(52, 49);
            this.btnAddFromAccessRemain.TabIndex = 70;
            this.btnAddFromAccessRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFromAccessRemain.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // btnAddAllFromAccessCurrent
            // 
            this.btnAddAllFromAccessCurrent.ActiveBorderThickness = 1;
            this.btnAddAllFromAccessCurrent.ActiveCornerRadius = 1;
            this.btnAddAllFromAccessCurrent.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnAddAllFromAccessCurrent.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddAllFromAccessCurrent.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAddAllFromAccessCurrent.BackColor = System.Drawing.Color.White;
            this.btnAddAllFromAccessCurrent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAllFromAccessCurrent.BackgroundImage")));
            this.btnAddAllFromAccessCurrent.ButtonText = ">>";
            this.btnAddAllFromAccessCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAllFromAccessCurrent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAllFromAccessCurrent.ForeColor = System.Drawing.Color.Black;
            this.btnAddAllFromAccessCurrent.IdleBorderThickness = 1;
            this.btnAddAllFromAccessCurrent.IdleCornerRadius = 1;
            this.btnAddAllFromAccessCurrent.IdleFillColor = System.Drawing.Color.White;
            this.btnAddAllFromAccessCurrent.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddAllFromAccessCurrent.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddAllFromAccessCurrent.Location = new System.Drawing.Point(388, 507);
            this.btnAddAllFromAccessCurrent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddAllFromAccessCurrent.Name = "btnAddAllFromAccessCurrent";
            this.btnAddAllFromAccessCurrent.Size = new System.Drawing.Size(52, 49);
            this.btnAddAllFromAccessCurrent.TabIndex = 69;
            this.btnAddAllFromAccessCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAllFromAccessCurrent.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnAddFromAccessCurrent
            // 
            this.btnAddFromAccessCurrent.ActiveBorderThickness = 1;
            this.btnAddFromAccessCurrent.ActiveCornerRadius = 1;
            this.btnAddFromAccessCurrent.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnAddFromAccessCurrent.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddFromAccessCurrent.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAddFromAccessCurrent.BackColor = System.Drawing.Color.White;
            this.btnAddFromAccessCurrent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFromAccessCurrent.BackgroundImage")));
            this.btnAddFromAccessCurrent.ButtonText = ">";
            this.btnAddFromAccessCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFromAccessCurrent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFromAccessCurrent.ForeColor = System.Drawing.Color.Black;
            this.btnAddFromAccessCurrent.IdleBorderThickness = 1;
            this.btnAddFromAccessCurrent.IdleCornerRadius = 1;
            this.btnAddFromAccessCurrent.IdleFillColor = System.Drawing.Color.White;
            this.btnAddFromAccessCurrent.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddFromAccessCurrent.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddFromAccessCurrent.Location = new System.Drawing.Point(388, 446);
            this.btnAddFromAccessCurrent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddFromAccessCurrent.Name = "btnAddFromAccessCurrent";
            this.btnAddFromAccessCurrent.Size = new System.Drawing.Size(52, 49);
            this.btnAddFromAccessCurrent.TabIndex = 68;
            this.btnAddFromAccessCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFromAccessCurrent.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(781, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 57;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // fAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxStaffList);
            this.Controls.Add(this.btnAddAllFromAccessRemain);
            this.Controls.Add(this.btnAddFromAccessRemain);
            this.Controls.Add(this.btnAddAllFromAccessCurrent);
            this.Controls.Add(this.btnAddFromAccessCurrent);
            this.Controls.Add(this.gbxAccessRemain);
            this.Controls.Add(this.gbxAccessCurrent);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lbAccessManage);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access";
            this.gbxAccessCurrent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxAccessRemain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessRest)).EndInit();
            this.gbxStaffList.ResumeLayout(false);
            this.gbxStaffList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lbAccessManage;
        private System.Windows.Forms.GroupBox gbxAccessCurrent;
        private System.Windows.Forms.GroupBox gbxAccessRemain;
        private System.Windows.Forms.DataGridView dataGridViewAccessRest;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox gbxStaffList;
        private MetroFramework.Controls.MetroComboBox cbbStaffType;
        private System.Windows.Forms.Label lbStaffTypeName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddAllFromAccessRemain;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddFromAccessRemain;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddAllFromAccessCurrent;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddFromAccessCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRest;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInsertStaffType;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}