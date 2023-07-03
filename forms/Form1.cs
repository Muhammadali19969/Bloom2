using Bloom2.Contants;
using Bloom2.forms;
using Bloom2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloom2
{
    public partial class Form1 : Form
    {
        public static bool menegBtn = false;

        public string Reco { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            lbParolDate.Text = DateTime.Now.ToLongDateString();
            parolOynaTimer1.Start();

            lbParolTime.Text = DateTime.Now.ToLongTimeString();

            ish_meneger_panel.Visible = true;

            ArrayPanel.Visible = false;
            parolPanel.Visible = false;

            
        }


        private void ClearBTn_Click(object sender, EventArgs e)
        {
            string parol=textBoxParol.Text;
            if(parol.Length > 0 )
            {
                parol = parol.Remove(parol.Length-1,1);
                textBoxParol.Text = parol;

            }
        }

        private void OkClick_Click(object sender, EventArgs e)
        {
            string path = ResourseConstants.DB_JSON_MANEGER_FILE_PATH;

            string jsonContent = File.ReadAllText(path);

            var meneg = JsonConvert.DeserializeObject<List<Workers>>(jsonContent);

            if (meneg[0].Password == textBoxParol.Text && menegBtn)
            {

                ish_meneger_panel.Visible = true;
                ArrayPanel.Visible = false;
                parolPanel.Visible = false;

                this.Hide();
                WorkerInformationTable workerInformationTable = new WorkerInformationTable();

                workerInformationTable.ShowDialog();
                textBoxParol.Text = string.Empty;
                menegBtn=false;

                this.Show();

            }
            else if(textBoxParol.Text == Password)
            { 
                Hisoblarga_kirish_Oy hisoblarga_Kirish_Oy = new Hisoblarga_kirish_Oy();
                hisoblarga_Kirish_Oy.ShowDialog();
                textBoxParol.Text=string.Empty;
            }
            else
            {
                MessageBox.Show("Parol xato kiritildi !");
                textBoxParol.Text = string.Empty;

            }
        }

        private void parolBtn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxParol.Text += button.Text;
        }

        private void parolOynaTimer1_Tick(object sender, EventArgs e)
        {
            lbParolTime.Text = DateTime.Now.ToLongTimeString();
            parolOynaTimer1.Start();


        }

        private void menegerBtn_Click(object sender, EventArgs e)
        {
            string path = ResourseConstants.DB_JSON_MANEGER_FILE_PATH;

            string jsonContent = File.ReadAllText(path);

            var meneg = JsonConvert.DeserializeObject<List<Workers>>(jsonContent);

            if (meneg.Count > 0)
            {
                parolPanel.Visible = true;
                ish_meneger_panel.Visible = false;

            }
            else
            {
                IshchilarOynasi ishchilarOynasi = new IshchilarOynasi();
                ishchilarOynasi.Show();
            }
            menegBtn = true;
        }

        private void ishchilar_Click(object sender, EventArgs e)
        {
            ArrayPanel.Visible = true;

            ish_meneger_panel.Visible=false;
            parolPanel.Visible=false;

            ishchilarOynasi();
        }

        public void Parol_Click()
        {
            this.ShowDialog();
            parolPanel.Visible = false;
            ish_meneger_panel.Visible = true;
        }
        public void ishchilarOynasi()
        {
            string path = ResourseConstants.DB_JSON_WORKERS_FILE_PATH;

            string jsonContent = File.ReadAllText(path);

            var workers = JsonConvert.DeserializeObject<List<Workers>>(jsonContent);
            int X = 50;
            int Y = 50;

            for (int i = 0; i < workers.Count; i++)
            {
                string firstName = workers[i].FirstName;

                Button WorkerBtn = new Button();

                WorkerBtn.Font = new System.Drawing.Font("Arial", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                WorkerBtn.FlatStyle = FlatStyle.Flat;
                WorkerBtn.BackColor = Color.Lime;
                WorkerBtn.Location = new Point(X, Y);
                WorkerBtn.Size = new Size(150, 80);
                WorkerBtn.Text = firstName;
                WorkerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                WorkerBtn.UseVisualStyleBackColor = true;

                Form1 form1 = new Form1();
                WorkerBtn.Click += new System.EventHandler(this.ArrayBtn_Click);


                this.ArrayPanel.Controls.Add(WorkerBtn);

                X += 170;
                if (i % 6==5)
                {
                    X = 50;
                    Y += 100;
                }
            }
        }

        public string Password { get; set; }
        private void ArrayBtn_Click(object sender, EventArgs e)
        {
            parolPanel.Visible = true;

            ish_meneger_panel.Visible = false;
            ArrayPanel.Visible = false;

            Button button=(Button)sender;

            string path = ResourseConstants.DB_JSON_WORKERS_FILE_PATH;
            string jsonContent = File.ReadAllText(path);
            var workers = JsonConvert.DeserializeObject<List<Workers>>(jsonContent);

            foreach(var worker in workers)
            {
                if (button.Text == worker.FirstName)
                {
                    Password=worker.Password;
                }
            }
        }


        private void ArrayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        

        public void meneg_panel_true()
        {
            ish_meneger_panel.Visible=true;

            parolPanel.Visible=false;
        }

        private void lbParolDate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ish_meneger_panel.Visible = true;

            parolPanel.Visible =false;
            ArrayPanel.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ish_meneger_panel.Visible = true;

            parolPanel.Visible = false;
            ArrayPanel.Visible = false;
        }
    }
}
