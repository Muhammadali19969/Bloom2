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
    public partial class WorkerInformationTable : Form
    {
        public bool check=true;
        public WorkerInformationTable()
        {
            InitializeComponent();
        }

        
        private void WorkerInformationTable_Load(object sender, EventArgs e)
        {
            RefreshWorkers();
        }

        private void workerAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_worker create_Worker = new Create_worker();
            create_Worker.ShowDialog();
        }

        private void RefreshWorkers()
        {
            string path = ResourseConstants.DB_JSON_WORKERS_FILE_PATH;
            string jsonContent = File.ReadAllText(path);

            var workers = JsonConvert.DeserializeObject<List<Workers>>(jsonContent);

            
            
            informWorkerDgt.DataSource = workers;

            if(workers.Count<1)
            {
                check = false;
            }
            else check = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
                

                if (check)
                {
                        string message = "Tanlagan ma'lumotni rostan o'chirmoqchimisiz ?";
                    if (MessageBox.Show(message, "Bildirishnoma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {


                        int i = informWorkerDgt.CurrentCell.RowIndex;
                        DataGridViewRow row = informWorkerDgt.Rows[i];

                        string id = row.Cells[0].Value.ToString();

                        string path = ResourseConstants.DB_JSON_WORKERS_FILE_PATH;
                        string jsonContent = File.ReadAllText(path);

                        var workers = JsonConvert.DeserializeObject<List<Workers>>(jsonContent);


                        workers.RemoveAt(i);

                        jsonContent = JsonConvert.SerializeObject(workers);

                        File.WriteAllText(path, jsonContent);

                        RefreshWorkers();

                    }
                
                }


                



            
            


        }

        private void informWorkerDgt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
