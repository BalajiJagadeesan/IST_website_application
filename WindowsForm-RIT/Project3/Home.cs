using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTUtil;
using Newtonsoft.Json.Linq;
using MetroFramework.Forms;
using System.Globalization;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Project3
{
    /* 
     *Main class to describe the form 
     */
    public partial class Home : MetroForm
    {
        //Class library to access the api
        Rest baseurl = new Rest("http://ist.rit.edu/api");
        //Object of About.cs
        About about;
        //Object of DegreePrograms.cs
        DegreePrograms degree;
        //Object of ResearchAreas.cs
        ResearchAreas r;
        Resources resource;
        //Constructor function to initialise the forn
        public Home()
        {
            //function to initialise the form contents
            InitializeComponent();
            //Opens the form in size of screen
            WindowState = FormWindowState.Maximized;
            string link = baseurl.getRestData("/resources/");
            resource =JToken.Parse(link).ToObject<Resources>();

        }

        //On form-load following function gets invoked to populate the form
        private void Home_Load(object sender, EventArgs e)
        {
            undergraduateFn();
            aboutPageFn();
            graduateFn();
            employmentFn();
            minorFn();
            employmentDetails();
            researchArea();
            newsLoad();
            
        }
        
        #region Code to populate data
        //Code to load news data in news tab
        private void newsLoad()
        {
            string link = baseurl.getRestData("/news/");
            News news = JToken.Parse(link).ToObject<News>();
            List<Year> q = news.year;
            newsBox.Text = "Click on Title Cell of each row to know more about the news!!!";
            for (var i = 0; i < q.Count; i++)
            {
                newsGrid.Rows.Add();
                newsGrid.Rows[i].Cells[0].Value = q[i].date;
                newsGrid.Rows[i].Cells[1].Value = q[i].title;
                newsGrid.Rows[i].Cells[2].Value = q[i].description;
            }

        }

        /**
         * function to fill research by faculty as well as reasearch by area  
         * in their corresponding tabs
         */
        private void researchArea()
        {
            string link = baseurl.getRestData("/research/");
            r = JToken.Parse(link).ToObject<ResearchAreas>();
            List<ByInterestArea> area = r.byInterestArea;
            
            
            TableLayoutPanel panelp = new TableLayoutPanel();
            panelp.Location = new Point((this.ClientSize.Width - panelp.Width) / 6, 50);
            panelp.RowCount = (area.Count / 4) + 1;
            panelp.Size = new Size(4 * 205,(area.Count/4)*105);
            panelp.ColumnCount = 4;
            panelp.Name = "area";
            panelp.AutoScroll = true;
            areaTab.Controls.Add(panelp);

            int count = 0;

            for (int i = 0; i < area.Count/4; i++) {
                for (int j = 0; j < 4; j++) {
                    MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                    tile.Size = new Size(200, 100);
                    tile.TextAlign = ContentAlignment.TopCenter;
                    tile.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(area[count].areaName);
                    tile.Click += new EventHandler(TileClickEventArea);
                    tile.Name = area[count].areaName;
                    tile.Style = MetroFramework.MetroColorStyle.Orange;
                    tile.AutoSize = true;
                    
                    tile.MaximumSize = new Size(200, 200);
                    panelp.Controls.Add(tile,j, i);
                    count++;
                }
            }

            List<ByFaculty> f = r.byFaculty;
            TableLayoutPanel panelf = new TableLayoutPanel();
            panelf.Location = new Point((this.ClientSize.Width - panelf.Width) / 6, 50);
            panelf.RowCount = (f.Count / 4) + 1;
            panelf.Size = new Size(4 * 205,(f.Count/4)*60);
            panelf.ColumnCount = 4;
            panelf.Name = "faculty";
            panelf.AutoScroll = true;
            facultyAreaTab.Controls.Add(panelf);

            count = 0;
            for (int i = 0; i < f.Count / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                    tile.Size = new Size(200, 50);
                    tile.TextAlign = ContentAlignment.TopCenter;
                    tile.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(f[count].facultyName);
                    tile.Click += new EventHandler(TileClickEventArea);
                    tile.Name = f[count].username;
                    tile.AutoSize = true;
                    tile.Style = MetroFramework.MetroColorStyle.Orange;
                    tile.MaximumSize = new Size(200, 200);
                    panelf.Controls.Add(tile, j, i);
                    count++;
                }
            }
        }
        //Code to display papers published on click of an area or a faculty
        private void TileClickEventArea(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tile = sender as MetroFramework.Controls.MetroTile;
            if (tile.Parent.Name == "area") { 
                List<ByInterestArea> area = r.byInterestArea;
                foreach (ByInterestArea a in area) {
                    if (a.areaName == tile.Name) {
                        for (var i = 0; i < a.citations.Count; i++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = a.citations[i];
                        }
                    }
                }
            }else
            {
                List<ByFaculty> area = r.byFaculty;
                foreach (ByFaculty a in area)
                {
                    if (a.username == tile.Name)
                    {
                        for (var i = 0; i < a.citations.Count; i++)
                        {
                            dataGridView2.Rows.Add();
                            dataGridView2.Rows[i].Cells[0].Value = a.citations[i];
                        }
                    }
                }
            }
        }

        //Code to display employment table and coop table and faculty details
        private void employmentDetails()
        {
            mapdata.Navigate("http://ist.rit.edu/api/map");

            string link = baseurl.getRestData("/employment/");
            EmploymentData emp = JToken.Parse(link).ToObject<EmploymentData>();
            

            for (var i = 0; i < emp.coopTable.coopInformation.Count; i++)
            {
                coopData.Rows.Add();      
                coopData.Rows[i].Cells[0].Value = emp.coopTable.coopInformation[i].employer;
                coopData.Rows[i].Cells[1].Value = emp.coopTable.coopInformation[i].degree;
                coopData.Rows[i].Cells[2].Value = emp.coopTable.coopInformation[i].city;
                coopData.Rows[i].Cells[3].Value = emp.coopTable.coopInformation[i].term;
            }


            for (var i = 0; i < emp.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                empData.Rows.Add();      
                empData.Rows[i].Cells[0].Value = emp.employmentTable.professionalEmploymentInformation[i].employer;
                empData.Rows[i].Cells[1].Value = emp.employmentTable.professionalEmploymentInformation[i].title;
                empData.Rows[i].Cells[2].Value = emp.employmentTable.professionalEmploymentInformation[i].degree;
                empData.Rows[i].Cells[3].Value = emp.employmentTable.professionalEmploymentInformation[i].city;
                empData.Rows[i].Cells[4].Value = emp.employmentTable.professionalEmploymentInformation[i].startDate;
            }

            string link2= baseurl.getRestData("/people/");
            PeopleData p = JToken.Parse(link2).ToObject<PeopleData>();
           
           
            TableLayoutPanel panelp = new TableLayoutPanel();
            panelp.Location = new Point((this.ClientSize.Width - panelp.Width) / 6, 50);
            panelp.RowCount = (p.faculty.Count / 4)+1;
            panelp.Size = new Size(4 * 205, 500);
            panelp.ColumnCount = 4;
            panelp.Name = "faculty";
            panelp.AutoScroll = true;
            facultyPage.Controls.Add(panelp);

            int count = 0;
            for (int i = 0; i < (p.faculty.Count / 4)+1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (count < p.faculty.Count)
                    {
                        MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                        tile.Size = new Size(200, 200);
                        tile.TextAlign = ContentAlignment.TopCenter;
                        tile.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.faculty[count].name);
                        tile.Click += new EventHandler(TileClickEventPeople);
                        tile.Name = p.faculty[count].username;
                        tile.AutoSize = true;
                        // Image myimage = new Bitmap();
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData(p.faculty[count].imagePath);
                        MemoryStream ms = new MemoryStream(bytes);
                        Image img = Image.FromStream(ms);
                        Image imgsize = new Bitmap(img, new Size(200, 200));
                        tile.CustomBackground = true;
                        tile.UseTileImage = true;
                        tile.TileImage = imgsize;
                        tile.MaximumSize = new Size(200, 200);
                        panelp.Controls.Add(tile, j, i);
                        count++;
                    }
                }
            }

            TableLayoutPanel panels = new TableLayoutPanel();
            panels.Location = new Point((this.ClientSize.Width - panels.Width) / 6, 50);
            panels.RowCount = (p.staff.Count / 4) + 1;
            panels.Size = new Size(4 * 205, 500);
            panels.ColumnCount = 4;
            panels.Name = "staff";
            panels.AutoScroll = true;
            staffPage.Controls.Add(panels);

            count = 0;
            for (int i = 0; i < (p.staff.Count / 4); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                        MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                        tile.Size = new Size(200, 200);
                        tile.TextAlign = ContentAlignment.TopCenter;
                        tile.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.staff[count].name);
                        tile.Click += new EventHandler(TileClickEventPeople);
                        tile.Name = p.staff[count].username;
                        tile.AutoSize = true;
                        // Image myimage = new Bitmap();
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData(p.staff[count].imagePath);
                        MemoryStream ms = new MemoryStream(bytes);
                        Image img = Image.FromStream(ms);
                        Image imgsize = new Bitmap(img, new Size(200, 200));
                        tile.CustomBackground = true;
                        tile.UseTileImage = true;
                        tile.TileImage = imgsize;
                        tile.MaximumSize = new Size(200, 200);
                        panels.Controls.Add(tile, j, i);
                        count++;
                 
                }
            }
        }

        //code to show detail about people on click 
        private void TileClickEventPeople(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tile = sender as MetroFramework.Controls.MetroTile;
            PeopleDetails m = new PeopleDetails(tile.Name, tile.Parent.Name);
            Console.WriteLine(tile.Parent.Name);
            m.Size = new Size(500, 400);
            m.ShowDialog();
        }

        //code to show different minors
        private void minorFn()
        {
            string link = baseurl.getRestData("/minors/");
            Minors minor = JToken.Parse(link).ToObject<Minors>();
            List<UgMinor> mdegree = minor.UgMinors;

            Label mTitle = new Label();
            mTitle.Text = "Minors";
            mTitle.MaximumSize = new Size(1000, 0);
            mTitle.BackColor = Color.Transparent;
            mTitle.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            mTitle.Location = new Point(((this.ClientSize.Width - mTitle.Width) / 2) - 75, 50);
            mTitle.AutoSize = true;
            mPage.Controls.Add(mTitle);

            TableLayoutPanel panelm = new TableLayoutPanel();
            panelm.Location = new Point((this.ClientSize.Width - panelm.Width) / 6, 100);
            panelm.RowCount = mdegree.Count/4;
            panelm.Size = new Size(4* 205, 400);
            panelm.ColumnCount = mdegree.Count - 1;
            mPage.Controls.Add(panelm);
            int count=0;
            for (int i = 0; i < mdegree.Count/4; i++) {
                for (int j = 0; j < 4; j++) {
                    MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                    tile.Size = new Size(200, 200);
                    tile.TextAlign = ContentAlignment.MiddleCenter;
                    tile.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mdegree[count].title);
                    tile.Click += new EventHandler(TileClickEventM);
                    tile.Name = mdegree[count].name;
                    tile.AutoSize = true;
                    tile.Style = MetroFramework.MetroColorStyle.Orange;
                    tile.MaximumSize=new Size(200, 200);
                    panelm.Controls.Add(tile, j, i);
                    count++;
                }   
            }
        }
        //code to show details abouta a minor

        private void TileClickEventM(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tile = sender as MetroFramework.Controls.MetroTile;
            MinorDetails m = new MinorDetails(tile.Name);
            m.Size = new Size(1000, 500);
            m.ShowDialog();
        }
        //Code to show statistics of employment
        private void employmentFn()
        {
            string link = baseurl.getRestData("/employment/");
            //Console.WriteLine(link);
            EmploymentData emp = JToken.Parse(link).ToObject<EmploymentData>();
            Introduction intro = emp.introduction;
            Console.WriteLine(intro.ToString());
            DegreeStatistics stat = emp.degreeStatistics;
            Console.WriteLine(stat.ToString());
            Employers e = emp.employers;
            Careers career = emp.careers;
            
            Label label = new Label();
            employmentPage.Controls.Add(label);
            label.BackColor = Color.Transparent;
            label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = Color.Black;

            label.Text = intro.title;
            label.AutoSize = true;
            label.Location = new Point(((this.ClientSize.Width - label.Width) / 2), 50);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int count = 1;
            foreach (Content c in intro.content)
            {
                Label label1 = new Label();
                employmentPage.Controls.Add(label1);
                label1.BackColor = Color.Transparent;
                label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label1.ForeColor = Color.Black;
                label1.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c.title);
                label1.AutoSize = true;
                label1.MaximumSize = new Size(1000, 0);
                label1.Location = new Point(((this.ClientSize.Width - label1.Width) / 2), 80 * count);
                label1.TextAlign = ContentAlignment.MiddleCenter;

                Label label2 = new Label();
                employmentPage.Controls.Add(label2);
                label2.BackColor = Color.Transparent;
                label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label2.ForeColor = Color.Black;
                label2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c.description);
                label2.AutoSize = true;
                label2.MaximumSize = new Size(1000, 0);
                label2.Location = new Point(((this.ClientSize.Width - label2.Width) / 2), 95 * count);
                label2.TextAlign = ContentAlignment.MiddleCenter;
                count++;
            }

            // Statistics Box 

            Label label3 = new Label();
            employmentPage.Controls.Add(label3);
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = Color.Black;

            label3.Text = stat.title;
            label3.AutoSize = true;
            label3.Location = new Point(((this.ClientSize.Width - label3.Width) / 2), 280);
            label3.TextAlign = ContentAlignment.MiddleCenter;
            
            TableLayoutPanel panelstat = new TableLayoutPanel();
            panelstat.Location = new Point((this.ClientSize.Width - panelstat.Width) / 4, 310);
            panelstat.RowCount = 1;
            panelstat.Size = new Size((stat.statistics.Count) * 205, 150);
            panelstat.ColumnCount = stat.statistics.Count;
            employmentPage.Controls.Add(panelstat);
            
            for(int i=0;i< stat.statistics.Count;i++)
            {
                Statistic s = stat.statistics[i];
                MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                tile.Size = new Size(200, 150);
                tile.TextAlign = ContentAlignment.MiddleCenter;
                //tile.MaximumSize=new Size(300, 200);
                tile.Style = MetroFramework.MetroColorStyle.Silver;
                tile.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.value+"\n"+s.description);
                panelstat.Controls.Add(tile, i, 0);
                
            }
            //Employers
            Label label4 = new Label();
            employmentPage.Controls.Add(label4);
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = Color.Black;

            label4.Text = e.title;
            label4.AutoSize = true;
            label4.Location = new Point(((this.ClientSize.Width - label4.Width) / 2), 470);
            label4.TextAlign = ContentAlignment.MiddleCenter;
            for (int i = 0; i <5; i++) {
                Label label5 = new Label();
                employmentPage.Controls.Add(label5);
                label5.BackColor = Color.Transparent;
                label5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label5.ForeColor = Color.Black;
                label5.Text = e.employerNames[i];
                label5.AutoSize = true;
                label5.Location = new Point(220*(i+1), 500);
                label5.TextAlign = ContentAlignment.MiddleCenter;
            }
            //Careers
            Label label6 = new Label();
            employmentPage.Controls.Add(label6);
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = Color.Black;
            label6.Text = career.title;
            label6.AutoSize = true;
            label6.Location = new Point(((this.ClientSize.Width - label6.Width) / 2), 540);
            label6.TextAlign = ContentAlignment.MiddleCenter;
            for (int i = 0; i < 5; i++)
            {
                Label label5 = new Label();
                employmentPage.Controls.Add(label5);
                label5.BackColor = Color.Transparent;
                label5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label5.ForeColor = Color.Black;
                label5.Text = career.careerNames[i];
                label5.AutoSize = true;
                label5.Location = new Point(200 * (i + 1), 580);
                label5.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        //code to show graduate degree offered
        private void graduateFn()
        {
            string degreelink = baseurl.getRestData("/degrees/");
            //Console.WriteLine(degreelink);
            degree = JToken.Parse(degreelink).ToObject<DegreePrograms>();
            List<Graduate> gdegree = degree.graduate;

            gTitle.Text = "Graduate Degrees";
            gTitle.MaximumSize = new Size(1000, 0);
            gTitle.Location = new Point(((this.ClientSize.Width - gTitle.Width) / 2)-75, 50);
            gTitle.AutoSize = true;

            TableLayoutPanel panelg = new TableLayoutPanel();
            panelg.Location = new Point((this.ClientSize.Width - panelg.Width) / 6, 100);
            panelg.RowCount = 1;
            panelg.ColumnCount = gdegree.Count-1;
            gPage.Controls.Add(panelg);

            for (int i = 0; i < gdegree.Count; i++)
            {
                Graduate g = gdegree[i];
                if (g.availableCertificates==null)
                {
                    MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                    tile.Size = new Size(300, 200);
                    tile.TextAlign = ContentAlignment.MiddleCenter;
                    tile.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(g.title);
                    tile.Click += new EventHandler(TileClickEventG);
                    tile.Style = MetroFramework.MetroColorStyle.Orange;
                    tile.Name = g.degreeName;
                    panelg.Controls.Add(tile, i, 0);
                }
                else {
                    
                    Label label = new Label();
                    gPage.Controls.Add(label);
                    label.BackColor = Color.Transparent;
                    label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = Color.Black;
                    label.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(g.degreeName);
                    label.AutoSize = true;
                    label.Location = new Point(((this.ClientSize.Width - label.Width) / 2), 350);
                    
                    //label.MaximumSize = new Size(this.Width / 2, 0);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    int count = 10;
                    foreach (string cont in g.availableCertificates)
                    {
                        count = count + 40;
                        Label label1 = new Label();
                        gPage.Controls.Add(label1);
                        label1.BackColor = Color.Transparent;
                        label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                        label1.ForeColor = Color.Black;
                        label1.Name = cont;
                        label1.Text = cont;
                        label1.AutoSize = true;
                        label1.Location = new Point(((this.ClientSize.Width - label1.Width) / 2), 350 + count);

                        //label.MaximumSize = new Size(this.Width / 2, 0);
                        label1.TextAlign = ContentAlignment.MiddleCenter;
                    }
                }

            }
            panelg.Size = new Size((gdegree.Count-1) * 300, 200);
        }
        //code to show undergraduate degree
        private void undergraduateFn()
        {
            string degreelink = baseurl.getRestData("/degrees/");
            //Console.WriteLine(degreelink);
            degree = JToken.Parse(degreelink).ToObject<DegreePrograms>();
            List<Undergraduate> ugdegree = degree.undergraduate;

            ugTitle.Text = "Undergraduate Degrees";
            ugTitle.MaximumSize = new Size(1000, 0);
            ugTitle.Location = new Point(((this.ClientSize.Width - ugTitle.Width) / 2) - 75, 50);
            ugTitle.AutoSize = true;

            TableLayoutPanel panelUg = new TableLayoutPanel();
            panelUg.Location = new Point((this.ClientSize.Width - panelUg.Width) / 6, 100);
            panelUg.RowCount = 1;
            panelUg.ColumnCount = 3;
            ugPage.Controls.Add(panelUg);
            
            for (int i = 0; i < ugdegree.Count; i++) {
                Undergraduate ug = ugdegree[i];
                
                MetroFramework.Controls.MetroTile  tile= new MetroFramework.Controls.MetroTile();
                tile.Size = new Size(300, 200);
                tile.TextAlign = ContentAlignment.MiddleCenter;
                tile.Style = MetroFramework.MetroColorStyle.Orange;
                tile.Text =ug.title;
                tile.Click += new EventHandler(TileClickEvent);
                tile.Name = ug.degreeName;
                panelUg.Controls.Add(tile, i, 0);
                
            }
            panelUg.Size = new Size(ugdegree.Count*300, 200);
            
        }

        private void aboutPageFn()
        {
            string aboutlink = baseurl.getRestData("/about/");
            //Console.WriteLine(aboutlink);
            about = JToken.Parse(aboutlink).ToObject<About>();
            
            aboutTitle.Text = about.title;
            aboutTitle.MaximumSize = new Size(1000, 0);
            aboutTitle.Location = new Point((homeTab.Width / 8)+(homeTab.Width/4), 100);
            aboutTitle.AutoSize = true;

            aboutDescription.Text = about.description;
            aboutDescription.MaximumSize = new Size(1000, 0);
            aboutDescription.Location = new Point((homeTab.Width / 8), 150);
            aboutDescription.AutoSize = true;


            aboutQuote.Text = "\""+about.quote+"\"";
            aboutQuote.MaximumSize = new Size(1000, 0);
            aboutQuote.Location = new Point((homeTab.Width / 8), 350);
            aboutQuote.AutoSize = true;

            aboutAuthor.Text = "-" + about.quoteAuthor;
            aboutAuthor.MaximumSize = new Size(1000, 0);
            aboutAuthor.Location = new Point((homeTab.Width / 8)+ (homeTab.Width/4)+40, 420);
            aboutAuthor.AutoSize = true;
            
        }
        //To show more details about ug program
        private void TileClickEvent(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tile = sender as MetroFramework.Controls.MetroTile;
            UnderGraduate ug = new UnderGraduate(tile.Name);
            ug.ShowDialog();
        }

        //To show more details on graduate program
        private void TileClickEventG(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tile = sender as MetroFramework.Controls.MetroTile;
            GraduateDegree g = new GraduateDegree(tile.Name);
            g.ShowDialog();
        }

        //To show description of news

        private void newsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.newsGrid.Rows[e.RowIndex];
                if (row.Cells["descriptionNews"].Value != null) { 
                    newsBox.Text = row.Cells["descriptionNews"].Value.ToString();
                }else
                {
                    newsBox.Text = "No Description Available";
                }
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            resourceBox.Clear();
            for (var i = 0; i < resource.coopEnrollment.enrollmentInformationContent.Count; i++)
            {
                resourceBox.Text += resource.coopEnrollment.enrollmentInformationContent[i].title +"\n"+ resource.coopEnrollment.enrollmentInformationContent[i].description +"\n\n";

            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            resourceBox.Clear();
            resourceBox.Text = resource.studyAbroad.title + "\n" + resource.studyAbroad.description +"\n\n\n";

            for (var i = 0; i <resource.studyAbroad.places.Count; i++)
            {
                resourceBox.Text += resource.studyAbroad.places[i].nameOfPlace+"\n"+resource.studyAbroad.places[i].description +"\n\n";

            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            resourceBox.Clear();
            resourceBox.Text = resource.tutorsAndLabInformation.title+"\n"+ resource.tutorsAndLabInformation.description;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            resourceBox.Clear();
            resourceBox.Text = resource.studentAmbassadors.title + "\n";
            resourceBox.Text += resource.studentAmbassadors.ambassadorsImageSource +"\n";
            for (var i = 0; i < resource.studentAmbassadors.subSectionContent.Count; i++)
            {
                resourceBox.Text += resource.studentAmbassadors.subSectionContent[i].title +"\n"+ resource.studentAmbassadors.subSectionContent[i].description +"\n\n";
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            resourceBox.Clear();
            resourceBox.Text = resource.studentServices.title + "\n\n";
            resourceBox.Text += resource.studentServices.academicAdvisors.title +"\n"+ resource.studentServices.academicAdvisors.description +"\n\n";
            resourceBox.Text += resource.studentServices.academicAdvisors.faq.title +"\n"+ resource.studentServices.academicAdvisors.faq.contentHref+"\n\n";
            resourceBox.Text += resource.studentServices.facultyAdvisors.title + "\n" + resource.studentServices.facultyAdvisors.description +"\n\n";
            resourceBox.Text += resource.studentServices.istMinorAdvising.title + "\n";
            for (var i = 0; i < resource.studentServices.istMinorAdvising.minorAdvisorInformation.Count; i++)
            {
                resourceBox.Text += resource.studentServices.istMinorAdvising.minorAdvisorInformation[i].title +"\n"+ resource.studentServices.istMinorAdvising.minorAdvisorInformation[i].advisor +"\n"+ resource.studentServices.istMinorAdvising.minorAdvisorInformation[i].email +"\n\n";
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            resourceBox.Clear();
            resourceBox.Text += "UnderGraduate Forms" + "\n";
            for (var i = 0; i < resource.forms.undergraduateForms.Count; i++)
            {
                resourceBox.Text += resource.forms.undergraduateForms[i].formName +"\n"+ "http://ist.rit.edu/"+resource.forms.undergraduateForms[i].href +"\n\n";
            }

            resourceBox.Text += "Graduate Forms" +"\n";

            for (var i = 0; i < resource.forms.graduateForms.Count; i++)
            {
                resourceBox.Text += resource.forms.graduateForms[i].formName + "\n" + "http://ist.rit.edu/" + resource.forms.graduateForms[i].href + "\n\n";
            }
        }
    }
    #endregion

}
