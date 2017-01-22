using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using RESTUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class MinorDetails : MetroForm
    {
        string mid;
        Rest baseurl = new Rest("http://ist.rit.edu/api");
        Minors m;
        public MinorDetails(string id)
        {
            InitializeComponent();
            mid = id;
            showMinorDetails();

        }

        private void showMinorDetails()
        {
            string degreelink = baseurl.getRestData("/minors/");
            m = JToken.Parse(degreelink).ToObject<Minors>();
            foreach (UgMinor ugm in m.UgMinors)
            {
                if (ugm.name.Equals(mid))
                {
                    labelTitle.Text = ugm.title;
                    labelTitle.MaximumSize = new Size(this.Width, 0);
                    labelTitle.Location = new Point((this.ClientSize.Width)/ 2, 50);
                    labelTitle.AutoSize = true;

                    labelDescription.Text = ugm.description;
                    labelDescription.MaximumSize = new Size(800, 0);
                    labelDescription.Location = new Point((this.ClientSize.Width - labelDescription.Width) / 2, 100);
                    labelDescription.AutoSize = true;

                    labelCon.Text = "Courses";
                    labelCon.MaximumSize = new Size(this.Width / 2, 0);
                    labelCon.Location = new Point((this.ClientSize.Width) / 2 +150, 300);
                    labelCon.AutoSize = true;

                    TableLayoutPanel panelm = new TableLayoutPanel();
                    panelm.Location = new Point((this.ClientSize.Width - panelm.Width)/2+50, 400);
                    panelm.RowCount = ugm.courses.Count / 4;
                    panelm.Size = new Size(105 * 4, ((ugm.courses.Count / 4)+5) * 50);
                    panelm.ColumnCount = 4;
                    this.Controls.Add(panelm);

                    int count = 0;
                    for (int i = 0; i < ugm.courses.Count / 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                            tile.Size = new Size(100, 50);
                            tile.TextAlign = ContentAlignment.MiddleCenter;
                            tile.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ugm.courses[count]);
                            tile.Click += new EventHandler(TileClickEventC);
                            tile.Name = ugm.courses[count];
                            tile.AutoSize = true;
                            tile.MaximumSize = new Size(100, 0);
                            panelm.Controls.Add(tile, j, i);
                            count++;
                        }
                    }
                }
            }
        }

        private void TileClickEventC(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tile = sender as MetroFramework.Controls.MetroTile;
            CourseDetail m = new CourseDetail(tile.Name);
            m.Size = new Size(850, 400);
            m.ShowDialog();
        }
    }
}
