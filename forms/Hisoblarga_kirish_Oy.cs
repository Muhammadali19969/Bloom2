using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bloom2.forms
{
    public partial class Hisoblarga_kirish_Oy : Form
    {
        public Dictionary<string, string> dic = new Dictionary<string, string>();
        public static string buttonText = string.Empty;
        public static bool check = false;

        public Hisoblarga_kirish_Oy()
        {
            InitializeComponent();
        }
        private void Hisoblarga_kirish_Oy_Load(object sender, EventArgs e)
        {
            dategunaLbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            TimegunaLbl.Text = DateTime.Now.ToLongTimeString();
        }


        private void hison1Btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TaomMenyu taomMenyu = new TaomMenyu();

            buttonText=button.Text;

            if (hisob1Lbl.ForeColor == Color.White && button.Text=="1-HISOB")
            {
                taomMenyu.hisob_1 = true;
            }


            if (hisob2Lbl.ForeColor == Color.White && button.Text == "2-HISOB")
            {
                taomMenyu.hisob_2 = true;
            }

            if (hisob3Lbl.ForeColor == Color.White && button.Text == "3-HISOB")
            {
                taomMenyu.hisob_3 = true;
            }

            if (hisob4Lbl.ForeColor == Color.White && button.Text == "4-HISOB")
            {
                taomMenyu.hisob_4 = true;
            }

            if (hisob5Lbl.ForeColor == Color.White && button.Text == "5-HISOB")
            {
                taomMenyu.hisob_5 = true;
            }
            this.Hide();
            taomMenyu.ShowDialog();
            this.Show();

            if (button.Text == "1-HISOB" && check)
            {
                hisob1Lbl.BackColor = Color.Red;
                hisob1Lbl.ForeColor = Color.White;
                hisob1Lbl.Text = "Band";
                
            }
            else if(button.Text == "1-HISOB" && !check)
            {
                hisob1Lbl.ForeColor = Color.Black;
                hisob1Lbl.BackColor = Color.SkyBlue;
                hisob1Lbl.Text = "Bo'sh";
            }

            if (button.Text == "2-HISOB" && check)
            {
                hisob2Lbl.BackColor = Color.Red;
                hisob2Lbl.ForeColor = Color.White;
                hisob2Lbl.Text = "Band";

            }
            else if (button.Text == "2-HISOB" && !check)
            {
                hisob2Lbl.ForeColor = Color.Black;
                hisob2Lbl.BackColor = Color.SkyBlue;
                hisob2Lbl.Text = "Bo'sh";
            }

            if (button.Text == "3-HISOB" && check)
            {
                hisob3Lbl.BackColor = Color.Red;
                hisob3Lbl.ForeColor = Color.White;
                hisob3Lbl.Text = "Band";

            }

            else if (button.Text == "3-HISOB" && !check)
            {
                hisob3Lbl.ForeColor = Color.Black;
                hisob3Lbl.BackColor = Color.SkyBlue;
                hisob3Lbl.Text = "Bo'sh";
            }


            if (button.Text == "4-HISOB" && check)
            {
                hisob4Lbl.BackColor = Color.Red;
                hisob4Lbl.ForeColor = Color.White;
                hisob4Lbl.Text = "Band";

            }
            else if (button.Text == "4-HISOB" && !check)
            {
                hisob4Lbl.ForeColor = Color.Black;
                hisob4Lbl.BackColor = Color.SkyBlue;
                hisob4Lbl.Text = "Bo'sh";
            }

            if (button.Text == "5-HISOB" && check)
            {
                hisob5Lbl.BackColor = Color.Red;
                hisob5Lbl.ForeColor = Color.White;
                hisob5Lbl.Text = "Band";

            }

            else if (button.Text == "5-HISOB" && !check)
            {
                hisob5Lbl.ForeColor = Color.Black;
                hisob5Lbl.BackColor = Color.SkyBlue;
                hisob5Lbl.Text = "Bo'sh";
            }

        }
        

        private void orqaga_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void asosiyOynaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

       

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimegunaLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }    
}
