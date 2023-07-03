using Bloom2.Contants;
using Bloom2.Models;
using Bloom2.forms;
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
    public partial class IshchilarOynasi : Form
    {
        public IshchilarOynasi()
        {
            InitializeComponent();
        }

        private void IshchilarOynasi_Load(object sender, EventArgs e)
        {
            
        }


        private void createMenBtn_Click(object sender, EventArgs e)
        {
            Workers worker = new Workers();
            if (firstNameMenTb.Text == "" || lastNameMenTb.Text == "" || passMenTb.Text == "" || phoneNumberMenTb.Text == "")
            {
                messageLbl.ForeColor = Color.Red;
                messageLbl.Text = "Ma'lumotlar to'liq kiritilmadi !";

            }


            else
            {

                string jsonContent = File.ReadAllText(ResourseConstants.DB_JSON_MANEGER_FILE_PATH);
                var workers = JsonConvert.DeserializeObject<List<Workers>>(jsonContent);

                worker.FirstName = firstNameMenTb.Text;
                worker.LastName = lastNameMenTb.Text;
                worker.Password = passMenTb.Text;
                worker.PhoneNumber = phoneCodeLbl.Text + phoneNumberMenTb.Text;

                workers.Add(worker);
                jsonContent = JsonConvert.SerializeObject(workers);

                string path = ResourseConstants.DB_JSON_MANEGER_FILE_PATH;

                File.WriteAllText(path, jsonContent);

                messageLbl.ForeColor = Color.Blue;
                messageLbl.Text = "Malumot yozildi !";
                firstNameMenTb.Text = "";
                lastNameMenTb.Text = "";
                passMenTb.Text = "";
                phoneNumberMenTb.Text = string.Empty;
                
                this.Close();
            }
        }

        private void CancelMenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phoneNumberMenTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberMenTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void passMenTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
