namespace HotelManager
{
    partial class fBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bindingBill = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.gbxFunction = new System.Windows.Forms.GroupBox();
            this.btnBillDetail = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCLose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbBillManage = new System.Windows.Forms.Label();
            this.saveBill = new System.Windows.Forms.SaveFileDialog();
            this.gbxBillInfo = new System.Windows.Forms.GroupBox();
            this.numericBookingQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbxBilID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbxRoomID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbBillID = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbBookingQuantity = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbBillIDSearch = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbxBillList = new System.Windows.Forms.GroupBox();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdReciveRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingBill)).BeginInit();
            this.bindingBill.SuspendLayout();
            this.gbxFunction.SuspendLayout();
            this.gbxBillInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookingQuantity)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.gbxBillList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 49);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1584, 15);
            this.bunifuSeparator1.TabIndex = 62;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bindingBill
            // 
            this.bindingBill.AddNewItem = null;
            this.bindingBill.AutoSize = false;
            this.bindingBill.BackColor = System.Drawing.Color.Transparent;
            this.bindingBill.CountItem = this.bindingNavigatorCountItem;
            this.bindingBill.CountItemFormat = "của {0}";
            this.bindingBill.DeleteItem = null;
            this.bindingBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingBill.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingBill.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingBill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bindingBill.Location = new System.Drawing.Point(4, 31);
            this.bindingBill.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingBill.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingBill.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingBill.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingBill.Name = "bindingBill";
            this.bindingBill.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingBill.Size = new System.Drawing.Size(543, 35);
            this.bindingBill.TabIndex = 29;
            this.bindingBill.Text = "binding";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "của {0}";
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
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(52, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
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
            // gbxFunction
            // 
            this.gbxFunction.Controls.Add(this.btnBillDetail);
            this.gbxFunction.Controls.Add(this.btnCLose_);
            this.gbxFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFunction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxFunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxFunction.Location = new System.Drawing.Point(5, 511);
            this.gbxFunction.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFunction.Name = "gbxFunction";
            this.gbxFunction.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFunction.Size = new System.Drawing.Size(276, 152);
            this.gbxFunction.TabIndex = 60;
            this.gbxFunction.TabStop = false;
            this.gbxFunction.Text = "Chức Năng";
            // 
            // btnBillDetail
            // 
            this.btnBillDetail.ActiveBorderThickness = 1;
            this.btnBillDetail.ActiveCornerRadius = 20;
            this.btnBillDetail.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillDetail.ActiveForecolor = System.Drawing.Color.White;
            this.btnBillDetail.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillDetail.BackColor = System.Drawing.Color.White;
            this.btnBillDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBillDetail.BackgroundImage")));
            this.btnBillDetail.ButtonText = "Chi Tiết Hóa Đơn";
            this.btnBillDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillDetail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillDetail.IdleBorderThickness = 1;
            this.btnBillDetail.IdleCornerRadius = 20;
            this.btnBillDetail.IdleFillColor = System.Drawing.Color.White;
            this.btnBillDetail.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillDetail.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillDetail.Location = new System.Drawing.Point(15, 36);
            this.btnBillDetail.Margin = new System.Windows.Forms.Padding(5);
            this.btnBillDetail.Name = "btnBillDetail";
            this.btnBillDetail.Size = new System.Drawing.Size(233, 49);
            this.btnBillDetail.TabIndex = 50;
            this.btnBillDetail.TabStop = false;
            this.btnBillDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBillDetail.Click += new System.EventHandler(this.BtnSeenBill_Click);
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
            this.btnCLose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCLose_.IdleBorderThickness = 1;
            this.btnCLose_.IdleCornerRadius = 20;
            this.btnCLose_.IdleFillColor = System.Drawing.Color.White;
            this.btnCLose_.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCLose_.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCLose_.Location = new System.Drawing.Point(15, 94);
            this.btnCLose_.Margin = new System.Windows.Forms.Padding(5);
            this.btnCLose_.Name = "btnCLose_";
            this.btnCLose_.Size = new System.Drawing.Size(233, 49);
            this.btnCLose_.TabIndex = 52;
            this.btnCLose_.TabStop = false;
            this.btnCLose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCLose_.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lbBillManage
            // 
            this.lbBillManage.AutoSize = true;
            this.lbBillManage.BackColor = System.Drawing.Color.Transparent;
            this.lbBillManage.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBillManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBillManage.Location = new System.Drawing.Point(72, 6);
            this.lbBillManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBillManage.Name = "lbBillManage";
            this.lbBillManage.Size = new System.Drawing.Size(276, 45);
            this.lbBillManage.TabIndex = 61;
            this.lbBillManage.Text = "Quản Lí Hoá Đơn";
            this.lbBillManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBillManage.Click += new System.EventHandler(this.label6_Click);
            // 
            // saveBill
            // 
            this.saveBill.FileName = "Danh sách dịch vụ";
            this.saveBill.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // gbxBillInfo
            // 
            this.gbxBillInfo.Controls.Add(this.numericBookingQuantity);
            this.gbxBillInfo.Controls.Add(this.tbxBilID);
            this.gbxBillInfo.Controls.Add(this.tbxRoomID);
            this.gbxBillInfo.Controls.Add(this.txbPrice);
            this.gbxBillInfo.Controls.Add(this.lbBillID);
            this.gbxBillInfo.Controls.Add(this.lbRoomID);
            this.gbxBillInfo.Controls.Add(this.lbPrice);
            this.gbxBillInfo.Controls.Add(this.lbBookingQuantity);
            this.gbxBillInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxBillInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxBillInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxBillInfo.Location = new System.Drawing.Point(8, 226);
            this.gbxBillInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBillInfo.Name = "gbxBillInfo";
            this.gbxBillInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBillInfo.Size = new System.Drawing.Size(273, 288);
            this.gbxBillInfo.TabIndex = 1;
            this.gbxBillInfo.TabStop = false;
            this.gbxBillInfo.Text = "Thông tin hoá đơn";
            // 
            // numericBookingQuantity
            // 
            this.numericBookingQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericBookingQuantity.Location = new System.Drawing.Point(15, 177);
            this.numericBookingQuantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericBookingQuantity.Name = "numericBookingQuantity";
            this.numericBookingQuantity.Size = new System.Drawing.Size(233, 34);
            this.numericBookingQuantity.TabIndex = 63;
            this.numericBookingQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxBilID
            // 
            this.tbxBilID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxBilID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxBilID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxBilID.BorderThickness = 1;
            this.tbxBilID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxBilID.Enabled = false;
            this.tbxBilID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBilID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxBilID.isPassword = false;
            this.tbxBilID.Location = new System.Drawing.Point(15, 56);
            this.tbxBilID.Margin = new System.Windows.Forms.Padding(0);
            this.tbxBilID.Name = "tbxBilID";
            this.tbxBilID.Size = new System.Drawing.Size(233, 36);
            this.tbxBilID.TabIndex = 62;
            this.tbxBilID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxRoomID
            // 
            this.tbxRoomID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxRoomID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxRoomID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxRoomID.BorderThickness = 1;
            this.tbxRoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxRoomID.Enabled = false;
            this.tbxRoomID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxRoomID.isPassword = false;
            this.tbxRoomID.Location = new System.Drawing.Point(15, 117);
            this.tbxRoomID.Margin = new System.Windows.Forms.Padding(0);
            this.tbxRoomID.Name = "tbxRoomID";
            this.tbxRoomID.Size = new System.Drawing.Size(233, 36);
            this.tbxRoomID.TabIndex = 1;
            this.tbxRoomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.Color.White;
            this.txbPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.BorderThickness = 1;
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.Enabled = false;
            this.txbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.isPassword = false;
            this.txbPrice.Location = new System.Drawing.Point(15, 239);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(233, 36);
            this.txbPrice.TabIndex = 59;
            this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbBillID
            // 
            this.lbBillID.AutoSize = true;
            this.lbBillID.BackColor = System.Drawing.Color.Transparent;
            this.lbBillID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBillID.Location = new System.Drawing.Point(15, 31);
            this.lbBillID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(118, 25);
            this.lbBillID.TabIndex = 22;
            this.lbBillID.Text = "Mã hoá đơn:";
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.BackColor = System.Drawing.Color.Transparent;
            this.lbRoomID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbRoomID.Location = new System.Drawing.Point(15, 92);
            this.lbRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(103, 25);
            this.lbRoomID.TabIndex = 24;
            this.lbRoomID.Text = "Mã phòng:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPrice.Location = new System.Drawing.Point(15, 214);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(82, 25);
            this.lbPrice.TabIndex = 57;
            this.lbPrice.Text = "Đơn giá:";
            this.lbPrice.Click += new System.EventHandler(this.label13_Click);
            // 
            // lbBookingQuantity
            // 
            this.lbBookingQuantity.AutoSize = true;
            this.lbBookingQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbBookingQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBookingQuantity.Location = new System.Drawing.Point(15, 153);
            this.lbBookingQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookingQuantity.Name = "lbBookingQuantity";
            this.lbBookingQuantity.Size = new System.Drawing.Size(131, 25);
            this.lbBookingQuantity.TabIndex = 58;
            this.lbBookingQuantity.Text = "Số ngày thuê: ";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.txbSearch);
            this.gbxSearch.Controls.Add(this.lbBillIDSearch);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.btnCancel);
            this.gbxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxSearch.Location = new System.Drawing.Point(8, 64);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSearch.Size = new System.Drawing.Size(273, 162);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Tìm kiếm";
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
            this.txbSearch.Location = new System.Drawing.Point(12, 61);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(233, 36);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearch.OnValueChanged += new System.EventHandler(this.txbSearch_OnValueChanged);
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSearch_KeyPress);
            // 
            // lbBillIDSearch
            // 
            this.lbBillIDSearch.AutoSize = true;
            this.lbBillIDSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbBillIDSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBillIDSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBillIDSearch.Location = new System.Drawing.Point(15, 36);
            this.lbBillIDSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBillIDSearch.Name = "lbBillIDSearch";
            this.lbBillIDSearch.Size = new System.Drawing.Size(118, 25);
            this.lbBillIDSearch.TabIndex = 28;
            this.lbBillIDSearch.Text = "Mã hóa đơn: ";
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
            this.btnSearch.Location = new System.Drawing.Point(15, 103);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(233, 49);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(15, 103);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(233, 49);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // gbxBillList
            // 
            this.gbxBillList.Controls.Add(this.dataGridViewBill);
            this.gbxBillList.Controls.Add(this.bindingBill);
            this.gbxBillList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxBillList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxBillList.Location = new System.Drawing.Point(289, 59);
            this.gbxBillList.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBillList.Name = "gbxBillList";
            this.gbxBillList.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBillList.Size = new System.Drawing.Size(551, 604);
            this.gbxBillList.TabIndex = 59;
            this.gbxBillList.TabStop = false;
            this.gbxBillList.Text = "Danh Sách Hoá Đơn";
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.AllowUserToResizeRows = false;
            this.dataGridViewBill.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBill.ColumnHeadersHeight = 36;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colIdReciveRoom,
            this.Column1,
            this.colPrice,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBill.GridColor = System.Drawing.Color.White;
            this.dataGridViewBill.Location = new System.Drawing.Point(4, 66);
            this.dataGridViewBill.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBill.RowHeadersVisible = false;
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBill.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewBill.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBill.Size = new System.Drawing.Size(543, 534);
            this.dataGridViewBill.TabIndex = 28;
            this.dataGridViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellContentClick);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colID.DataPropertyName = "id";
            this.colID.FillWeight = 30F;
            this.colID.HeaderText = "Mã hóa đơn";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 151;
            // 
            // colIdReciveRoom
            // 
            this.colIdReciveRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIdReciveRoom.DataPropertyName = "roomName";
            this.colIdReciveRoom.FillWeight = 30F;
            this.colIdReciveRoom.HeaderText = "Mã phòng";
            this.colIdReciveRoom.MinimumWidth = 6;
            this.colIdReciveRoom.Name = "colIdReciveRoom";
            this.colIdReciveRoom.ReadOnly = true;
            this.colIdReciveRoom.Width = 135;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "discount";
            this.Column1.HeaderText = "Số ngày thuê";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 145;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrice.DataPropertyName = "TotalPrice";
            this.colPrice.FillWeight = 30F;
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 112;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 145;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(825, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 56;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxFunction);
            this.Controls.Add(this.lbBillManage);
            this.Controls.Add(this.gbxBillInfo);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxBillList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBill";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FBill_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bindingBill)).EndInit();
            this.bindingBill.ResumeLayout(false);
            this.bindingBill.PerformLayout();
            this.gbxFunction.ResumeLayout(false);
            this.gbxBillInfo.ResumeLayout(false);
            this.gbxBillInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookingQuantity)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxBillList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.GroupBox gbxFunction;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBillDetail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCLose_;
        private System.Windows.Forms.Label lbBillManage;
        private System.Windows.Forms.GroupBox gbxBillInfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxRoomID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPrice;
        private System.Windows.Forms.Label lbBillID;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.GroupBox gbxSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label lbBillIDSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.GroupBox gbxBillList;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.BindingNavigator bindingBill;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.SaveFileDialog saveBill;
        private System.Windows.Forms.Label lbBookingQuantity;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxBilID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericBookingQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdReciveRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}