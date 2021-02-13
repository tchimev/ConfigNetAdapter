using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Xml;
using System.Xml.Linq;

namespace ConfigNetAdapter.WinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.bsProfiles.DataSource = BO.Profiles.GetAll();
            this.bsAdapters.DataSource = BO.Adapters.GetAll();
            this.cmbBoxProfiles.SelectedIndex = -1;
            this.listBoxAdapters.SelectedIndex = -1;
            this.ChangeLang(Properties.Settings.Default.SecondLang);
        }

        private void ChangeLang(string lang)
        {
            string culture = string.Empty;
            string btnLangTitle = string.Empty;
            Bitmap btnLangImg = null;
            if (lang == "bul")
            {
                culture = "en-US";
                btnLangTitle = "Български";
                btnLangImg = Properties.Resources.flag_bg;
            }
            else
            {
                culture = "bg-BG";
                btnLangTitle = "English";
                btnLangImg = Properties.Resources.flag_en;
            }

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            this.tsBtnLang.Image = btnLangImg;
            this.tsBtnLang.ToolTipText = btnLangTitle;
            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
            foreach (Control c in this.Controls)
                resources.ApplyResources(c, c.Name, new CultureInfo(culture));
            resources.ApplyResources(this, "$this", new CultureInfo(culture));

            this.SaveLastUsedLang(lang);
        }

        private void SaveLastUsedLang(string lang)
        { 
            XDocument xdoc = XDocument.Load("ConfigNetAdapter.WinForms.exe.config");
            XElement oldLang = (from x in xdoc.Element("configuration").Element("applicationSettings").Element("ConfigNetAdapter.WinForms.Properties.Settings").Elements()
                                where x.HasAttributes && x.FirstAttribute.Value == "SecondLang"
                                select x.Element("value")).SingleOrDefault();
            oldLang.SetValue(lang);
            xdoc.Save("ConfigNetAdapter.WinForms.exe.config");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            BO.AdapterProfile ap = BO.AdapterProfile.Create(this.listBoxAdapters.SelectedValue.ToString(), this.cmbBoxProfiles.SelectedItem as BO.Profile);
            try
            {
                ap.ApplyProfile();
                MessageBox.Show("Network settings updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ap.Dispose();
            }
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ManageProfiles mpForm = new ManageProfiles(this.bsProfiles.DataSource))
            {
                mpForm.ShowDialog();
            }
            this.Show();
            this.bsProfiles.DataSource = BO.Profiles.GetAll();
            this.cmbBoxProfiles.SelectedIndex = -1;
        }

        private void listBoxAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetApplyBtn();
        }

        private void cmbBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetApplyBtn();
        }

        private void SetApplyBtn()
        {
            this.btnApply.Enabled = (this.listBoxAdapters.SelectedIndex != -1 && this.cmbBoxProfiles.SelectedIndex != -1);
        }

        private void tsBtnLang_Click(object sender, EventArgs e)
        {
            this.ChangeLang(Thread.CurrentThread.CurrentUICulture.ThreeLetterISOLanguageName);
        }
    }
}
