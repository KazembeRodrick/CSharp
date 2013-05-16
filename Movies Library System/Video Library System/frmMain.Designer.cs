namespace Movies_Library_System
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMovieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMovieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rptCustomersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rptMoviesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.rptIssuedMoviesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rptReturnedMovieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripSplitButton();
            this.btnAddNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovies = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddNewMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIssueMovies = new System.Windows.Forms.ToolStripSplitButton();
            this.btnIssueMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturnMovies = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnReturnMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDataGridCaption = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.transactionsMenu,
            this.reportsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(894, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersMenuItem,
            this.toolStripSeparator5,
            this.exitMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // usersMenuItem
            // 
            this.usersMenuItem.Name = "usersMenuItem";
            this.usersMenuItem.Size = new System.Drawing.Size(102, 22);
            this.usersMenuItem.Text = "Users";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(99, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitMenuItem.Text = "E&xit";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersMenuItem,
            this.moviesMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // customersMenuItem
            // 
            this.customersMenuItem.Name = "customersMenuItem";
            this.customersMenuItem.Size = new System.Drawing.Size(131, 22);
            this.customersMenuItem.Text = "Customers";
            this.customersMenuItem.Click += new System.EventHandler(this.customersMenuItem_Click);
            // 
            // moviesMenuItem
            // 
            this.moviesMenuItem.Name = "moviesMenuItem";
            this.moviesMenuItem.Size = new System.Drawing.Size(131, 22);
            this.moviesMenuItem.Text = "Movies";
            this.moviesMenuItem.Click += new System.EventHandler(this.moviesMenuItem_Click);
            // 
            // transactionsMenu
            // 
            this.transactionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueMovieMenuItem,
            this.returnMovieMenuItem});
            this.transactionsMenu.Name = "transactionsMenu";
            this.transactionsMenu.Size = new System.Drawing.Size(86, 20);
            this.transactionsMenu.Text = "Transactions";
            // 
            // issueMovieMenuItem
            // 
            this.issueMovieMenuItem.Name = "issueMovieMenuItem";
            this.issueMovieMenuItem.Size = new System.Drawing.Size(145, 22);
            this.issueMovieMenuItem.Text = "Issue Movie";
            this.issueMovieMenuItem.Click += new System.EventHandler(this.issueMovieMenuItem_Click);
            // 
            // returnMovieMenuItem
            // 
            this.returnMovieMenuItem.Name = "returnMovieMenuItem";
            this.returnMovieMenuItem.Size = new System.Drawing.Size(145, 22);
            this.returnMovieMenuItem.Text = "Return Movie";
            this.returnMovieMenuItem.Click += new System.EventHandler(this.returnMovieMenuItem_Click);
            // 
            // reportsMenu
            // 
            this.reportsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rptCustomersMenuItem,
            this.rptMoviesMenuItem,
            this.toolStripMenuItem1,
            this.rptIssuedMoviesMenuItem,
            this.rptReturnedMovieMenuItem});
            this.reportsMenu.Name = "reportsMenu";
            this.reportsMenu.Size = new System.Drawing.Size(59, 20);
            this.reportsMenu.Text = "Reports";
            // 
            // rptCustomersMenuItem
            // 
            this.rptCustomersMenuItem.Name = "rptCustomersMenuItem";
            this.rptCustomersMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rptCustomersMenuItem.Text = "Customers";
            this.rptCustomersMenuItem.Click += new System.EventHandler(this.rptCustomersMenuItem_Click);
            // 
            // rptMoviesMenuItem
            // 
            this.rptMoviesMenuItem.Name = "rptMoviesMenuItem";
            this.rptMoviesMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rptMoviesMenuItem.Text = "Movies";
            this.rptMoviesMenuItem.Click += new System.EventHandler(this.rptMoviesMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // rptIssuedMoviesMenuItem
            // 
            this.rptIssuedMoviesMenuItem.Name = "rptIssuedMoviesMenuItem";
            this.rptIssuedMoviesMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rptIssuedMoviesMenuItem.Text = "Issued Movies";
            this.rptIssuedMoviesMenuItem.Click += new System.EventHandler(this.rptIssuedMoviesMenuItem_Click);
            // 
            // rptReturnedMovieMenuItem
            // 
            this.rptReturnedMovieMenuItem.Name = "rptReturnedMovieMenuItem";
            this.rptReturnedMovieMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rptReturnedMovieMenuItem.Text = "Returned Movies";
            this.rptReturnedMovieMenuItem.Click += new System.EventHandler(this.rptReturnedMovieMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(225, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.aboutToolStripMenuItem.Text = "&About Movies Library System";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnMovies,
            this.toolStripSeparator1,
            this.btnIssueMovies,
            this.btnReturnMovies,
            this.toolStripSeparator4,
            this.btnPrintPreview,
            this.toolStripSeparator2,
            this.btnHelp,
            this.toolStripSeparator3,
            this.lblDataGridCaption,
            this.toolStripSeparator6,
            this.toolStripLabel1});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(894, 55);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnCustomers
            // 
            this.btnCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewCustomer,
            this.btnEditCustomer});
            this.btnCustomers.Image = global::Movies_Library_System.Properties.Resources.fidel_raul_castro256;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(64, 52);
            this.btnCustomers.Text = "New";
            this.btnCustomers.ToolTipText = "Customer Records";
            this.btnCustomers.ButtonClick += new System.EventHandler(this.btnCustomers_ButtonClick);
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(177, 22);
            this.btnAddNewCustomer.Text = "Add New";
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(177, 22);
            this.btnEditCustomer.Text = "Edit Current Record";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMovies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewMovie,
            this.btnEditMovie});
            this.btnMovies.Image = global::Movies_Library_System.Properties.Resources.dvd_rw;
            this.btnMovies.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(61, 52);
            this.btnMovies.Text = "Open";
            this.btnMovies.ToolTipText = "Movies Records";
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnAddNewMovie
            // 
            this.btnAddNewMovie.Name = "btnAddNewMovie";
            this.btnAddNewMovie.Size = new System.Drawing.Size(177, 22);
            this.btnAddNewMovie.Text = "Add New";
            this.btnAddNewMovie.Click += new System.EventHandler(this.btnAddNewMovie_Click);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(177, 22);
            this.btnEditMovie.Text = "Edit Current Record";
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // btnIssueMovies
            // 
            this.btnIssueMovies.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIssueMovies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIssueMovie});
            this.btnIssueMovies.Image = global::Movies_Library_System.Properties.Resources.movie;
            this.btnIssueMovies.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnIssueMovies.Name = "btnIssueMovies";
            this.btnIssueMovies.Size = new System.Drawing.Size(64, 52);
            this.btnIssueMovies.Text = "Print";
            this.btnIssueMovies.ToolTipText = "Issue Movies";
            this.btnIssueMovies.Click += new System.EventHandler(this.btnIssueMovies_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(136, 22);
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovies
            // 
            this.btnReturnMovies.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturnMovies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturnMovie});
            this.btnReturnMovies.Image = global::Movies_Library_System.Properties.Resources.image_x_photo_cd;
            this.btnReturnMovies.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnReturnMovies.Name = "btnReturnMovies";
            this.btnReturnMovies.Size = new System.Drawing.Size(61, 52);
            this.btnReturnMovies.Text = "Return Movie";
            this.btnReturnMovies.Click += new System.EventHandler(this.btnReturnMovies_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(145, 22);
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrintPreview.Image = global::Movies_Library_System.Properties.Resources.document_print_preview;
            this.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(52, 52);
            this.btnPrintPreview.Text = "toolStripButton1";
            this.btnPrintPreview.ToolTipText = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = global::Movies_Library_System.Properties.Resources.symbol_help;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(52, 52);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // lblDataGridCaption
            // 
            this.lblDataGridCaption.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataGridCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataGridCaption.Name = "lblDataGridCaption";
            this.lblDataGridCaption.Size = new System.Drawing.Size(147, 52);
            this.lblDataGridCaption.Text = "Customers Listing";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(306, 52);
            this.toolStripLabel1.Text = "Powered By: www.kazemberodrick.com/c-sharp.html";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(894, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.IsLink = true;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(447, 17);
            this.toolStripStatusLabel.Text = "Support Movies Library System by visiting: www.kazemberodrick.com/c-sharp.html";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.Location = new System.Drawing.Point(0, 79);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(894, 352);
            this.dgvList.TabIndex = 6;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            this.dgvList.Click += new System.EventHandler(this.dgvList_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 453);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Movies Library System v1 - www.kazemberodrick.com";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem usersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsMenu;
        private System.Windows.Forms.ToolStripMenuItem issueMovieMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMovieMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenu;
        private System.Windows.Forms.ToolStripMenuItem rptCustomersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rptMoviesMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rptIssuedMoviesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rptReturnedMovieMenuItem;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblDataGridCaption;
        private System.Windows.Forms.ToolStripButton btnPrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton btnCustomers;
        private System.Windows.Forms.ToolStripMenuItem btnAddNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnEditCustomer;
        private System.Windows.Forms.ToolStripDropDownButton btnMovies;
        private System.Windows.Forms.ToolStripMenuItem btnAddNewMovie;
        private System.Windows.Forms.ToolStripMenuItem btnEditMovie;
        private System.Windows.Forms.ToolStripSplitButton btnIssueMovies;
        private System.Windows.Forms.ToolStripMenuItem btnIssueMovie;
        private System.Windows.Forms.ToolStripDropDownButton btnReturnMovies;
        private System.Windows.Forms.ToolStripMenuItem btnReturnMovie;
    }
}



