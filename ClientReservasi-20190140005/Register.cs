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
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Register()
        {
                InitializeComponent();
                TampilData();
                textBoxID.Visible = false;
                btUpdate.Enabled = false;
                btHapus.Enabled = false;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string kategori = comboBoxKategori.Text;
            string a = service.Register(username, password, kategori);

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || comboBoxKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string kategori = comboBoxKategori.Text;
            int id = Int32.Parse(textBoxID.Text);
            string a = service.UpdateRegister(username, password, kategori, id);

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || comboBoxKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;

            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Hapus Data", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string a = service.DeleteRegister(username);
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void TampilData()
        {
            var list = service.DataRegist();
            dtRegister.DataSource = list;
        }
        private void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxKategori.SelectedItem = null;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void dtRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[0].Value);
            textBoxUsername.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[1].Value);
            textBoxPassword.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[2].Value);
            comboBoxKategori.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[3].Value);

            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            btSimpan.Enabled = false;
        }
    }
}
