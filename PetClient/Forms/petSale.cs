using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PetClient.DTO;
using System.Net;
using Newtonsoft.Json;
using PetClient.BLL;

namespace PetClient.Forms
{
    public partial class petSale : Form
    {
        String response = "";
        public petSale()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void petSale_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            response = client.DownloadString("http://petshopmng.gear.host/api/pets"); //HttpGet
            //MessageBox.Show(response);
            List<petSa> pet = JsonConvert.DeserializeObject<List<petSa>>(response);
            dataGridView1.DataSource = pet;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //    if (tbSearch.Text.Trim().Length > 0)
            //    {
            //        dataGridView1.DataSource = new PetBUS().GetSelectByName(tbSearch.Text.Trim());
            //    }
            //    else
            //    {
            //        dataGridView1.DataSource = new PetBUS().GetAll();
            //    }
            String keyword = tbSearch.Text.Trim();
            WebClient client = new WebClient();
            if (keyword.Length > 0)
            {
                response = client.DownloadString("http://petshopmng.gear.host/api/pets/search/" + keyword);

            }
            else
            {
                response = client.DownloadString("http://petshopmng.gear.host/api/pets"); //HttpGet
            }
            //MessageBox.Show(response);
            List<petSa> pet = JsonConvert.DeserializeObject<List<petSa>>(response);
            dataGridView1.DataSource = pet;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (new PetBUS().Insert(BuildItem()))
            //{
            //    dataGridView1.DataSource = new PetBUS().GetAll().ToList();
            //    ClearEditText();
            //    MessageBox.Show("Insert Successful!");
            //}
            //else MessageBox.Show("Insert Failed!");
            petSa newPet = new petSa()
            {
                ID = int.Parse(tbID.Text.Trim()),
                Type = tbType.Text.Trim(),
                Gender = tbGender.Text.Trim(),
                Weight = float.Parse(tbWeight.Text.Trim()),
                Age = tbAge.Text.Trim(),
                Price = int.Parse(tbPrice.Text.Trim()),
                //img = tbTypePet.Text.Trim(),
                
            };
            String data = JsonConvert.SerializeObject(newPet);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            response = client.UploadString("http://petshopmng.gear.host/api/pets", "POST", data); //HttpPOST
            if (response != null)
            {
                String response_1 = client.DownloadString("http://petshopmng.gear.host/api/pets"); //HttpGet
                List<petSa> pet = JsonConvert.DeserializeObject<List<petSa>>(response_1);
                dataGridView1.DataSource = pet;
            }
            
        }
        //private petSa BuildItem()
        //{

        //    petSa itemPets = new petSa()
        //    {
        //        ID = int.Parse(tbID.Text.ToString().Replace(" ", "")),
        //        Type = tbType.Text.ToString().Replace(" ", ""),
        //        Gender = tbGender.Text.ToString().Replace(" ", ""),
        //        Weight = float.Parse(tbGender.Text.ToString().Replace(" ", "")),
        //        Age = tbAge.Text.ToString().Replace(" ", ""),
        //        Price = int.Parse(tbPrice.Text.ToString().Replace(" ", "")),
               
                
        //    };
        //    return itemPets;
        //}
        //private void ClearEditText()
        //{
        //    tbID.Text = "";
        //    tbType.Text = "";
        //    tbGender.Text = "";
        //    tbWeight.Text = "";
        //    tbAge.Text = "";
        //    tbPrice.Text ="";
            
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (new PetBUS().Update(BuildItem()))
            //{
            //    dataGridView1.DataSource = new PetBUS().GetAll().ToList();
            //    ClearEditText();
            //    MessageBox.Show("Update Successful!");
            //}
            //else MessageBox.Show("Update Failed!");
            petSa newPet = new petSa()
            {
                ID = int.Parse(tbID.Text.Trim()),
                Type = tbType.Text.Trim(),
                Gender = tbGender.Text.Trim(),
                Weight = float.Parse(tbWeight.Text.Trim()),
                Age = tbAge.Text.Trim(),
                Price = int.Parse(tbPrice.Text.Trim()),
                //img = tbTypePet.Text.Trim(),
            };
            String data = JsonConvert.SerializeObject(newPet);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            response = client.UploadString("http://petshopmng.gear.host/api/pets/" + int.Parse(tbID.Text.Trim()), "PUT", data); //HttpPUT
            if (response != null)
            {
                String response_1 = client.DownloadString("http://petshopmng.gear.host/api/pets");
                List<petSa> pet = JsonConvert.DeserializeObject<List<petSa>>(response_1);
                dataGridView1.DataSource = pet;
                //ClearEditText();
                MessageBox.Show("Update Successful!");
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String data = JsonConvert.SerializeObject(new object());
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            if (MessageBox.Show("Do you want to Delete??", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                response = client.UploadString("http://petshopmng.gear.host/api/pets/" + int.Parse(tbID.Text.Trim()), "DELETE", data); //HttpDelete
                if (response != null)
                {
                    String response_1 = client.DownloadString("http://petshopmng.gear.host/api/pets");
                    List<petSa> pet = JsonConvert.DeserializeObject<List<petSa>>(response_1);
                    dataGridView1.DataSource = pet;
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
            response = client.DownloadString("http://petshopmng.gear.host/api/pets"); //HttpGet
            //MessageBox.Show(response);
            List<petSa> pets = JsonConvert.DeserializeObject<List<petSa>>(response);

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            if (selectedrowindex != -1)
            {
                tbID.Text = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
                tbType.Text = dataGridView1.Rows[selectedrowindex].Cells[1].Value.ToString();
                tbGender.Text = dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString();
                tbWeight.Text = dataGridView1.Rows[selectedrowindex].Cells[3].Value.ToString();
                tbAge.Text = dataGridView1.Rows[selectedrowindex].Cells[4].Value.ToString();
                tbPrice.Text = dataGridView1.Rows[selectedrowindex].Cells[5].Value.ToString();
                //picPet.Text = dataGridView1.Rows[selectedrowindex].Cells[6].Value.ToString();

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
