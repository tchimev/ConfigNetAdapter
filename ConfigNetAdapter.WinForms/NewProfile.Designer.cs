namespace ConfigNetAdapter.WinForms
{
    partial class NewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.bsProfile = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxDNS = new System.Windows.Forms.GroupBox();
            this.txtBoxADNS = new System.Windows.Forms.TextBox();
            this.txtBoxPDNS = new System.Windows.Forms.TextBox();
            this.groupBoxIP = new System.Windows.Forms.GroupBox();
            this.txtBoxGateway = new System.Windows.Forms.TextBox();
            this.txtBoxMask = new System.Windows.Forms.TextBox();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.radBtnIP = new System.Windows.Forms.RadioButton();
            this.radBtnDNS = new System.Windows.Forms.RadioButton();
            this.errorProviderProfile = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radBtnManualIP = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radBtnManualDNS = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfile)).BeginInit();
            this.groupBoxDNS.SuspendLayout();
            this.groupBoxIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProfile)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.errorProviderProfile.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProviderProfile.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.errorProviderProfile.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProviderProfile.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.errorProviderProfile.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProviderProfile.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.errorProviderProfile.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProviderProfile.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.errorProviderProfile.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProviderProfile.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.errorProviderProfile.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProviderProfile.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = null;
            this.btnSave.AccessibleName = null;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackgroundImage = null;
            this.btnSave.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsProfile, "IsValid", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.errorProviderProfile.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProviderProfile.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bsProfile
            // 
            this.bsProfile.DataSource = typeof(ConfigNetAdapter.BO.Profile);
            // 
            // txtBoxName
            // 
            this.txtBoxName.AccessibleDescription = null;
            this.txtBoxName.AccessibleName = null;
            resources.ApplyResources(this.txtBoxName, "txtBoxName");
            this.txtBoxName.BackgroundImage = null;
            this.txtBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProfile, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProviderProfile.SetError(this.txtBoxName, resources.GetString("txtBoxName.Error"));
            this.errorProviderProfile.SetIconAlignment(this.txtBoxName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxName.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.txtBoxName, ((int)(resources.GetObject("txtBoxName.IconPadding"))));
            this.txtBoxName.Name = "txtBoxName";
            // 
            // groupBoxDNS
            // 
            this.groupBoxDNS.AccessibleDescription = null;
            this.groupBoxDNS.AccessibleName = null;
            resources.ApplyResources(this.groupBoxDNS, "groupBoxDNS");
            this.groupBoxDNS.BackgroundImage = null;
            this.groupBoxDNS.Controls.Add(this.label4);
            this.groupBoxDNS.Controls.Add(this.label5);
            this.groupBoxDNS.Controls.Add(this.txtBoxADNS);
            this.groupBoxDNS.Controls.Add(this.txtBoxPDNS);
            this.errorProviderProfile.SetError(this.groupBoxDNS, resources.GetString("groupBoxDNS.Error"));
            this.errorProviderProfile.SetIconAlignment(this.groupBoxDNS, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxDNS.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.groupBoxDNS, ((int)(resources.GetObject("groupBoxDNS.IconPadding"))));
            this.groupBoxDNS.Name = "groupBoxDNS";
            this.groupBoxDNS.TabStop = false;
            // 
            // txtBoxADNS
            // 
            this.txtBoxADNS.AccessibleDescription = null;
            this.txtBoxADNS.AccessibleName = null;
            resources.ApplyResources(this.txtBoxADNS, "txtBoxADNS");
            this.txtBoxADNS.BackgroundImage = null;
            this.txtBoxADNS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProfile, "AltDNS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProviderProfile.SetError(this.txtBoxADNS, resources.GetString("txtBoxADNS.Error"));
            this.errorProviderProfile.SetIconAlignment(this.txtBoxADNS, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxADNS.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.txtBoxADNS, ((int)(resources.GetObject("txtBoxADNS.IconPadding"))));
            this.txtBoxADNS.Name = "txtBoxADNS";
            // 
            // txtBoxPDNS
            // 
            this.txtBoxPDNS.AccessibleDescription = null;
            this.txtBoxPDNS.AccessibleName = null;
            resources.ApplyResources(this.txtBoxPDNS, "txtBoxPDNS");
            this.txtBoxPDNS.BackgroundImage = null;
            this.txtBoxPDNS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProfile, "PrefDNS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProviderProfile.SetError(this.txtBoxPDNS, resources.GetString("txtBoxPDNS.Error"));
            this.errorProviderProfile.SetIconAlignment(this.txtBoxPDNS, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxPDNS.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.txtBoxPDNS, ((int)(resources.GetObject("txtBoxPDNS.IconPadding"))));
            this.txtBoxPDNS.Name = "txtBoxPDNS";
            // 
            // groupBoxIP
            // 
            this.groupBoxIP.AccessibleDescription = null;
            this.groupBoxIP.AccessibleName = null;
            resources.ApplyResources(this.groupBoxIP, "groupBoxIP");
            this.groupBoxIP.BackgroundImage = null;
            this.groupBoxIP.Controls.Add(this.label1);
            this.groupBoxIP.Controls.Add(this.label2);
            this.groupBoxIP.Controls.Add(this.txtBoxGateway);
            this.groupBoxIP.Controls.Add(this.txtBoxMask);
            this.groupBoxIP.Controls.Add(this.txtBoxIP);
            this.groupBoxIP.Controls.Add(this.label3);
            this.errorProviderProfile.SetError(this.groupBoxIP, resources.GetString("groupBoxIP.Error"));
            this.errorProviderProfile.SetIconAlignment(this.groupBoxIP, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxIP.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.groupBoxIP, ((int)(resources.GetObject("groupBoxIP.IconPadding"))));
            this.groupBoxIP.Name = "groupBoxIP";
            this.groupBoxIP.TabStop = false;
            // 
            // txtBoxGateway
            // 
            this.txtBoxGateway.AccessibleDescription = null;
            this.txtBoxGateway.AccessibleName = null;
            resources.ApplyResources(this.txtBoxGateway, "txtBoxGateway");
            this.txtBoxGateway.BackgroundImage = null;
            this.txtBoxGateway.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProfile, "Gateway", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProviderProfile.SetError(this.txtBoxGateway, resources.GetString("txtBoxGateway.Error"));
            this.errorProviderProfile.SetIconAlignment(this.txtBoxGateway, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxGateway.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.txtBoxGateway, ((int)(resources.GetObject("txtBoxGateway.IconPadding"))));
            this.txtBoxGateway.Name = "txtBoxGateway";
            // 
            // txtBoxMask
            // 
            this.txtBoxMask.AccessibleDescription = null;
            this.txtBoxMask.AccessibleName = null;
            resources.ApplyResources(this.txtBoxMask, "txtBoxMask");
            this.txtBoxMask.BackgroundImage = null;
            this.txtBoxMask.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProfile, "Submask", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProviderProfile.SetError(this.txtBoxMask, resources.GetString("txtBoxMask.Error"));
            this.errorProviderProfile.SetIconAlignment(this.txtBoxMask, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxMask.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.txtBoxMask, ((int)(resources.GetObject("txtBoxMask.IconPadding"))));
            this.txtBoxMask.Name = "txtBoxMask";
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.AccessibleDescription = null;
            this.txtBoxIP.AccessibleName = null;
            resources.ApplyResources(this.txtBoxIP, "txtBoxIP");
            this.txtBoxIP.BackgroundImage = null;
            this.txtBoxIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProfile, "IPAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProviderProfile.SetError(this.txtBoxIP, resources.GetString("txtBoxIP.Error"));
            this.errorProviderProfile.SetIconAlignment(this.txtBoxIP, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxIP.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.txtBoxIP, ((int)(resources.GetObject("txtBoxIP.IconPadding"))));
            this.txtBoxIP.Name = "txtBoxIP";
            // 
            // radBtnIP
            // 
            this.radBtnIP.AccessibleDescription = null;
            this.radBtnIP.AccessibleName = null;
            resources.ApplyResources(this.radBtnIP, "radBtnIP");
            this.radBtnIP.BackgroundImage = null;
            this.radBtnIP.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsProfile, "AutomaticIPAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProviderProfile.SetError(this.radBtnIP, resources.GetString("radBtnIP.Error"));
            this.radBtnIP.Font = null;
            this.errorProviderProfile.SetIconAlignment(this.radBtnIP, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radBtnIP.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.radBtnIP, ((int)(resources.GetObject("radBtnIP.IconPadding"))));
            this.radBtnIP.Name = "radBtnIP";
            this.radBtnIP.UseVisualStyleBackColor = true;
            this.radBtnIP.Click += new System.EventHandler(this.radBtnIP_Click);
            // 
            // radBtnDNS
            // 
            this.radBtnDNS.AccessibleDescription = null;
            this.radBtnDNS.AccessibleName = null;
            resources.ApplyResources(this.radBtnDNS, "radBtnDNS");
            this.radBtnDNS.BackgroundImage = null;
            this.radBtnDNS.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsProfile, "AutomaticDNSAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProviderProfile.SetError(this.radBtnDNS, resources.GetString("radBtnDNS.Error"));
            this.radBtnDNS.Font = null;
            this.errorProviderProfile.SetIconAlignment(this.radBtnDNS, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radBtnDNS.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.radBtnDNS, ((int)(resources.GetObject("radBtnDNS.IconPadding"))));
            this.radBtnDNS.Name = "radBtnDNS";
            this.radBtnDNS.UseVisualStyleBackColor = true;
            this.radBtnDNS.Click += new System.EventHandler(this.radBtnDNS_Click);
            // 
            // errorProviderProfile
            // 
            this.errorProviderProfile.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderProfile.ContainerControl = this;
            this.errorProviderProfile.DataSource = this.bsProfile;
            resources.ApplyResources(this.errorProviderProfile, "errorProviderProfile");
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.panel1.Controls.Add(this.radBtnIP);
            this.panel1.Controls.Add(this.radBtnManualIP);
            this.errorProviderProfile.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.panel1.Font = null;
            this.errorProviderProfile.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            // 
            // radBtnManualIP
            // 
            this.radBtnManualIP.AccessibleDescription = null;
            this.radBtnManualIP.AccessibleName = null;
            resources.ApplyResources(this.radBtnManualIP, "radBtnManualIP");
            this.radBtnManualIP.BackgroundImage = null;
            this.radBtnManualIP.Checked = true;
            this.errorProviderProfile.SetError(this.radBtnManualIP, resources.GetString("radBtnManualIP.Error"));
            this.radBtnManualIP.Font = null;
            this.errorProviderProfile.SetIconAlignment(this.radBtnManualIP, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radBtnManualIP.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.radBtnManualIP, ((int)(resources.GetObject("radBtnManualIP.IconPadding"))));
            this.radBtnManualIP.Name = "radBtnManualIP";
            this.radBtnManualIP.TabStop = true;
            this.radBtnManualIP.UseVisualStyleBackColor = true;
            this.radBtnManualIP.Click += new System.EventHandler(this.radBtnManualIP_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = null;
            this.panel2.AccessibleName = null;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackgroundImage = null;
            this.panel2.Controls.Add(this.radBtnManualDNS);
            this.panel2.Controls.Add(this.radBtnDNS);
            this.errorProviderProfile.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.panel2.Font = null;
            this.errorProviderProfile.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.panel2.Name = "panel2";
            // 
            // radBtnManualDNS
            // 
            this.radBtnManualDNS.AccessibleDescription = null;
            this.radBtnManualDNS.AccessibleName = null;
            resources.ApplyResources(this.radBtnManualDNS, "radBtnManualDNS");
            this.radBtnManualDNS.BackgroundImage = null;
            this.radBtnManualDNS.Checked = true;
            this.errorProviderProfile.SetError(this.radBtnManualDNS, resources.GetString("radBtnManualDNS.Error"));
            this.radBtnManualDNS.Font = null;
            this.errorProviderProfile.SetIconAlignment(this.radBtnManualDNS, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radBtnManualDNS.IconAlignment"))));
            this.errorProviderProfile.SetIconPadding(this.radBtnManualDNS, ((int)(resources.GetObject("radBtnManualDNS.IconPadding"))));
            this.radBtnManualDNS.Name = "radBtnManualDNS";
            this.radBtnManualDNS.TabStop = true;
            this.radBtnManualDNS.UseVisualStyleBackColor = true;
            this.radBtnManualDNS.Click += new System.EventHandler(this.radBtnManualDNS_Click);
            // 
            // NewProfile
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxIP);
            this.Controls.Add(this.groupBoxDNS);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxName);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.MaximizeBox = false;
            this.Name = "NewProfile";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.NewProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProfile)).EndInit();
            this.groupBoxDNS.ResumeLayout(false);
            this.groupBoxDNS.PerformLayout();
            this.groupBoxIP.ResumeLayout(false);
            this.groupBoxIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.GroupBox groupBoxDNS;
        private System.Windows.Forms.GroupBox groupBoxIP;
        private System.Windows.Forms.RadioButton radBtnIP;
        private System.Windows.Forms.RadioButton radBtnDNS;
        private System.Windows.Forms.ErrorProvider errorProviderProfile;
        private System.Windows.Forms.TextBox txtBoxADNS;
        private System.Windows.Forms.TextBox txtBoxPDNS;
        private System.Windows.Forms.TextBox txtBoxGateway;
        private System.Windows.Forms.TextBox txtBoxMask;
        private System.Windows.Forms.TextBox txtBoxIP;
        private System.Windows.Forms.BindingSource bsProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radBtnManualIP;
        private System.Windows.Forms.RadioButton radBtnManualDNS;
    }
}