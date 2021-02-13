namespace ConfigNetAdapter.WinForms
{
    partial class ManageProfiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProfiles));
            this.listBoxProfiles = new System.Windows.Forms.ListBox();
            this.bsProfiles = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProfiles
            // 
            this.listBoxProfiles.AccessibleDescription = null;
            this.listBoxProfiles.AccessibleName = null;
            resources.ApplyResources(this.listBoxProfiles, "listBoxProfiles");
            this.listBoxProfiles.BackgroundImage = null;
            this.listBoxProfiles.DataSource = this.bsProfiles;
            this.listBoxProfiles.DisplayMember = "Name";
            this.listBoxProfiles.Font = null;
            this.listBoxProfiles.FormattingEnabled = true;
            this.listBoxProfiles.Name = "listBoxProfiles";
            this.listBoxProfiles.ValueMember = "Path";
            this.listBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.listBoxProfiles_SelectedIndexChanged);
            // 
            // bsProfiles
            // 
            this.bsProfiles.DataSource = typeof(ConfigNetAdapter.BO.Profiles);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnDel
            // 
            this.btnDel.AccessibleDescription = null;
            this.btnDel.AccessibleName = null;
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.BackgroundImage = null;
            this.btnDel.Name = "btnDel";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = null;
            this.btnNew.AccessibleName = null;
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.BackgroundImage = null;
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ManageProfiles
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProfiles);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.MaximizeBox = false;
            this.Name = "ManageProfiles";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ManageProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.BindingSource bsProfiles;
    }
}