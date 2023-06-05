namespace HotelManager
{
    partial class fParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParameter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gbxFunction = new System.Windows.Forms.GroupBox();
            this.btnAddParameter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCLose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbxParameterList = new System.Windows.Forms.GroupBox();
            this.dataGridViewParameter = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSurcharge = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbNameParameter = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupParameter = new System.Windows.Forms.GroupBox();
            this.comboboxName = new MetroFramework.Controls.MetroComboBox();
            this.lbDescribe = new System.Windows.Forms.Label();
            this.txbDescribe = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbValue = new System.Windows.Forms.Label();
            this.txbValue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbNameParameter_ = new System.Windows.Forms.Label();
            this.labelParameterManage = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.saveParameter = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.gbxFunction.SuspendLayout();
            this.gbxParameterList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSurcharge)).BeginInit();
            this.bindingSurcharge.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.groupParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(918, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 45;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // gbxFunction
            // 
            this.gbxFunction.Controls.Add(this.btnAddParameter);
            this.gbxFunction.Controls.Add(this.btnCLose_);
            this.gbxFunction.Controls.Add(this.btnUpdate);
            this.gbxFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFunction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxFunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxFunction.Location = new System.Drawing.Point(5, 456);
            this.gbxFunction.Name = "gbxFunction";
            this.gbxFunction.Size = new System.Drawing.Size(252, 172);
            this.gbxFunction.TabIndex = 68;
            this.gbxFunction.TabStop = false;
            this.gbxFunction.Text = "Chức Năng";
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.ActiveBorderThickness = 1;
            this.btnAddParameter.ActiveCornerRadius = 20;
            this.btnAddParameter.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddParameter.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddParameter.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddParameter.BackColor = System.Drawing.Color.White;
            this.btnAddParameter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddParameter.BackgroundImage")));
            this.btnAddParameter.ButtonText = "Thêm quy định";
            this.btnAddParameter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddParameter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddParameter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddParameter.IdleBorderThickness = 1;
            this.btnAddParameter.IdleCornerRadius = 20;
            this.btnAddParameter.IdleFillColor = System.Drawing.Color.White;
            this.btnAddParameter.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddParameter.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddParameter.Location = new System.Drawing.Point(26, 36);
            this.btnAddParameter.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(203, 40);
            this.btnAddParameter.TabIndex = 26;
            this.btnAddParameter.TabStop = false;
            this.btnAddParameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCLose_
            // 
            this.btnCLose_.ActiveBorderThickness = 1;
            this.btnCLose_.ActiveCornerRadius = 20;
            this.btnCLose_.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCLose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnCLose_.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCLose_.BackColor = System.Drawing.Color.White;
            this.btnCLose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCLose_.BackgroundImage")));
            this.btnCLose_.ButtonText = "Đóng";
            this.btnCLose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLose_.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCLose_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCLose_.IdleBorderThickness = 1;
            this.btnCLose_.IdleCornerRadius = 20;
            this.btnCLose_.IdleFillColor = System.Drawing.Color.White;
            this.btnCLose_.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCLose_.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCLose_.Location = new System.Drawing.Point(26, 129);
            this.btnCLose_.Margin = new System.Windows.Forms.Padding(6);
            this.btnCLose_.Name = "btnCLose_";
            this.btnCLose_.Size = new System.Drawing.Size(203, 40);
            this.btnCLose_.TabIndex = 25;
            this.btnCLose_.TabStop = false;
            this.btnCLose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCLose_.Click += new System.EventHandler(this.BtnCLose1_Click);
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
            this.btnUpdate.ButtonText = "Cập nhật";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(26, 82);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // gbxParameterList
            // 
            this.gbxParameterList.Controls.Add(this.dataGridViewParameter);
            this.gbxParameterList.Controls.Add(this.bindingSurcharge);
            this.gbxParameterList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxParameterList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxParameterList.Location = new System.Drawing.Point(263, 64);
            this.gbxParameterList.Name = "gbxParameterList";
            this.gbxParameterList.Size = new System.Drawing.Size(664, 561);
            this.gbxParameterList.TabIndex = 3;
            this.gbxParameterList.TabStop = false;
            this.gbxParameterList.Text = "Danh sách quy định";
            // 
            // dataGridViewParameter
            // 
            this.dataGridViewParameter.AllowUserToAddRows = false;
            this.dataGridViewParameter.AllowUserToDeleteRows = false;
            this.dataGridViewParameter.AllowUserToResizeRows = false;
            this.dataGridViewParameter.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewParameter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParameter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colValue,
            this.Describ,
            this.DateUpdate,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParameter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParameter.GridColor = System.Drawing.Color.White;
            this.dataGridViewParameter.Location = new System.Drawing.Point(3, 61);
            this.dataGridViewParameter.Name = "dataGridViewParameter";
            this.dataGridViewParameter.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParameter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewParameter.RowHeadersVisible = false;
            this.dataGridViewParameter.RowHeadersWidth = 51;
            this.dataGridViewParameter.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewParameter.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewParameter.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewParameter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParameter.Size = new System.Drawing.Size(658, 497);
            this.dataGridViewParameter.TabIndex = 28;
            this.dataGridViewParameter.SelectionChanged += new System.EventHandler(this.DataGridSurcharge_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 73;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colValue.DataPropertyName = "value";
            this.colValue.HeaderText = "Giá trị";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            this.colValue.Width = 95;
            // 
            // Describ
            // 
            this.Describ.HeaderText = "Miêu tả";
            this.Describ.MinimumWidth = 6;
            this.Describ.Name = "Describ";
            this.Describ.ReadOnly = true;
            this.Describ.Width = 379;
            // 
            // DateUpdate
            // 
            this.DateUpdate.HeaderText = "Ngày cập nhật";
            this.DateUpdate.MinimumWidth = 6;
            this.DateUpdate.Name = "DateUpdate";
            this.DateUpdate.ReadOnly = true;
            this.DateUpdate.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // bindingSurcharge
            // 
            this.bindingSurcharge.AddNewItem = null;
            this.bindingSurcharge.CountItem = this.bindingNavigatorCountItem;
            this.bindingSurcharge.DeleteItem = null;
            this.bindingSurcharge.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingSurcharge.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
            this.bindingSurcharge.Location = new System.Drawing.Point(3, 30);
            this.bindingSurcharge.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingSurcharge.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingSurcharge.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingSurcharge.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingSurcharge.Name = "bindingSurcharge";
            this.bindingSurcharge.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingSurcharge.Size = new System.Drawing.Size(658, 31);
            this.bindingSurcharge.TabIndex = 29;
            this.bindingSurcharge.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.AutoSize = false;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Xuất";
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.txbSearch);
            this.gbxSearch.Controls.Add(this.lbNameParameter);
            this.gbxSearch.Controls.Add(this.btnCancel);
            this.gbxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxSearch.Location = new System.Drawing.Point(5, 76);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(252, 155);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Tìm Kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(27, 103);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 40);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.BorderThickness = 1;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.isPassword = false;
            this.txbSearch.Location = new System.Drawing.Point(26, 61);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(203, 29);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSearch_KeyPress);
            // 
            // lbNameParameter
            // 
            this.lbNameParameter.AutoSize = true;
            this.lbNameParameter.BackColor = System.Drawing.Color.Transparent;
            this.lbNameParameter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbNameParameter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNameParameter.Location = new System.Drawing.Point(22, 30);
            this.lbNameParameter.Name = "lbNameParameter";
            this.lbNameParameter.Size = new System.Drawing.Size(124, 25);
            this.lbNameParameter.TabIndex = 28;
            this.lbNameParameter.Text = "Tên quy định:";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Red;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.Red;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Huỷ Tìm";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Red;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(27, 103);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupParameter
            // 
            this.groupParameter.Controls.Add(this.comboboxName);
            this.groupParameter.Controls.Add(this.lbDescribe);
            this.groupParameter.Controls.Add(this.txbDescribe);
            this.groupParameter.Controls.Add(this.lbValue);
            this.groupParameter.Controls.Add(this.txbValue);
            this.groupParameter.Controls.Add(this.lbNameParameter_);
            this.groupParameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupParameter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupParameter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupParameter.Location = new System.Drawing.Point(5, 237);
            this.groupParameter.Name = "groupParameter";
            this.groupParameter.Size = new System.Drawing.Size(252, 221);
            this.groupParameter.TabIndex = 1;
            this.groupParameter.TabStop = false;
            this.groupParameter.Text = "Thông tin qui định";
            // 
            // comboboxName
            // 
            this.comboboxName.FormattingEnabled = true;
            this.comboboxName.ItemHeight = 24;
            this.comboboxName.Location = new System.Drawing.Point(26, 65);
            this.comboboxName.Name = "comboboxName";
            this.comboboxName.Size = new System.Drawing.Size(203, 30);
            this.comboboxName.Style = MetroFramework.MetroColorStyle.Green;
            this.comboboxName.TabIndex = 47;
            this.comboboxName.UseSelectable = true;
            // 
            // lbDescribe
            // 
            this.lbDescribe.AutoSize = true;
            this.lbDescribe.BackColor = System.Drawing.Color.Transparent;
            this.lbDescribe.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbDescribe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDescribe.Location = new System.Drawing.Point(22, 152);
            this.lbDescribe.Name = "lbDescribe";
            this.lbDescribe.Size = new System.Drawing.Size(80, 25);
            this.lbDescribe.TabIndex = 26;
            this.lbDescribe.Text = "Miêu tả:";
            // 
            // txbDescribe
            // 
            this.txbDescribe.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDescribe.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDescribe.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDescribe.BorderThickness = 1;
            this.txbDescribe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDescribe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescribe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDescribe.isPassword = false;
            this.txbDescribe.Location = new System.Drawing.Point(26, 177);
            this.txbDescribe.Margin = new System.Windows.Forms.Padding(0);
            this.txbDescribe.Name = "txbDescribe";
            this.txbDescribe.Size = new System.Drawing.Size(203, 29);
            this.txbDescribe.TabIndex = 3;
            this.txbDescribe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.BackColor = System.Drawing.Color.Transparent;
            this.lbValue.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbValue.Location = new System.Drawing.Point(22, 98);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(67, 25);
            this.lbValue.TabIndex = 24;
            this.lbValue.Text = "Giá trị:";
            // 
            // txbValue
            // 
            this.txbValue.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbValue.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbValue.BorderThickness = 1;
            this.txbValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbValue.isPassword = false;
            this.txbValue.Location = new System.Drawing.Point(26, 123);
            this.txbValue.Margin = new System.Windows.Forms.Padding(0);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(203, 29);
            this.txbValue.TabIndex = 1;
            this.txbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbValue.OnValueChanged += new System.EventHandler(this.txbValue_OnValueChanged);
            this.txbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPrice_KeyPress);
            // 
            // lbNameParameter_
            // 
            this.lbNameParameter_.AutoSize = true;
            this.lbNameParameter_.BackColor = System.Drawing.Color.Transparent;
            this.lbNameParameter_.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbNameParameter_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNameParameter_.Location = new System.Drawing.Point(22, 37);
            this.lbNameParameter_.Name = "lbNameParameter_";
            this.lbNameParameter_.Size = new System.Drawing.Size(124, 25);
            this.lbNameParameter_.TabIndex = 22;
            this.lbNameParameter_.Text = "Tên quy định:";
            // 
            // labelParameterManage
            // 
            this.labelParameterManage.AutoSize = true;
            this.labelParameterManage.BackColor = System.Drawing.Color.Transparent;
            this.labelParameterManage.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelParameterManage.ForeColor = System.Drawing.Color.Black;
            this.labelParameterManage.Location = new System.Drawing.Point(73, 9);
            this.labelParameterManage.Name = "labelParameterManage";
            this.labelParameterManage.Size = new System.Drawing.Size(161, 45);
            this.labelParameterManage.TabIndex = 63;
            this.labelParameterManage.Text = "Quy Định";
            this.labelParameterManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelParameterManage.Click += new System.EventHandler(this.labelName_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 57);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(900, 13);
            this.bunifuSeparator1.TabIndex = 67;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // saveParameter
            // 
            this.saveParameter.FileName = "Danh sách phụ thu";
            this.saveParameter.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // fParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxFunction);
            this.Controls.Add(this.gbxParameterList);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.groupParameter);
            this.Controls.Add(this.labelParameterManage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuSeparator1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSurcharge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FParameter_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FParameter_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.gbxFunction.ResumeLayout(false);
            this.gbxParameterList.ResumeLayout(false);
            this.gbxParameterList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSurcharge)).EndInit();
            this.bindingSurcharge.ResumeLayout(false);
            this.bindingSurcharge.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.groupParameter.ResumeLayout(false);
            this.groupParameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox gbxFunction;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCLose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private System.Windows.Forms.GroupBox gbxParameterList;
        private System.Windows.Forms.DataGridView dataGridViewParameter;
        private System.Windows.Forms.BindingNavigator bindingSurcharge;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox gbxSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label lbNameParameter;
        private System.Windows.Forms.GroupBox groupParameter;
        private System.Windows.Forms.Label lbDescribe;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbDescribe;
        private System.Windows.Forms.Label lbValue;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbValue;
        private System.Windows.Forms.Label lbNameParameter_;
        private System.Windows.Forms.Label labelParameterManage;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroComboBox comboboxName;
        private System.Windows.Forms.SaveFileDialog saveParameter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}