using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using RESTUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class PeopleDetails : MetroForm
    {
        string pid;
        string tab;
        Rest baseurl = new Rest("http://ist.rit.edu/api");
        public PeopleDetails(string id,string name)
        {
            InitializeComponent();
            pid = id;
            tab = name;
            showPeople();
        }
        private void showPeople()
        {
            if (tab == "faculty")
            {
                string link = baseurl.getRestData("/people/faculty/username=" + pid);
                Faculty f = JToken.Parse(link).ToObject<Faculty>();
                labelName.Text = f.name;
                labelTitle.Text = f.title;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(f.imagePath);
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                Image imgsize = new Bitmap(img, new Size(200, 200));
                pictureBox1.Image = imgsize;
                pictureBox1.Size = new Size(200, 200);
                labelEmail.Text = f.email.ToLower();
                labelPhone.Text = f.phone;
                labelRoom.Text = f.office;
                labelWebsite.Text = f.website.ToLower();
            }
            else
            {
                string link = baseurl.getRestData("/people/staff/username=" + pid);
                Staff f = JToken.Parse(link).ToObject<Staff>();
                labelName.Text = f.name;
                labelTitle.Text = f.title;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(f.imagePath);
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                Image imgsize = new Bitmap(img, new Size(200, 200));
                pictureBox1.Image = imgsize;
                pictureBox1.Size = new Size(200, 200);
                labelEmail.Text = f.email.ToLower();
                labelPhone.Text = f.phone;
                labelRoom.Text = f.office;
                labelWebsite.Text = f.website.ToLower();
            }
            
        }
    }
}
