namespace Project3
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.homeTab = new MetroFramework.Controls.MetroTabControl();
            this.aboutPage = new MetroFramework.Controls.MetroTabPage();
            this.aboutAuthor = new System.Windows.Forms.Label();
            this.aboutQuote = new System.Windows.Forms.Label();
            this.aboutDescription = new System.Windows.Forms.Label();
            this.aboutTitle = new System.Windows.Forms.Label();
            this.formPage = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ugPage = new MetroFramework.Controls.MetroTabPage();
            this.ugTitle = new System.Windows.Forms.Label();
            this.gPage = new MetroFramework.Controls.MetroTabPage();
            this.gTitle = new System.Windows.Forms.Label();
            this.empDetails = new MetroFramework.Controls.MetroTabPage();
            this.empCtrl = new MetroFramework.Controls.MetroTabControl();
            this.mapPage = new MetroFramework.Controls.MetroTabPage();
            this.mapdata = new System.Windows.Forms.WebBrowser();
            this.coopTable = new MetroFramework.Controls.MetroTabPage();
            this.coopData = new System.Windows.Forms.DataGridView();
            this.dgEmployer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empTable = new MetroFramework.Controls.MetroTabPage();
            this.empData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peoplePage = new MetroFramework.Controls.MetroTabPage();
            this.peopleTabs = new MetroFramework.Controls.MetroTabControl();
            this.facultyPage = new MetroFramework.Controls.MetroTabPage();
            this.staffPage = new MetroFramework.Controls.MetroTabPage();
            this.researchPage = new MetroFramework.Controls.MetroTabPage();
            this.researchTab = new MetroFramework.Controls.MetroTabControl();
            this.areaTab = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyAreaTab = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcePage = new MetroFramework.Controls.MetroTabPage();
            this.resourceBox = new System.Windows.Forms.RichTextBox();
            this.resourcesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.newsPage = new MetroFramework.Controls.MetroTabPage();
            this.newsBox = new System.Windows.Forms.RichTextBox();
            this.newsGrid = new System.Windows.Forms.DataGridView();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionNews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPage = new MetroFramework.Controls.MetroTabPage();
            this.employmentPage = new MetroFramework.Controls.MetroTabPage();
            this.homeTab.SuspendLayout();
            this.aboutPage.SuspendLayout();
            this.formPage.SuspendLayout();
            this.ugPage.SuspendLayout();
            this.gPage.SuspendLayout();
            this.empDetails.SuspendLayout();
            this.empCtrl.SuspendLayout();
            this.mapPage.SuspendLayout();
            this.coopTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coopData)).BeginInit();
            this.empTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empData)).BeginInit();
            this.peoplePage.SuspendLayout();
            this.peopleTabs.SuspendLayout();
            this.researchPage.SuspendLayout();
            this.researchTab.SuspendLayout();
            this.areaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.facultyAreaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.resourcePage.SuspendLayout();
            this.resourcesLayout.SuspendLayout();
            this.newsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.aboutPage);
            this.homeTab.Controls.Add(this.resourcePage);
            this.homeTab.Controls.Add(this.formPage);
            this.homeTab.Controls.Add(this.ugPage);
            this.homeTab.Controls.Add(this.gPage);
            this.homeTab.Controls.Add(this.empDetails);
            this.homeTab.Controls.Add(this.peoplePage);
            this.homeTab.Controls.Add(this.researchPage);
            this.homeTab.Controls.Add(this.newsPage);
            this.homeTab.Controls.Add(this.mPage);
            this.homeTab.Controls.Add(this.employmentPage);
            this.homeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeTab.Location = new System.Drawing.Point(24, 60);
            this.homeTab.Name = "homeTab";
            this.homeTab.SelectedIndex = 7;
            this.homeTab.Size = new System.Drawing.Size(749, 234);
            this.homeTab.Style = MetroFramework.MetroColorStyle.Orange;
            this.homeTab.TabIndex = 2;
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.aboutAuthor);
            this.aboutPage.Controls.Add(this.aboutQuote);
            this.aboutPage.Controls.Add(this.aboutDescription);
            this.aboutPage.Controls.Add(this.aboutTitle);
            this.aboutPage.ForeColor = System.Drawing.Color.White;
            this.aboutPage.HorizontalScrollbarBarColor = true;
            this.aboutPage.Location = new System.Drawing.Point(4, 35);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Size = new System.Drawing.Size(741, 195);
            this.aboutPage.TabIndex = 0;
            this.aboutPage.Text = "About";
            this.aboutPage.VerticalScrollbarBarColor = true;
            this.aboutPage.VerticalScrollbarSize = 9;
            // 
            // aboutAuthor
            // 
            this.aboutAuthor.BackColor = System.Drawing.Color.Transparent;
            this.aboutAuthor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutAuthor.ForeColor = System.Drawing.Color.Black;
            this.aboutAuthor.Location = new System.Drawing.Point(-1, 181);
            this.aboutAuthor.Name = "aboutAuthor";
            this.aboutAuthor.Size = new System.Drawing.Size(29, 14);
            this.aboutAuthor.TabIndex = 5;
            this.aboutAuthor.Text = "aboutAuthor";
            this.aboutAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutQuote
            // 
            this.aboutQuote.BackColor = System.Drawing.Color.Transparent;
            this.aboutQuote.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutQuote.ForeColor = System.Drawing.Color.Black;
            this.aboutQuote.Location = new System.Drawing.Point(-1, 135);
            this.aboutQuote.Name = "aboutQuote";
            this.aboutQuote.Size = new System.Drawing.Size(29, 14);
            this.aboutQuote.TabIndex = 4;
            this.aboutQuote.Text = "quote";
            this.aboutQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutDescription
            // 
            this.aboutDescription.BackColor = System.Drawing.Color.Transparent;
            this.aboutDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutDescription.ForeColor = System.Drawing.Color.Black;
            this.aboutDescription.Location = new System.Drawing.Point(-3, 76);
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Size = new System.Drawing.Size(29, 14);
            this.aboutDescription.TabIndex = 3;
            this.aboutDescription.Text = "description";
            this.aboutDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutTitle
            // 
            this.aboutTitle.BackColor = System.Drawing.Color.Transparent;
            this.aboutTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTitle.ForeColor = System.Drawing.Color.Black;
            this.aboutTitle.Location = new System.Drawing.Point(-3, 18);
            this.aboutTitle.Name = "aboutTitle";
            this.aboutTitle.Size = new System.Drawing.Size(29, 14);
            this.aboutTitle.TabIndex = 2;
            this.aboutTitle.Text = "title";
            this.aboutTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formPage
            // 
            this.formPage.Controls.Add(this.webBrowser1);
            this.formPage.HorizontalScrollbarBarColor = true;
            this.formPage.Location = new System.Drawing.Point(4, 35);
            this.formPage.Name = "formPage";
            this.formPage.Size = new System.Drawing.Size(741, 195);
            this.formPage.TabIndex = 8;
            this.formPage.Text = "Contact Form";
            this.formPage.VerticalScrollbarBarColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(741, 195);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://ist.rit.edu/api/contactForm/", System.UriKind.Absolute);
            // 
            // ugPage
            // 
            this.ugPage.Controls.Add(this.ugTitle);
            this.ugPage.HorizontalScrollbarBarColor = true;
            this.ugPage.Location = new System.Drawing.Point(4, 35);
            this.ugPage.Name = "ugPage";
            this.ugPage.Size = new System.Drawing.Size(741, 195);
            this.ugPage.TabIndex = 1;
            this.ugPage.Text = "Under Graduate";
            this.ugPage.VerticalScrollbarBarColor = true;
            this.ugPage.VerticalScrollbarSize = 9;
            // 
            // ugTitle
            // 
            this.ugTitle.BackColor = System.Drawing.Color.Transparent;
            this.ugTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ugTitle.ForeColor = System.Drawing.Color.Black;
            this.ugTitle.Location = new System.Drawing.Point(3, 31);
            this.ugTitle.Name = "ugTitle";
            this.ugTitle.Size = new System.Drawing.Size(29, 14);
            this.ugTitle.TabIndex = 3;
            this.ugTitle.Text = "title";
            this.ugTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gPage
            // 
            this.gPage.Controls.Add(this.gTitle);
            this.gPage.HorizontalScrollbarBarColor = true;
            this.gPage.Location = new System.Drawing.Point(4, 35);
            this.gPage.Name = "gPage";
            this.gPage.Size = new System.Drawing.Size(741, 195);
            this.gPage.TabIndex = 2;
            this.gPage.Text = "Graduate";
            this.gPage.VerticalScrollbarBarColor = true;
            this.gPage.VerticalScrollbarSize = 9;
            // 
            // gTitle
            // 
            this.gTitle.BackColor = System.Drawing.Color.Transparent;
            this.gTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTitle.ForeColor = System.Drawing.Color.Black;
            this.gTitle.Location = new System.Drawing.Point(10, 32);
            this.gTitle.Name = "gTitle";
            this.gTitle.Size = new System.Drawing.Size(29, 10);
            this.gTitle.TabIndex = 4;
            this.gTitle.Text = "title";
            this.gTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empDetails
            // 
            this.empDetails.Controls.Add(this.empCtrl);
            this.empDetails.HorizontalScrollbarBarColor = true;
            this.empDetails.Location = new System.Drawing.Point(4, 35);
            this.empDetails.Name = "empDetails";
            this.empDetails.Size = new System.Drawing.Size(741, 195);
            this.empDetails.TabIndex = 5;
            this.empDetails.Text = "Employment Details";
            this.empDetails.VerticalScrollbarBarColor = true;
            // 
            // empCtrl
            // 
            this.empCtrl.Controls.Add(this.mapPage);
            this.empCtrl.Controls.Add(this.coopTable);
            this.empCtrl.Controls.Add(this.empTable);
            this.empCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empCtrl.Location = new System.Drawing.Point(0, 0);
            this.empCtrl.Name = "empCtrl";
            this.empCtrl.SelectedIndex = 0;
            this.empCtrl.Size = new System.Drawing.Size(741, 195);
            this.empCtrl.Style = MetroFramework.MetroColorStyle.Silver;
            this.empCtrl.TabIndex = 2;
            this.empCtrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapPage
            // 
            this.mapPage.Controls.Add(this.mapdata);
            this.mapPage.HorizontalScrollbarBarColor = true;
            this.mapPage.Location = new System.Drawing.Point(4, 35);
            this.mapPage.Name = "mapPage";
            this.mapPage.Size = new System.Drawing.Size(733, 156);
            this.mapPage.TabIndex = 0;
            this.mapPage.Text = "Map";
            this.mapPage.VerticalScrollbarBarColor = true;
            // 
            // mapdata
            // 
            this.mapdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapdata.Location = new System.Drawing.Point(0, 0);
            this.mapdata.MaximumSize = new System.Drawing.Size(1000, 700);
            this.mapdata.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapdata.Name = "mapdata";
            this.mapdata.ScriptErrorsSuppressed = true;
            this.mapdata.Size = new System.Drawing.Size(733, 156);
            this.mapdata.TabIndex = 2;
            // 
            // coopTable
            // 
            this.coopTable.Controls.Add(this.coopData);
            this.coopTable.HorizontalScrollbarBarColor = true;
            this.coopTable.Location = new System.Drawing.Point(4, 35);
            this.coopTable.Name = "coopTable";
            this.coopTable.Size = new System.Drawing.Size(184, 22);
            this.coopTable.TabIndex = 2;
            this.coopTable.Text = "Co-op Table";
            this.coopTable.VerticalScrollbarBarColor = true;
            // 
            // coopData
            // 
            this.coopData.AllowUserToDeleteRows = false;
            this.coopData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.coopData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coopData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEmployer,
            this.dgDegree,
            this.dgCity,
            this.dgTerm});
            this.coopData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coopData.Location = new System.Drawing.Point(0, 0);
            this.coopData.Name = "coopData";
            this.coopData.ReadOnly = true;
            this.coopData.Size = new System.Drawing.Size(184, 22);
            this.coopData.TabIndex = 4;
            // 
            // dgEmployer
            // 
            this.dgEmployer.HeaderText = "Employer";
            this.dgEmployer.Name = "dgEmployer";
            this.dgEmployer.ReadOnly = true;
            // 
            // dgDegree
            // 
            this.dgDegree.HeaderText = "Degree";
            this.dgDegree.Name = "dgDegree";
            this.dgDegree.ReadOnly = true;
            // 
            // dgCity
            // 
            this.dgCity.HeaderText = "City";
            this.dgCity.Name = "dgCity";
            this.dgCity.ReadOnly = true;
            // 
            // dgTerm
            // 
            this.dgTerm.HeaderText = "Term";
            this.dgTerm.Name = "dgTerm";
            this.dgTerm.ReadOnly = true;
            // 
            // empTable
            // 
            this.empTable.Controls.Add(this.empData);
            this.empTable.HorizontalScrollbarBarColor = true;
            this.empTable.Location = new System.Drawing.Point(4, 35);
            this.empTable.Name = "empTable";
            this.empTable.Size = new System.Drawing.Size(184, 22);
            this.empTable.TabIndex = 1;
            this.empTable.Text = "Employment Table";
            this.empTable.VerticalScrollbarBarColor = true;
            // 
            // empData
            // 
            this.empData.AllowUserToAddRows = false;
            this.empData.AllowUserToDeleteRows = false;
            this.empData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.startDate});
            this.empData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empData.Location = new System.Drawing.Point(0, 0);
            this.empData.Name = "empData";
            this.empData.ReadOnly = true;
            this.empData.Size = new System.Drawing.Size(184, 22);
            this.empData.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Employer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Title";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Degree";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start Date";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // peoplePage
            // 
            this.peoplePage.Controls.Add(this.peopleTabs);
            this.peoplePage.HorizontalScrollbarBarColor = true;
            this.peoplePage.Location = new System.Drawing.Point(4, 35);
            this.peoplePage.Name = "peoplePage";
            this.peoplePage.Size = new System.Drawing.Size(741, 195);
            this.peoplePage.TabIndex = 6;
            this.peoplePage.Text = "People";
            this.peoplePage.VerticalScrollbarBarColor = true;
            // 
            // peopleTabs
            // 
            this.peopleTabs.Controls.Add(this.facultyPage);
            this.peopleTabs.Controls.Add(this.staffPage);
            this.peopleTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peopleTabs.Location = new System.Drawing.Point(0, 0);
            this.peopleTabs.Name = "peopleTabs";
            this.peopleTabs.SelectedIndex = 0;
            this.peopleTabs.Size = new System.Drawing.Size(741, 195);
            this.peopleTabs.Style = MetroFramework.MetroColorStyle.Silver;
            this.peopleTabs.TabIndex = 2;
            this.peopleTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facultyPage
            // 
            this.facultyPage.HorizontalScrollbarBarColor = true;
            this.facultyPage.Location = new System.Drawing.Point(4, 35);
            this.facultyPage.Name = "facultyPage";
            this.facultyPage.Size = new System.Drawing.Size(733, 156);
            this.facultyPage.TabIndex = 0;
            this.facultyPage.Text = "Faculty";
            this.facultyPage.VerticalScrollbarBarColor = true;
            // 
            // staffPage
            // 
            this.staffPage.HorizontalScrollbarBarColor = true;
            this.staffPage.Location = new System.Drawing.Point(4, 35);
            this.staffPage.Name = "staffPage";
            this.staffPage.Size = new System.Drawing.Size(184, 22);
            this.staffPage.TabIndex = 1;
            this.staffPage.Text = "Staff";
            this.staffPage.VerticalScrollbarBarColor = true;
            // 
            // researchPage
            // 
            this.researchPage.Controls.Add(this.researchTab);
            this.researchPage.HorizontalScrollbarBarColor = true;
            this.researchPage.Location = new System.Drawing.Point(4, 35);
            this.researchPage.Name = "researchPage";
            this.researchPage.Size = new System.Drawing.Size(741, 195);
            this.researchPage.TabIndex = 7;
            this.researchPage.Text = "Research";
            this.researchPage.VerticalScrollbarBarColor = true;
            // 
            // researchTab
            // 
            this.researchTab.Controls.Add(this.areaTab);
            this.researchTab.Controls.Add(this.facultyAreaTab);
            this.researchTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.researchTab.Location = new System.Drawing.Point(0, 0);
            this.researchTab.Name = "researchTab";
            this.researchTab.SelectedIndex = 0;
            this.researchTab.Size = new System.Drawing.Size(741, 195);
            this.researchTab.Style = MetroFramework.MetroColorStyle.Silver;
            this.researchTab.TabIndex = 2;
            this.researchTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // areaTab
            // 
            this.areaTab.Controls.Add(this.dataGridView1);
            this.areaTab.HorizontalScrollbarBarColor = true;
            this.areaTab.Location = new System.Drawing.Point(4, 35);
            this.areaTab.Name = "areaTab";
            this.areaTab.Size = new System.Drawing.Size(733, 156);
            this.areaTab.TabIndex = 0;
            this.areaTab.Text = "By Area";
            this.areaTab.VerticalScrollbarBarColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(733, 146);
            this.dataGridView1.TabIndex = 2;
            // 
            // column1
            // 
            this.column1.HeaderText = "Researches";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            // 
            // facultyAreaTab
            // 
            this.facultyAreaTab.Controls.Add(this.dataGridView2);
            this.facultyAreaTab.HorizontalScrollbarBarColor = true;
            this.facultyAreaTab.Location = new System.Drawing.Point(4, 35);
            this.facultyAreaTab.Name = "facultyAreaTab";
            this.facultyAreaTab.Size = new System.Drawing.Size(184, 22);
            this.facultyAreaTab.TabIndex = 1;
            this.facultyAreaTab.Text = "By Faculty";
            this.facultyAreaTab.VerticalScrollbarBarColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, -124);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(184, 146);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Researches";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // resourcePage
            // 
            this.resourcePage.Controls.Add(this.resourceBox);
            this.resourcePage.Controls.Add(this.resourcesLayout);
            this.resourcePage.HorizontalScrollbarBarColor = true;
            this.resourcePage.Location = new System.Drawing.Point(4, 35);
            this.resourcePage.Name = "resourcePage";
            this.resourcePage.Size = new System.Drawing.Size(741, 195);
            this.resourcePage.TabIndex = 10;
            this.resourcePage.Text = "Resources";
            this.resourcePage.VerticalScrollbarBarColor = true;
            // 
            // resourceBox
            // 
            this.resourceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceBox.Location = new System.Drawing.Point(0, 100);
            this.resourceBox.Name = "resourceBox";
            this.resourceBox.Size = new System.Drawing.Size(741, 95);
            this.resourceBox.TabIndex = 3;
            this.resourceBox.Text = "";
            // 
            // resourcesLayout
            // 
            this.resourcesLayout.ColumnCount = 3;
            this.resourcesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resourcesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resourcesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resourcesLayout.Controls.Add(this.metroTile6, 2, 1);
            this.resourcesLayout.Controls.Add(this.metroTile5, 1, 1);
            this.resourcesLayout.Controls.Add(this.metroTile4, 0, 1);
            this.resourcesLayout.Controls.Add(this.metroTile3, 2, 0);
            this.resourcesLayout.Controls.Add(this.metroTile2, 1, 0);
            this.resourcesLayout.Controls.Add(this.metroTile1, 0, 0);
            this.resourcesLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourcesLayout.Location = new System.Drawing.Point(0, 0);
            this.resourcesLayout.Name = "resourcesLayout";
            this.resourcesLayout.RowCount = 2;
            this.resourcesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resourcesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resourcesLayout.Size = new System.Drawing.Size(741, 100);
            this.resourcesLayout.TabIndex = 2;
            // 
            // metroTile6
            // 
            this.metroTile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile6.Location = new System.Drawing.Point(497, 53);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(241, 44);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile6.TabIndex = 5;
            this.metroTile6.Text = "Co-op Enrollment";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile5.Location = new System.Drawing.Point(250, 53);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(241, 44);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Forms";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile4.Location = new System.Drawing.Point(3, 53);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(241, 44);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Student Ambassadors";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile3.Location = new System.Drawing.Point(497, 3);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(241, 44);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Tutoring and Lab Information";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile2.Location = new System.Drawing.Point(250, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(241, 44);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Student Services";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(241, 44);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Study Abroad";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // newsPage
            // 
            this.newsPage.Controls.Add(this.newsBox);
            this.newsPage.Controls.Add(this.newsGrid);
            this.newsPage.HorizontalScrollbarBarColor = true;
            this.newsPage.Location = new System.Drawing.Point(4, 35);
            this.newsPage.Name = "newsPage";
            this.newsPage.Size = new System.Drawing.Size(741, 195);
            this.newsPage.TabIndex = 9;
            this.newsPage.Text = "News";
            this.newsPage.VerticalScrollbarBarColor = true;
            // 
            // newsBox
            // 
            this.newsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsBox.Location = new System.Drawing.Point(0, 150);
            this.newsBox.Name = "newsBox";
            this.newsBox.Size = new System.Drawing.Size(741, 45);
            this.newsBox.TabIndex = 3;
            this.newsBox.Text = "";
            // 
            // newsGrid
            // 
            this.newsGrid.AllowUserToAddRows = false;
            this.newsGrid.AllowUserToDeleteRows = false;
            this.newsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.newsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateCol,
            this.titleCol,
            this.descriptionNews});
            this.newsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.newsGrid.Location = new System.Drawing.Point(0, 0);
            this.newsGrid.Name = "newsGrid";
            this.newsGrid.ReadOnly = true;
            this.newsGrid.Size = new System.Drawing.Size(741, 150);
            this.newsGrid.TabIndex = 2;
            this.newsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newsGrid_CellContentClick);
            // 
            // dateCol
            // 
            this.dateCol.HeaderText = "Date";
            this.dateCol.Name = "dateCol";
            this.dateCol.ReadOnly = true;
            // 
            // titleCol
            // 
            this.titleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleCol.HeaderText = "Title";
            this.titleCol.Name = "titleCol";
            this.titleCol.ReadOnly = true;
            // 
            // descriptionNews
            // 
            this.descriptionNews.HeaderText = "Description";
            this.descriptionNews.Name = "descriptionNews";
            this.descriptionNews.ReadOnly = true;
            this.descriptionNews.Visible = false;
            // 
            // mPage
            // 
            this.mPage.HorizontalScrollbarBarColor = true;
            this.mPage.Location = new System.Drawing.Point(4, 35);
            this.mPage.Name = "mPage";
            this.mPage.Size = new System.Drawing.Size(741, 195);
            this.mPage.TabIndex = 4;
            this.mPage.Text = "Minors";
            this.mPage.VerticalScrollbarBarColor = true;
            this.mPage.VerticalScrollbarSize = 9;
            // 
            // employmentPage
            // 
            this.employmentPage.HorizontalScrollbarBarColor = true;
            this.employmentPage.Location = new System.Drawing.Point(4, 35);
            this.employmentPage.Name = "employmentPage";
            this.employmentPage.Size = new System.Drawing.Size(741, 195);
            this.employmentPage.TabIndex = 3;
            this.employmentPage.Text = "Employment";
            this.employmentPage.VerticalScrollbarBarColor = true;
            this.employmentPage.VerticalScrollbarSize = 9;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 314);
            this.Controls.Add(this.homeTab);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(24, 60, 24, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "IST @ RIT App";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Home_Load);
            this.homeTab.ResumeLayout(false);
            this.aboutPage.ResumeLayout(false);
            this.formPage.ResumeLayout(false);
            this.ugPage.ResumeLayout(false);
            this.gPage.ResumeLayout(false);
            this.empDetails.ResumeLayout(false);
            this.empCtrl.ResumeLayout(false);
            this.mapPage.ResumeLayout(false);
            this.coopTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coopData)).EndInit();
            this.empTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empData)).EndInit();
            this.peoplePage.ResumeLayout(false);
            this.peopleTabs.ResumeLayout(false);
            this.researchPage.ResumeLayout(false);
            this.researchTab.ResumeLayout(false);
            this.areaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.facultyAreaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.resourcePage.ResumeLayout(false);
            this.resourcesLayout.ResumeLayout(false);
            this.newsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl homeTab;
        private MetroFramework.Controls.MetroTabPage aboutPage;
        private MetroFramework.Controls.MetroTabPage ugPage;
        private MetroFramework.Controls.MetroTabPage gPage;
        private MetroFramework.Controls.MetroTabPage employmentPage;
        private System.Windows.Forms.Label aboutTitle;
        private System.Windows.Forms.Label aboutDescription;
        private System.Windows.Forms.Label aboutQuote;
        private System.Windows.Forms.Label aboutAuthor;
        private System.Windows.Forms.Label ugTitle;
        private System.Windows.Forms.Label gTitle;
        private MetroFramework.Controls.MetroTabPage mPage;
        private MetroFramework.Controls.MetroTabPage empDetails;
        private MetroFramework.Controls.MetroTabControl empCtrl;
        private MetroFramework.Controls.MetroTabPage mapPage;
        private MetroFramework.Controls.MetroTabPage empTable;
        private MetroFramework.Controls.MetroTabPage coopTable;
        private System.Windows.Forms.WebBrowser mapdata;
        private System.Windows.Forms.DataGridView coopData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmployer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTerm;
        private System.Windows.Forms.DataGridView empData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private MetroFramework.Controls.MetroTabPage peoplePage;
        private MetroFramework.Controls.MetroTabControl peopleTabs;
        private MetroFramework.Controls.MetroTabPage facultyPage;
        private MetroFramework.Controls.MetroTabPage staffPage;
        private MetroFramework.Controls.MetroTabPage researchPage;
        private MetroFramework.Controls.MetroTabControl researchTab;
        private MetroFramework.Controls.MetroTabPage areaTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private MetroFramework.Controls.MetroTabPage facultyAreaTab;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroTabPage formPage;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTabPage newsPage;
        private System.Windows.Forms.RichTextBox newsBox;
        private System.Windows.Forms.DataGridView newsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionNews;
        private MetroFramework.Controls.MetroTabPage resourcePage;
        private System.Windows.Forms.RichTextBox resourceBox;
        private System.Windows.Forms.TableLayoutPanel resourcesLayout;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

