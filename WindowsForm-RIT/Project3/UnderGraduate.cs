using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using RESTUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class UnderGraduate : MetroForm
    {
        string ugid;
        Rest baseurl = new Rest("http://ist.rit.edu/api");
        Undergraduate ug;
        public UnderGraduate(string id)
        {
            InitializeComponent();
            ugid = id;
            showDetails();
        }

        private void showDetails()
        {
            string degreelink = baseurl.getRestData("/degrees/undergraduate/degreeName="+ugid);
            ug= JToken.Parse(degreelink).ToObject<Undergraduate>();

            labelTitle.Text = ug.title;
            labelTitle.MaximumSize = new Size(this.Width, 0);
            labelTitle.Location = new Point(this.Width/4, 100);
            labelTitle.AutoSize = true;

            labelDescription.Text = ug.description;
            labelDescription.MaximumSize = new Size(this.Width/2, 0);
            labelDescription.Location = new Point((this.Width / 4), 150);
            labelDescription.AutoSize = true;

            labelCon.Text = "Concentrations";
            labelCon.MaximumSize = new Size(this.Width / 2, 0);
            labelCon.Location = new Point((this.Width / 3), 250);
            labelCon.AutoSize = true;
            int count = 10;
            foreach(string cont in ug.concentrations)
            {
                count = count+40;
                Label label = new Label();
                this.Controls.Add(label);
                label.BackColor = Color.Transparent;
                label.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label.ForeColor = Color.Black;
                label.Text = cont;
                label.AutoSize = true;
                label.Location = new Point(((this.ClientSize.Width - label.Width) / 2), 250 +count);

                //label.MaximumSize = new Size(this.Width / 2, 0);
                label.TextAlign = ContentAlignment.MiddleCenter;
            }

        }
    }
}
