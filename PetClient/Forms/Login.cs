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


    public partial class Login : Form
    {
        userBUS UserBUS;
        public Login()
        {
            UserBUS = new userBUS();
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                UserBUS.check();
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem", "Warning!");
            }
            tbPass.Text = "";
            tbPass.PasswordChar = '*';
            tbPass.MaxLength = 16;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbUser.Text) &&
               string.IsNullOrWhiteSpace(tbPass.Text))
            {
                MessageBox.Show("Please Fill All The Fields", "Warning!");
                return;
            }

            User CurUser = new User()
            {
                USER = tbUser.Text,
                PASS = tbPass.Text
            };

            FirebaseResponse res = UserBUS.client.Get(@"user/" + tbUser.Text);
            User ResUser = res.ResultAs<User>();

            if (User.IsEqual(CurUser,ResUser))
            {

                this.Hide();
                Menu f = new Menu();
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();

                
                this.Close();
                
            }

            else
            {
                User.ShowError();
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {

        }

       

        
    } 
}
