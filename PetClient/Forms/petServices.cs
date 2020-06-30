using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PetClient.BLL;
using PetClient.DTO;
using System.Net;
using Newtonsoft.Json;

namespace PetClient.Forms
{
    
    public partial class petServices : Form
    {
        String response = "";
        public petServices()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void petServices_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            response = client.DownloadString("http://petshopmng.gear.host/api/petSers"); //HttpGet
            //MessageBox.Show(response);
            List<petSer> pets = JsonConvert.DeserializeObject<List<petSer>>(response);
            dataGridView1.DataSource = pets;
        }

        private void btnSearchS_Click(object sender, EventArgs e)
        {
            //dataGridView1.AllowUserToAddRows = false;
            //if (tbSearchS.Text.Trim().Length > 0)
            //{
            //    dataGridView1.DataSource = new PetSerBUS().GetSelectByName(tbSearchS.Text.Trim());
            //}
            //else
            //{
            //    dataGridView1.DataSource = new PetSerBUS().GetAll();
            //}
            String keyword = tbSearchS.Text.Trim();

            WebClient client = new WebClient();
            if (keyword.Length > 0)
            {
                response = client.DownloadString("http://petshopmng.gear.host/api/petSers/search/" + keyword);

            }
            else
            {
                response = client.DownloadString("http://petshopmng.gear.host/api/petSers"); //HttpGet
            }
            //MessageBox.Show(response);
            List<petSer> pets = JsonConvert.DeserializeObject<List<petSer>>(response);
            dataGridView1.DataSource = pets;
        }
        private petSer BuildItem()
        {

            petSer itemPets = new petSer()
            {
                ID = int.Parse(tbIdCus.Text.ToString().Replace(" ", "")),
                CusName = tbNameCus.Text.ToString().Replace(" ", ""),
                PetName = tbNamePet.Text.ToString().Replace(" ", ""),
                PetGender = tbGenderPet.Text.ToString().Replace(" ", ""),
                PetAge = tbAgePet.Text.ToString().Replace(" ", ""),
                PetWeight = float.Parse(tbWeightPet.Text.ToString().Replace(" ", "")),
                PetType = tbTypePet.Text.ToString().Replace(" ", ""),
                WhatServices = tbWhat.Text.ToString().Replace(" ", ""),
                

            };
            return itemPets;
        }
        private void ClearEditText()
        {
            tbIdCus.Text = "";
            tbNameCus.Text = "";
            tbNamePet.Text = "";
            tbGenderPet.Text = "";
            tbAgePet.Text = "";
            tbWeightPet.Text = "";
            tbTypePet.Text = "";
            tbWhat.Text ="";

        }
        private void btnAddS_Click(object sender, EventArgs e)
        {

            //if (new PetSerBUS().Insert(BuildItem()))
            //{
            //    dataGridView1.DataSource = new PetBUS().GetAll().ToList();
            //    ClearEditText();
            //    MessageBox.Show("Insert Successful!");
            //}
            //else MessageBox.Show("Insert Failed!");
            petSer newPet = new petSer()
            {
                ID = int.Parse(tbIdCus.Text.Trim()),
                CusName = tbNameCus.Text.Trim(),
                PetName = tbNamePet.Text.Trim(),
                PetGender = tbGenderPet.Text.Trim(),
                PetAge = tbAgePet.Text.Trim(),
                PetWeight = float.Parse(tbWeightPet.Text.Trim()),
                PetType = tbTypePet.Text.Trim(),
                WhatServices = tbWhat.Text.Trim()                
            };
            String data = JsonConvert.SerializeObject(newPet);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            response = client.UploadString("http://petshopmng.gear.host/api/petSers", "POST", data); //HttpPOST
            if (response != null)
            {
                String response_1 = client.DownloadString("http://petshopmng.gear.host/api/petSers"); //HttpGet
                List<petSer> pets = JsonConvert.DeserializeObject<List<petSer>>(response_1);
                dataGridView1.DataSource = pets;
            }
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {

            //if (new PetSerBUS().Update(BuildItem()))
            //{
            //    dataGridView1.DataSource = new PetSerBUS().GetAll().ToList();
            //    ClearEditText();
            //    MessageBox.Show("Update Successful!");
            //}
            //else MessageBox.Show("Update Failed!");
            petSer newPet = new petSer()
            {
                ID = int.Parse(tbIdCus.Text.Trim()),
                CusName = tbNameCus.Text.Trim(),
                PetName = tbNamePet.Text.Trim(),
                PetGender = tbGenderPet.Text.Trim(),
                PetAge = tbAgePet.Text.Trim(),
                PetWeight = float.Parse(tbWeightPet.Text.Trim()),
                PetType = tbTypePet.Text.Trim(),
                WhatServices = tbWhat.Text.Trim()
            };
            String data = JsonConvert.SerializeObject(newPet);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            response = client.UploadString("http://petshopmng.gear.host/api/petSers/" + int.Parse(tbIdCus.Text.Trim()), "PUT", data); //HttpPUT
            if (response != null)
            {
                String response_1 = client.DownloadString("http://petshopmng.gear.host/api/petSers");
                List<petSer> pets = JsonConvert.DeserializeObject<List<petSer>>(response_1);
                dataGridView1.DataSource = pets;
                ClearEditText();
                MessageBox.Show("Update Successful!");
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }
        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {

            //if (MessageBox.Show("Do you want to Delete??", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    if (new PetSerBUS().Update(BuildItem()))
            //    {
            //        dataGridView1.DataSource = new PetSerBUS().GetAll().ToList();
            //        ClearEditText();
            //        MessageBox.Show("Delete Successful!");
            //    }
            //    else MessageBox.Show("Delete Failed!");
            //}
            String data = JsonConvert.SerializeObject(new object());
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            if (MessageBox.Show("Do you want to Delete??", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                response = client.UploadString("http://petshopmng.gear.host/api/petSers/" + int.Parse(tbIdCus.Text.Trim()), "DELETE", data); //HttpDelete
                if (response != null)
                {
                    String response_1 = client.DownloadString("http://petshopmng.gear.host/api/petSers");
                    List<petSer> pets = JsonConvert.DeserializeObject<List<petSer>>(response_1);
                    dataGridView1.DataSource = pets;
                    MessageBox.Show("Delete Successful!");
                }
                else
                {
                    MessageBox.Show("Delete Failed!");
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            response = client.DownloadString("http://petshopmng.gear.host/api/petSers"); //HttpGet
            //MessageBox.Show(response);
            List<petSer> pets = JsonConvert.DeserializeObject<List<petSer>>(response);
            
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            if (selectedrowindex != -1)
            {
                tbIdCus.Text = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
                tbNameCus.Text = dataGridView1.Rows[selectedrowindex].Cells[1].Value.ToString();
                tbNamePet.Text = dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString();
                tbGenderPet.Text = dataGridView1.Rows[selectedrowindex].Cells[3].Value.ToString();
                tbAgePet.Text = dataGridView1.Rows[selectedrowindex].Cells[4].Value.ToString();
                tbWeightPet.Text = dataGridView1.Rows[selectedrowindex].Cells[5].Value.ToString();
                tbTypePet.Text = dataGridView1.Rows[selectedrowindex].Cells[6].Value.ToString();
                tbWhat.Text = dataGridView1.Rows[selectedrowindex].Cells[7].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                String value = e.Value as string;
                if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
                {
                    e.Value = e.CellStyle.NullValue;
                    e.FormattingApplied = true;
                }
            }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f = new Menu();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();


            this.Close();
        }
    }
    
}
