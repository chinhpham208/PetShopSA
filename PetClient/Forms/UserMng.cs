using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using PetClient.DTO;
using PetClient.BLL;

namespace PetClient.Forms
{
    public partial class UserMng : Form
    {
        userBUS UserBUS;
        public UserMng()
        {
            UserBUS = new userBUS();
            InitializeComponent();
        }
        private void UserMng_Load(object sender, EventArgs e)
        {
            try
            {
                UserBUS.check();
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem", "Warning!");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbUser.Text) &&
               string.IsNullOrWhiteSpace(tbPass.Text))
            {
                MessageBox.Show("Please Fill All The Fields", "Warning!");
                return;
            }

            User user = new User()
            {
                USER = tbUser.Text,
                PASS = tbPass.Text,

            };

            SetResponse set = UserBUS.client.Set(@"user/" + tbUser.Text, user);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Successfully registered {tbUser.Text}!", "Information!");
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //show records
        private void btnShowR_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FirebaseResponse res = UserBUS.client.Get(@"user/" + tbUser);
            User std = res.ResultAs<User>();
            if (std.USER != "")
            {
                dataGridView1.Rows.Add(std.USER,std.PASS);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                USER = tbUser.Text,
                PASS = tbPass.Text,
            };
            var update = UserBUS.client.Update(@"user/" + tbUser.Text, user);

            if (update.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Update Information {tbUser.Text} successful!", "Information!");
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }
        }

        private void btnDeleteU_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                USER = tbUser.Text,
                PASS = tbPass.Text,
            };

            var delete = UserBUS.client.Delete(@"user/" + tbUser.Text);
            if (delete.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Delete {tbUser.Text} successful!", "Information!");
            }
            else
            {
                MessageBox.Show("Delete Failed!");
            }
        }

        private void btkBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f = new Menu();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            if (selectedrowindex != -1)
            {
                tbUser.Text = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
                tbPass.Text = dataGridView1.Rows[selectedrowindex].Cells[1].Value.ToString();
            }
        }
    }
}
