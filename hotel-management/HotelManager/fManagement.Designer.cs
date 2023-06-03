namespace HotelManager
{
    partial class fManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManagement));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.TileBookRoom = new MetroFramework.Controls.MetroTile();
            this.TileAccess = new MetroFramework.Controls.MetroTile();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnNavigationPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIntroduce = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccountProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TileRoom = new MetroFramework.Controls.MetroTile();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.TileBill = new MetroFramework.Controls.MetroTile();
            this.TileRules = new MetroFramework.Controls.MetroTile();
            this.TileReport = new MetroFramework.Controls.MetroTile();
            this.TileEmployee = new MetroFramework.Controls.MetroTile();
            this.titlePay = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.titleBookRoom = new MetroFramework.Controls.MetroTile();
            this.panelLeft.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.TileBookRoom);
            this.panelLeft.Controls.Add(this.TileAccess);
            this.panelLeft.Controls.Add(this.gunaPanel1);
            this.panelLeft.Controls.Add(this.TileRoom);
            this.panelLeft.Controls.Add(this.bunifuSeparator1);
            this.panelLeft.Controls.Add(this.TileBill);
            this.panelLeft.Controls.Add(this.TileRules);
            this.panelLeft.Controls.Add(this.TileReport);
            this.panelLeft.Controls.Add(this.TileEmployee);
            this.panelLeft.Controls.Add(this.titlePay);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.btnClose);
            this.panelLeft.Controls.Add(this.titleBookRoom);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1488, 718);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // TileBookRoom
            // 
            this.TileBookRoom.ActiveControl = null;
            this.TileBookRoom.BackColor = System.Drawing.Color.Silver;
            this.TileBookRoom.ForeColor = System.Drawing.Color.DimGray;
            this.TileBookRoom.Location = new System.Drawing.Point(470, 91);
            this.TileBookRoom.Margin = new System.Windows.Forms.Padding(4);
            this.TileBookRoom.Name = "TileBookRoom";
            this.TileBookRoom.Size = new System.Drawing.Size(182, 347);
            this.TileBookRoom.TabIndex = 58;
            this.TileBookRoom.Text = "Đặt phòng";
            this.TileBookRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileBookRoom.TileImage = ((System.Drawing.Image)(resources.GetObject("TileBookRoom.TileImage")));
            this.TileBookRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileBookRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileBookRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileBookRoom.UseCustomBackColor = true;
            this.TileBookRoom.UseCustomForeColor = true;
            this.TileBookRoom.UseSelectable = true;
            this.TileBookRoom.UseStyleColors = true;
            this.TileBookRoom.UseTileImage = true;
            // 
            // TileAccess
            // 
            this.TileAccess.ActiveControl = null;
            this.TileAccess.BackColor = System.Drawing.Color.Silver;
            this.TileAccess.ForeColor = System.Drawing.Color.DimGray;
            this.TileAccess.Location = new System.Drawing.Point(1049, 90);
            this.TileAccess.Margin = new System.Windows.Forms.Padding(4);
            this.TileAccess.Name = "TileAccess";
            this.TileAccess.Size = new System.Drawing.Size(204, 348);
            this.TileAccess.TabIndex = 57;
            this.TileAccess.Text = "Quyền truy cập";
            this.TileAccess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileAccess.TileImage = ((System.Drawing.Image)(resources.GetObject("TileAccess.TileImage")));
            this.TileAccess.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileAccess.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileAccess.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileAccess.UseCustomBackColor = true;
            this.TileAccess.UseCustomForeColor = true;
            this.TileAccess.UseSelectable = true;
            this.TileAccess.UseStyleColors = true;
            this.TileAccess.UseTileImage = true;
            this.TileAccess.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.Controls.Add(this.btnNavigationPanel);
            this.gunaPanel1.Controls.Add(this.btnIntroduce);
            this.gunaPanel1.Controls.Add(this.btnAccountProfile);
            this.gunaPanel1.Controls.Add(this.btnLogOut);
            this.gunaPanel1.Controls.Add(this.btnHelp);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(236, 718);
            this.gunaPanel1.TabIndex = 56;
            // 
            // btnNavigationPanel
            // 
            this.btnNavigationPanel.Activecolor = System.Drawing.Color.Gray;
            this.btnNavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnNavigationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNavigationPanel.BorderRadius = 0;
            this.btnNavigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnNavigationPanel.ButtonText = "";
            this.btnNavigationPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavigationPanel.DisabledColor = System.Drawing.Color.Gray;
            this.btnNavigationPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNavigationPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNavigationPanel.Iconimage")));
            this.btnNavigationPanel.Iconimage_right = null;
            this.btnNavigationPanel.Iconimage_right_Selected = null;
            this.btnNavigationPanel.Iconimage_Selected = null;
            this.btnNavigationPanel.IconMarginLeft = 0;
            this.btnNavigationPanel.IconMarginRight = 0;
            this.btnNavigationPanel.IconRightVisible = true;
            this.btnNavigationPanel.IconRightZoom = 0D;
            this.btnNavigationPanel.IconVisible = true;
            this.btnNavigationPanel.IconZoom = 50D;
            this.btnNavigationPanel.IsTab = false;
            this.btnNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.btnNavigationPanel.Margin = new System.Windows.Forms.Padding(5);
            this.btnNavigationPanel.Name = "btnNavigationPanel";
            this.btnNavigationPanel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnNavigationPanel.OnHovercolor = System.Drawing.Color.Gray;
            this.btnNavigationPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNavigationPanel.selected = false;
            this.btnNavigationPanel.Size = new System.Drawing.Size(255, 55);
            this.btnNavigationPanel.TabIndex = 6;
            this.btnNavigationPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavigationPanel.Textcolor = System.Drawing.Color.White;
            this.btnNavigationPanel.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNavigationPanel.Click += new System.EventHandler(this.btnNavigationPanel_Click_1);
            // 
            // btnIntroduce
            // 
            this.btnIntroduce.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnIntroduce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIntroduce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnIntroduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIntroduce.BorderRadius = 0;
            this.btnIntroduce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnIntroduce.ButtonText = "    Giới thiệu";
            this.btnIntroduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntroduce.DisabledColor = System.Drawing.Color.Gray;
            this.btnIntroduce.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIntroduce.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIntroduce.Iconimage")));
            this.btnIntroduce.Iconimage_right = null;
            this.btnIntroduce.Iconimage_right_Selected = null;
            this.btnIntroduce.Iconimage_Selected = null;
            this.btnIntroduce.IconMarginLeft = 0;
            this.btnIntroduce.IconMarginRight = 0;
            this.btnIntroduce.IconRightVisible = true;
            this.btnIntroduce.IconRightZoom = 0D;
            this.btnIntroduce.IconVisible = true;
            this.btnIntroduce.IconZoom = 50D;
            this.btnIntroduce.IsTab = false;
            this.btnIntroduce.Location = new System.Drawing.Point(0, 645);
            this.btnIntroduce.Margin = new System.Windows.Forms.Padding(5);
            this.btnIntroduce.Name = "btnIntroduce";
            this.btnIntroduce.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnIntroduce.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnIntroduce.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIntroduce.selected = false;
            this.btnIntroduce.Size = new System.Drawing.Size(236, 49);
            this.btnIntroduce.TabIndex = 2;
            this.btnIntroduce.Text = "    Giới thiệu";
            this.btnIntroduce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntroduce.Textcolor = System.Drawing.Color.DimGray;
            this.btnIntroduce.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIntroduce.Click += new System.EventHandler(this.btnIntroduce_Click);
            // 
            // btnAccountProfile
            // 
            this.btnAccountProfile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnAccountProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccountProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnAccountProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccountProfile.BorderRadius = 0;
            this.btnAccountProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAccountProfile.ButtonText = "    Thông tin cá nhân";
            this.btnAccountProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountProfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccountProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccountProfile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccountProfile.Iconimage")));
            this.btnAccountProfile.Iconimage_right = null;
            this.btnAccountProfile.Iconimage_right_Selected = null;
            this.btnAccountProfile.Iconimage_Selected = null;
            this.btnAccountProfile.IconMarginLeft = 0;
            this.btnAccountProfile.IconMarginRight = 0;
            this.btnAccountProfile.IconRightVisible = true;
            this.btnAccountProfile.IconRightZoom = 0D;
            this.btnAccountProfile.IconVisible = true;
            this.btnAccountProfile.IconZoom = 50D;
            this.btnAccountProfile.IsTab = false;
            this.btnAccountProfile.Location = new System.Drawing.Point(0, 468);
            this.btnAccountProfile.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccountProfile.Name = "btnAccountProfile";
            this.btnAccountProfile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnAccountProfile.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnAccountProfile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccountProfile.selected = false;
            this.btnAccountProfile.Size = new System.Drawing.Size(236, 49);
            this.btnAccountProfile.TabIndex = 5;
            this.btnAccountProfile.Text = "    Thông tin cá nhân";
            this.btnAccountProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountProfile.Textcolor = System.Drawing.Color.DimGray;
            this.btnAccountProfile.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAccountProfile.Click += new System.EventHandler(this.btnAccountProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLogOut.ButtonText = "    Đăng xuất";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 50D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(0, 527);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnLogOut.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(236, 49);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "    Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Textcolor = System.Drawing.Color.DimGray;
            this.btnLogOut.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHelp.ButtonText = "    Trợ giúp";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.DisabledColor = System.Drawing.Color.Gray;
            this.btnHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHelp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHelp.Iconimage")));
            this.btnHelp.Iconimage_right = null;
            this.btnHelp.Iconimage_right_Selected = null;
            this.btnHelp.Iconimage_Selected = null;
            this.btnHelp.IconMarginLeft = 0;
            this.btnHelp.IconMarginRight = 0;
            this.btnHelp.IconRightVisible = true;
            this.btnHelp.IconRightZoom = 0D;
            this.btnHelp.IconVisible = true;
            this.btnHelp.IconZoom = 50D;
            this.btnHelp.IsTab = false;
            this.btnHelp.Location = new System.Drawing.Point(0, 586);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnHelp.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.selected = false;
            this.btnHelp.Size = new System.Drawing.Size(236, 49);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "    Trợ giúp";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Textcolor = System.Drawing.Color.DimGray;
            this.btnHelp.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // TileRoom
            // 
            this.TileRoom.ActiveControl = null;
            this.TileRoom.BackColor = System.Drawing.Color.Silver;
            this.TileRoom.ForeColor = System.Drawing.Color.DimGray;
            this.TileRoom.Location = new System.Drawing.Point(284, 91);
            this.TileRoom.Margin = new System.Windows.Forms.Padding(4);
            this.TileRoom.Name = "TileRoom";
            this.TileRoom.Size = new System.Drawing.Size(178, 347);
            this.TileRoom.TabIndex = 55;
            this.TileRoom.Text = "Quản Lý phòng";
            this.TileRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileRoom.TileImage = ((System.Drawing.Image)(resources.GetObject("TileRoom.TileImage")));
            this.TileRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileRoom.UseCustomBackColor = true;
            this.TileRoom.UseCustomForeColor = true;
            this.TileRoom.UseSelectable = true;
            this.TileRoom.UseStyleColors = true;
            this.TileRoom.UseTileImage = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(39, 52);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1172, 12);
            this.bunifuSeparator1.TabIndex = 54;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // TileBill
            // 
            this.TileBill.ActiveControl = null;
            this.TileBill.BackColor = System.Drawing.Color.Silver;
            this.TileBill.ForeColor = System.Drawing.Color.DimGray;
            this.TileBill.Location = new System.Drawing.Point(670, 91);
            this.TileBill.Margin = new System.Windows.Forms.Padding(4);
            this.TileBill.Name = "TileBill";
            this.TileBill.Size = new System.Drawing.Size(368, 173);
            this.TileBill.TabIndex = 44;
            this.TileBill.Text = "Quản Lý hóa đơn";
            this.TileBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileBill.TileImage = ((System.Drawing.Image)(resources.GetObject("TileBill.TileImage")));
            this.TileBill.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileBill.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileBill.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileBill.UseCustomBackColor = true;
            this.TileBill.UseCustomForeColor = true;
            this.TileBill.UseSelectable = true;
            this.TileBill.UseStyleColors = true;
            this.TileBill.UseTileImage = true;
            this.TileBill.Click += new System.EventHandler(this.metroTile16_Click);
            // 
            // TileRules
            // 
            this.TileRules.ActiveControl = null;
            this.TileRules.BackColor = System.Drawing.Color.Silver;
            this.TileRules.ForeColor = System.Drawing.Color.DimGray;
            this.TileRules.Location = new System.Drawing.Point(864, 469);
            this.TileRules.Margin = new System.Windows.Forms.Padding(4);
            this.TileRules.Name = "TileRules";
            this.TileRules.Size = new System.Drawing.Size(368, 166);
            this.TileRules.TabIndex = 41;
            this.TileRules.Text = "Quy định";
            this.TileRules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileRules.TileImage = ((System.Drawing.Image)(resources.GetObject("TileRules.TileImage")));
            this.TileRules.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileRules.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileRules.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileRules.UseCustomBackColor = true;
            this.TileRules.UseCustomForeColor = true;
            this.TileRules.UseSelectable = true;
            this.TileRules.UseStyleColors = true;
            this.TileRules.UseTileImage = true;
            this.TileRules.Click += new System.EventHandler(this.metroTile13_Click);
            // 
            // TileReport
            // 
            this.TileReport.ActiveControl = null;
            this.TileReport.BackColor = System.Drawing.Color.Silver;
            this.TileReport.ForeColor = System.Drawing.Color.DimGray;
            this.TileReport.Location = new System.Drawing.Point(479, 469);
            this.TileReport.Margin = new System.Windows.Forms.Padding(4);
            this.TileReport.Name = "TileReport";
            this.TileReport.Size = new System.Drawing.Size(368, 166);
            this.TileReport.TabIndex = 36;
            this.TileReport.Text = "Báo cáo doanh thu";
            this.TileReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileReport.TileImage = ((System.Drawing.Image)(resources.GetObject("TileReport.TileImage")));
            this.TileReport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileReport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileReport.UseCustomBackColor = true;
            this.TileReport.UseCustomForeColor = true;
            this.TileReport.UseSelectable = true;
            this.TileReport.UseStyleColors = true;
            this.TileReport.UseTileImage = true;
            this.TileReport.Click += new System.EventHandler(this.title_Click);
            // 
            // TileEmployee
            // 
            this.TileEmployee.ActiveControl = null;
            this.TileEmployee.BackColor = System.Drawing.Color.Silver;
            this.TileEmployee.ForeColor = System.Drawing.Color.DimGray;
            this.TileEmployee.Location = new System.Drawing.Point(1261, 90);
            this.TileEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.TileEmployee.Name = "TileEmployee";
            this.TileEmployee.Size = new System.Drawing.Size(204, 348);
            this.TileEmployee.TabIndex = 29;
            this.TileEmployee.Text = "Quản lý nhân viên";
            this.TileEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileEmployee.TileImage = ((System.Drawing.Image)(resources.GetObject("TileEmployee.TileImage")));
            this.TileEmployee.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileEmployee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileEmployee.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileEmployee.UseCustomBackColor = true;
            this.TileEmployee.UseCustomForeColor = true;
            this.TileEmployee.UseSelectable = true;
            this.TileEmployee.UseStyleColors = true;
            this.TileEmployee.UseTileImage = true;
            this.TileEmployee.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // titlePay
            // 
            this.titlePay.ActiveControl = null;
            this.titlePay.BackColor = System.Drawing.Color.Silver;
            this.titlePay.ForeColor = System.Drawing.Color.DimGray;
            this.titlePay.Location = new System.Drawing.Point(670, 272);
            this.titlePay.Margin = new System.Windows.Forms.Padding(4);
            this.titlePay.Name = "titlePay";
            this.titlePay.Size = new System.Drawing.Size(368, 166);
            this.titlePay.TabIndex = 27;
            this.titlePay.Text = "Thanh toán hóa đơn";
            this.titlePay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.titlePay.TileImage = ((System.Drawing.Image)(resources.GetObject("titlePay.TileImage")));
            this.titlePay.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlePay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titlePay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.titlePay.UseCustomBackColor = true;
            this.titlePay.UseCustomForeColor = true;
            this.titlePay.UseSelectable = true;
            this.titlePay.UseStyleColors = true;
            this.titlePay.UseTileImage = true;
            this.titlePay.Click += new System.EventHandler(this.titlePay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 45);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quản Lý Khách Sạn";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1457, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 20;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // titleBookRoom
            // 
            this.titleBookRoom.ActiveControl = null;
            this.titleBookRoom.BackColor = System.Drawing.Color.Silver;
            this.titleBookRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleBookRoom.ForeColor = System.Drawing.Color.DimGray;
            this.titleBookRoom.Location = new System.Drawing.Point(39, 90);
            this.titleBookRoom.Margin = new System.Windows.Forms.Padding(4);
            this.titleBookRoom.Name = "titleBookRoom";
            this.titleBookRoom.Size = new System.Drawing.Size(180, 340);
            this.titleBookRoom.TabIndex = 17;
            this.titleBookRoom.Text = "Đặt Phòng";
            this.titleBookRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.titleBookRoom.TileImage = ((System.Drawing.Image)(resources.GetObject("titleBookRoom.TileImage")));
            this.titleBookRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleBookRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titleBookRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.titleBookRoom.UseCustomBackColor = true;
            this.titleBookRoom.UseCustomForeColor = true;
            this.titleBookRoom.UseSelectable = true;
            this.titleBookRoom.UseStyleColors = true;
            this.titleBookRoom.UseTileImage = true;
            this.titleBookRoom.Click += new System.EventHandler(this.titleSignUpRoom_Click);
            // 
            // fManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1488, 718);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí khách sạn";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelLeft;
        private MetroFramework.Controls.MetroTile titleBookRoom;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile TileEmployee;
        private MetroFramework.Controls.MetroTile titlePay;
        private MetroFramework.Controls.MetroTile TileReport;
        private MetroFramework.Controls.MetroTile TileBill;
        private MetroFramework.Controls.MetroTile TileRules;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
        private Bunifu.Framework.UI.BunifuFlatButton btnIntroduce;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroTile TileRoom;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnNavigationPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccountProfile;
        private MetroFramework.Controls.MetroTile TileAccess;
        private MetroFramework.Controls.MetroTile TileBookRoom;
    }
}