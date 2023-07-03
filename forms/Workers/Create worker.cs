using Bloom2.Contants;
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

namespace Bloom2.forms
{
    public partial class Create_worker : Form
    {
        public Create_worker()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            WorkerInformationTable workerInformationTable = new WorkerInformationTable();
            workerInformationTable.Show();
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            Workers worker = new Workers();
            if (firstNameTb.Text == "" || lastNameTb.Text == "" || passTb.Text == "" || phoneNumberTb.Text == "" )
            {
                messageLbl.ForeColor = Color.Red;
                messageLbl.Text = "Ma'lumotlar to'liq kiritilmadi !";

            }
            

            else
            {

                string jsonContent = File.ReadAllText(ResourseConstants.DB_JSON_WORKERS_FILE_PATH);
                var workers = JsonConvert.DeserializeObject<List<Workers>>(jsonContent);
                long id = 0;
                if (workers.Count>0)
                {
                    id = workers[workers.Count - 1].Id;
                }

                worker.Id = id+=1;
                worker.FirstName = firstNameTb.Text;
                worker.LastName = lastNameTb.Text;
                worker.Password = passTb.Text;
                worker.PhoneNumber = phoneCodeLbl.Text+phoneNumberTb.Text;

                workers.Add(worker);
                jsonContent = JsonConvert.SerializeObject(workers);

                string path = ResourseConstants.DB_JSON_WORKERS_FILE_PATH;

                File.WriteAllText(path, jsonContent);

                messageLbl.ForeColor = Color.Blue;
                messageLbl.Text = "Malumot yozildi !";
                firstNameTb.Text = "";
                lastNameTb.Text = "";
                passTb.Text = "";
                phoneNumberTb.Text = string.Empty;
                WorkerInformationTable workerInformationTable = new WorkerInformationTable();

                this.Close();
                workerInformationTable.ShowDialog();
            }

            
        }

        private void phoneNumberTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void passTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
