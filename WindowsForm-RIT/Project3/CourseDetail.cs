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
    public partial class CourseDetail : MetroForm
    {
        string cid;
        Rest baseurl = new Rest("http://ist.rit.edu/api");
        Details d;
        public CourseDetail(string id)
        {
            InitializeComponent();
            cid = id;
            details();
        }

        private void details()
        {
            string degreelink = baseurl.getRestData("/course/courseID="+cid);
            d = JToken.Parse(degreelink).ToObject<Details>();

            labelTitle.Text = d.title;
            labelTitle.MaximumSize = new Size(this.Width, 0);
            labelTitle.Location = new Point((this.ClientSize.Width), 50);
            labelTitle.AutoSize = true;

            labelDescription.Text = d.description;
            labelDescription.MaximumSize = new Size(800, 0);
            labelDescription.Location = new Point((this.ClientSize.Width - labelDescription.Width) / 2, 100);
            labelDescription.AutoSize = true;
        }
    }
}
