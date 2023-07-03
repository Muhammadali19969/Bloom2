using Bloom2.Contants;
using Bloom2.Models;
using Emgu.CV.ML.MlEnum;
using Newtonsoft.Json;
using OpenTK.Graphics.ES30;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace Bloom2.forms
{
    
    public partial class TaomMenyu : Form
    {
        List<Foods> foods = new List<Foods>();

        public static Dictionary<string, string> dct = new Dictionary<string, string>
        {
            ["hisob_1"] = "",
            ["hisob_2"] = "",
            ["hisob_3"] = "",
            ["hisob_4"] = "",
            ["hisob_5"] = ""
        };
        List<Foods> arrayList = new List<Foods>();

        List<Foods> list = new List<Foods>();

        public bool hisob_1=false;
        public bool hisob_2=false;
        public bool hisob_3=false;
        public bool hisob_4=false;
        public bool hisob_5=false;




        public TaomMenyu()
        {
            
            InitializeComponent();
        }

        public int id = 0;
        public int price = 0;
        public int countPrice = 1;
        public string nameFood;
        public string priceFood;
        public int priceForDataGrid;

        DataTable table = new DataTable();
        private void TaomMenyu_Load(object sender, EventArgs e)
        {

            /*table.Columns.Add("Id", typeof(int));
            table.Columns.Add("mahsulot", typeof(string));
            table.Columns.Add("soni", typeof(string));
            table.Columns.Add("narxi", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[2].Width = 50;

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;*/




            panelOmmabop.Visible = true;

            panelBurger.Visible = false;
            panelSandwich.Visible = false;
            panelLavash.Visible = false;
            panelShaurma.Visible = false; ;
            panelHotdog.Visible = false;
            panelKartoshka.Visible = false;
            panelShirinlik.Visible = false;
            panelMoxito.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;

            if (hisob_1)
            {
                priceShowLbl.Text = dct["hisob_1"];
                price = int.Parse(dct["hisob_1"]);
                string path = ResourseConstants.DB_JSON_FOODS1_FILE_PATH;
                string jsonContent = File.ReadAllText(path);
                list.Clear();
                list = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);

                muve();
            }

            if (hisob_2)
            {
                priceShowLbl.Text = dct["hisob_2"];
                price = int.Parse(dct["hisob_2"]);
                string path = ResourseConstants.DB_JSON_FOODS2_FILE_PATH;
                string jsonContent = File.ReadAllText(path);
                var foods = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);
                list.Clear();
                list = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);

                muve();
            }

            if (hisob_3)
            {
                priceShowLbl.Text = dct["hisob_3"];
                price = int.Parse(dct["hisob_3"]);
                string path = ResourseConstants.DB_JSON_FOODS3_FILE_PATH;
                string jsonContent = File.ReadAllText(path);
                var foods = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);
                list.Clear();
                list = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);

                muve();

            }

            if (hisob_4)
            {
                priceShowLbl.Text = dct["hisob_4"];
                price = int.Parse(dct["hisob_4"]);
                string path = ResourseConstants.DB_JSON_FOODS4_FILE_PATH;
                string jsonContent = File.ReadAllText(path);
                var foods = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);
                list.Clear();
                list = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);

                muve();

            }

            if (hisob_5)
            {
                priceShowLbl.Text = dct["hisob_5"];
                price = int.Parse(dct["hisob_5"]);
                string path = ResourseConstants.DB_JSON_FOODS5_FILE_PATH;
                string jsonContent = File.ReadAllText(path);
                var foods = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);
                list.Clear();
                list = JsonConvert.DeserializeObject<List<Foods>>(jsonContent);

                muve();

            }




        }


        private void colaBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string[] narx = btn.Text.Split('\n');

            nameFood = narx[0];
            priceFood = narx[1];

            nameFoodLbl.Text = nameFood;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            if (nameFoodLbl.Text != "")
            {
                countPrice++;
                countFoodLbl.Text = countPrice.ToString();
            }

        }

        private void removeFoodBtn_Click(object sender, EventArgs e)
        {
            if (countPrice > 1)
            {
                countPrice--;
            }

            countFoodLbl.Text = countPrice.ToString();
        }

        public void okBtn_Click(object sender, EventArgs e)
        {
            
            if (nameFoodLbl.Text != "")
            {
                id = list.Count + 1;

                int narh = int.Parse(priceFood);
                priceForDataGrid = countPrice * narh;

                price += priceForDataGrid;
                priceShowLbl.Text = price.ToString();

                

                Foods food = new Foods();

                if (Hisoblarga_kirish_Oy.buttonText == "1-HISOB")
                {
                    dct["hisob_1"]=price.ToString();
                    //food.Id = id;
                    food.mahsulot = nameFood;
                    food.soni=countFoodLbl.Text;
                    food.narxi = priceForDataGrid.ToString();

                    list.Add(food);
                    string path = ResourseConstants.DB_JSON_FOODS1_FILE_PATH;
                    string jsonContent = JsonConvert.SerializeObject(list);
                    File.WriteAllText(path, jsonContent);

                }

                if(Hisoblarga_kirish_Oy.buttonText == "2-HISOB")
                {
                    dct["hisob_2"] = price.ToString();
                    //food.Id = id;
                    food.mahsulot = nameFood;
                    food.soni = countFoodLbl.Text;
                    food.narxi = priceForDataGrid.ToString();

                    list.Add(food);
                    string path = ResourseConstants.DB_JSON_FOODS2_FILE_PATH;
                    string jsonContent = JsonConvert.SerializeObject(list);
                    File.WriteAllText(path, jsonContent);
                }

                if (Hisoblarga_kirish_Oy.buttonText == "3-HISOB")
                {
                    dct["hisob_3"] = price.ToString();

                    //food.Id = id;
                    food.mahsulot = nameFood;
                    food.soni = countFoodLbl.Text;
                    food.narxi = priceForDataGrid.ToString();

                    list.Add(food);
                    string path = ResourseConstants.DB_JSON_FOODS3_FILE_PATH;
                    string jsonContent = JsonConvert.SerializeObject(list);
                    File.WriteAllText(path, jsonContent);
                }

                if (Hisoblarga_kirish_Oy.buttonText == "4-HISOB")
                {
                    dct["hisob_4"] = price.ToString();

                    //food.Id = id;
                    food.mahsulot = nameFood;
                    food.soni = countFoodLbl.Text;
                    food.narxi = priceForDataGrid.ToString();

                    list.Add(food);
                    string path = ResourseConstants.DB_JSON_FOODS4_FILE_PATH;
                    string jsonContent = JsonConvert.SerializeObject(list);
                    File.WriteAllText(path, jsonContent);
                }

                if (Hisoblarga_kirish_Oy.buttonText == "5-HISOB")
                {
                    dct["hisob_5"] = price.ToString();

                    //food.Id = id;
                    food.mahsulot = nameFood;
                    food.soni = countFoodLbl.Text;
                    food.narxi = priceForDataGrid.ToString();

                    list.Add(food);
                    string path = ResourseConstants.DB_JSON_FOODS5_FILE_PATH;
                    string jsonContent = JsonConvert.SerializeObject(list);
                    File.WriteAllText(path, jsonContent);
                }
                muve();





                countPrice = 1;
                countFoodLbl.Text = "1";
                nameFoodLbl.Text = "";

                panelOmmabop.Visible = true;

                panelLavash.Visible = false;
                panelSandwich.Visible = false;
                panelBurger.Visible = false;
                panelShaurma.Visible = false;
                panelHotdog.Visible = false;
                panelKartoshka.Visible = false;
                panelShirinlik.Visible = false;
                panelMoxito.Visible = false;
                panelSalqin.Visible = false;
                panelMevali.Visible = false;

            }
        }
        public void muve()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;

            /* table.Columns.Add("Id", typeof(int));
             table.Columns.Add("mahsulot", typeof(string));
             table.Columns.Add("soni", typeof(string));
             table.Columns.Add("narxi", typeof(string));


             foreach(var i in list)
             {
                 table.Rows.Add(i.Id,i.mahsulot,i.soni,i.narxi);
             }
             dataGridView1.DataSource = table;

             dataGridView1.Columns[0].Width = 50;
             dataGridView1.Columns[2].Width = 50;

             dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
             dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
             dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
             dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;*/


        }



        private void burgerBtn_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelBurger.Visible = true;

            panelHotdog.Visible = false;
            panelShaurma.Visible = false; ;
            panelLavash.Visible = false;
            panelSandwich.Visible = false;
            panelOmmabop.Visible = false;
            panelKartoshka.Visible = false;
            panelShirinlik.Visible = false;
            panelMoxito.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;

        }

        private void sandwichBtn_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelSandwich.Visible = true;

            panelHotdog.Visible = false;
            panelShaurma.Visible = false;
            panelLavash.Visible=false;
            panelBurger.Visible=false;
            panelOmmabop.Visible = false;
            panelKartoshka.Visible = false;
            panelShirinlik.Visible = false;
            panelMoxito.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;

        }

        private void OrqagaBtn_Click(object sender, EventArgs e)
        {
            

            this.Close();
        }

        private void lavashBtn_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelLavash.Visible = true;

            panelHotdog.Visible = false;
            panelShaurma.Visible = false;
            panelSandwich.Visible = false;
            panelBurger.Visible = false;
            panelOmmabop.Visible = false;
            panelKartoshka.Visible = false;
            panelShirinlik.Visible = false;
            panelMoxito.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;

        }

        private void shaurmaBtn_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelShaurma.Visible = true;

            panelHotdog.Visible = false;
            panelSandwich.Visible = false;
            panelBurger.Visible = false;
            panelOmmabop.Visible = false;
            panelLavash.Visible = false;
            panelKartoshka.Visible = false;
            panelShirinlik.Visible = false;
            panelMoxito.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;

        }

        private void hotdogBtn_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelHotdog.Visible = true;

            panelShaurma.Visible = false;
            panelSandwich.Visible = false;
            panelBurger.Visible = false;
            panelOmmabop.Visible = false;
            panelLavash.Visible = false;
            panelKartoshka.Visible = false;
            panelShirinlik.Visible = false;
            panelMoxito.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;


        }

        private void kartoshkaBtn_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelKartoshka.Visible = true;

            panelHotdog.Visible = false;
            panelShaurma.Visible = false;
            panelSandwich.Visible = false;
            panelBurger.Visible = false;
            panelOmmabop.Visible = false;
            panelLavash.Visible = false;
            panelShirinlik.Visible = false;
            panelMoxito.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;

        }

        private void shirinlikBtn_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelShirinlik.Visible = true;

            panelKartoshka.Visible = false;
            panelHotdog.Visible = false;
            panelShaurma.Visible = false;
            panelSandwich.Visible = false;
            panelBurger.Visible = false;
            panelOmmabop.Visible = false;
            panelLavash.Visible = false;
            panelMoxito.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;

        }

        private void moxitoBtn_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelMoxito.Visible = true;

            panelShirinlik.Visible = false;
            panelKartoshka.Visible = false;
            panelHotdog.Visible = false;
            panelShaurma.Visible = false;
            panelSandwich.Visible = false;
            panelBurger.Visible = false;
            panelOmmabop.Visible = false;
            panelLavash.Visible = false;
            panelSalqin.Visible = false;
            panelMevali.Visible = false;

        }

        private void salqinIch_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelSalqin.Visible = true;

            panelMoxito.Visible = false;
            panelShirinlik.Visible = false;
            panelKartoshka.Visible = false;
            panelHotdog.Visible = false;
            panelShaurma.Visible = false;
            panelSandwich.Visible = false;
            panelBurger.Visible = false;
            panelOmmabop.Visible = false;
            panelLavash.Visible = false;
            panelMevali.Visible = false;
        }

        private void mevaliChoy_Click(object sender, EventArgs e)
        {
            nameFoodLbl.Text = "";

            panelMevali.Visible = true;

            panelSalqin.Visible = false;
            panelMoxito.Visible = false;
            panelShirinlik.Visible = false;
            panelKartoshka.Visible = false;
            panelHotdog.Visible = false;
            panelShaurma.Visible = false;
            panelSandwich.Visible = false;
            panelBurger.Visible = false;
            panelOmmabop.Visible = false;
            panelLavash.Visible = false;
        }

        private void hisob_yopishBtn_Click(object sender, EventArgs e)
        {
            if (priceShowLbl.Text != "0")
            {
                MessageBox.Show("Chek tayyorlanmoqda !");
            }
            else
            {
                MessageBox.Show("Buyurma kiritilmagan !");

            }

            if (hisob_1)
            {
                Hisoblarga_kirish_Oy.check = false;
                priceShowLbl.Text = "";
                dct["hisob_1"] = "0";
                string path = ResourseConstants.DB_JSON_FOODS1_FILE_PATH;
                File.WriteAllText(path, "[]");
                dataGridView1.DataSource = null;
                hisob_1 = false;
            }
            else if (hisob_2)
            {
                Hisoblarga_kirish_Oy.check = false;
                priceShowLbl.Text = "";
                dct["hisob_2"] = "0";
                string path = ResourseConstants.DB_JSON_FOODS2_FILE_PATH;
                File.WriteAllText(path, "[]");
                dataGridView1.DataSource = null;
                hisob_2 = false;
            }

            else if (hisob_3)
            {
                Hisoblarga_kirish_Oy.check = false;
                priceShowLbl.Text = "";
                dct["hisob_3"] = "0";
                string path = ResourseConstants.DB_JSON_FOODS3_FILE_PATH;
                File.WriteAllText(path, "[]");
                dataGridView1.DataSource = null;
                hisob_3 = false;
            }
            else if (hisob_4)
            {
                Hisoblarga_kirish_Oy.check = false;
                priceShowLbl.Text = "";
                dct["hisob_4"] = "0";
                string path = ResourseConstants.DB_JSON_FOODS4_FILE_PATH;
                File.WriteAllText(path, "[]");
                dataGridView1.DataSource = null;
                hisob_4 = false;
            }
            else if (hisob_5)
            {
                Hisoblarga_kirish_Oy.check = false;
                priceShowLbl.Text = "";
                dct["hisob_5"] = "0";
                string path = ResourseConstants.DB_JSON_FOODS5_FILE_PATH;
                File.WriteAllText(path, "[]");
                dataGridView1.DataSource = null;
                hisob_5 = false;
            }

        }

        private void saqlashBtn_Click_1(object sender, EventArgs e)
        {
            if (priceShowLbl.Text != "0")
            {
                Hisoblarga_kirish_Oy.check = true;
                MessageBox.Show("Buyutma tayyorlanmoqda !");
            }
            else
            {
                MessageBox.Show("Buyutrma kiritilmagan !");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        
}
