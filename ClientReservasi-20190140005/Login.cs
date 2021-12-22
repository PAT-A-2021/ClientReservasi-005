using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_20190140005
{
    public partial class Login : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            string kategori = service.Login(username, password);

            if (kategori == "Admin")
            {
                Register r = new Register();
                Hide();
                r.Show();
            }
            else if (kategori == "Resepsionis")
            {
                Form1 f = new Form1();
                Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password invalid, silahkan hubungi admin.");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
        }
    }
}
