using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConfigNetAdapter.WinForms
{
    public partial class ManageProfiles : Form
    {
        public ManageProfiles()
        {
            InitializeComponent();
        }

        public ManageProfiles(object profiles) : this()
        {
            this.bsProfiles.DataSource = profiles;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            BO.Profile p = this.listBoxProfiles.SelectedItem as BO.Profile;
            if (p != null)
            {
                p.Delete();
                this.bsProfiles.RemoveCurrent();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (NewProfile npForm = new NewProfile())
            {
                npForm.ShowDialog();
            }
            this.Show();
            this.bsProfiles.DataSource = BO.Profiles.GetAll();
            this.listBoxProfiles.SelectedIndex = -1;
        }

        private void listBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnDel.Enabled = (this.listBoxProfiles.SelectedIndex != -1);
        }

        private void ManageProfiles_Load(object sender, EventArgs e)
        {
            this.listBoxProfiles.SelectedIndex = -1;
        }
    }
}
