namespace ConfigNetAdapter.WinForms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cmbBoxProfiles = new System.Windows.Forms.ComboBox();
            this.bsProfiles = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAdapters = new System.Windows.Forms.ListBox();
            this.bsAdapters = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.tsLang = new System.Windows.Forms.ToolStrip();
            this.tsBtnLang = new System.Windows.Forms.ToolStripButton();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdapters)).BeginInit();
            this.tsLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxProfiles
            // 
            this.cmbBoxProfiles.DataSource = this.bsProfiles;
            this.cmbBoxProfiles.DisplayMember = "Name";
            this.cmbBoxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbBoxProfiles, "cmbBoxProfiles");
            this.cmbBoxProfiles.FormattingEnabled = true;
            this.cmbBoxProfiles.Name = "cmbBoxProfiles";
            this.cmbBoxProfiles.ValueMember = "Path";
            this.cmbBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProfiles_SelectedIndexChanged);
            // 
            // bsProfiles
            // 
            this.bsProfiles.DataSource = typeof(ConfigNetAdapter.BO.Profiles);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // listBoxAdapters
            // 
            this.listBoxAdapters.DataSource = this.bsAdapters;
            this.listBoxAdapters.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxAdapters, "listBoxAdapters");
            this.listBoxAdapters.Name = "listBoxAdapters";
            this.listBoxAdapters.SelectedIndexChanged += new System.EventHandler(this.listBoxAdapters_SelectedIndexChanged);
            // 
            // bsAdapters
            // 
            this.bsAdapters.DataSource = typeof(ConfigNetAdapter.BO.Adapters);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnProfiles
            // 
            resources.ApplyResources(this.btnProfiles, "btnProfiles");
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.UseVisualStyleBackColor = true;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // tsLang
            // 
            this.tsLang.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tsLang, "tsLang");
            this.tsLang.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsLang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnLang});
            this.tsLang.Name = "tsLang";
            this.tsLang.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // tsBtnLang
            // 
            this.tsBtnLang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLang.Image = global::ConfigNetAdapter.WinForms.Properties.Resources.flag_bg;
            resources.ApplyResources(this.tsBtnLang, "tsBtnLang");
            this.tsBtnLang.Name = "tsBtnLang";
            this.tsBtnLang.Click += new System.EventHandler(this.tsBtnLang_Click);
            // 
            // ssInfo
            // 
            resources.ApplyResources(this.ssInfo, "ssInfo");
            this.ssInfo.Name = "ssInfo";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.tsLang);
            this.Controls.Add(this.btnProfiles);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAdapters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxProfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdapters)).EndInit();
            this.tsLang.ResumeLayout(false);
            this.tsLang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxProfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAdapters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.BindingSource bsProfiles;
        private System.Windows.Forms.BindingSource bsAdapters;
        private System.Windows.Forms.ToolStrip tsLang;
        private System.Windows.Forms.ToolStripButton tsBtnLang;
        private System.Windows.Forms.StatusStrip ssInfo;
    }
}

