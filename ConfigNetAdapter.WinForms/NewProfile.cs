using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ConfigNetAdapter.WinForms
{
    public partial class NewProfile : Form
    {
        public NewProfile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            (this.bsProfile.DataSource as BO.Profile).Save();
            MessageBox.Show("Profile added successfully!");
            this.Close();
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {
            this.bsProfile.DataSource = BO.Profile.New();
            this.ValidateChildren();
        }

        private void radBtnIP_Click(object sender, EventArgs e)
        {
            this.groupBoxIP.Enabled = false;
            this.radBtnDNS.Enabled = true;
        }

        private void radBtnDNS_Click(object sender, EventArgs e)
        {
            this.groupBoxDNS.Enabled = false;
        }

        private void radBtnManualIP_Click(object sender, EventArgs e)
        {
            this.groupBoxIP.Enabled = true;
            this.groupBoxDNS.Enabled = true;
            this.radBtnManualDNS.Checked = true;
            this.radBtnDNS.Enabled = false;
        }

        private void radBtnManualDNS_Click(object sender, EventArgs e)
        {
            this.groupBoxDNS.Enabled = true;
        }
    }
}
