using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PetClient.Forms;
namespace PetClient.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            petServices f = new petServices();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMng f = new UserMng();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();

            Close();
        }

        private void btnPetsale_Click(object sender, EventArgs e)
        {
            this.Hide();
            petSale f = new petSale();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();

            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
            
            Close();
        }
    }
}
