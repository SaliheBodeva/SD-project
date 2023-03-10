namespace ArchitectureCompany.FormApplication
{
    partial class OldClientFormApp
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
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.groupBoxProject = new System.Windows.Forms.GroupBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.buttonAddmage = new System.Windows.Forms.Button();
            this.comboBoxProjectTown = new System.Windows.Forms.ComboBox();
            this.labelProjectTown = new System.Windows.Forms.Label();
            this.tbReleasedDate = new System.Windows.Forms.TextBox();
            this.lableReleasedDate = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tbProjectAdress = new System.Windows.Forms.TextBox();
            this.tbFllor = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.cbBulidingType = new System.Windows.Forms.ComboBox();
            this.tbCapasity = new System.Windows.Forms.TextBox();
            this.labelProjectAddress = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelCapasity = new System.Windows.Forms.Label();
            this.labelBulidingType = new System.Windows.Forms.Label();
            this.labelProjctName = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPages = new System.Windows.Forms.Label();
            this.groupBoxClients = new System.Windows.Forms.GroupBox();
            this.groupBoxProject.SuspendLayout();
            this.groupBoxClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 15;
            this.listBoxClients.Location = new System.Drawing.Point(4, 21);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(271, 304);
            this.listBoxClients.TabIndex = 0;
            this.listBoxClients.DoubleClick += new System.EventHandler(this.listBoxClients_DoubleClick);
            // 
            // groupBoxProject
            // 
            this.groupBoxProject.Controls.Add(this.labelClientId);
            this.groupBoxProject.Controls.Add(this.tbClientId);
            this.groupBoxProject.Controls.Add(this.buttonAddmage);
            this.groupBoxProject.Controls.Add(this.comboBoxProjectTown);
            this.groupBoxProject.Controls.Add(this.labelProjectTown);
            this.groupBoxProject.Controls.Add(this.tbReleasedDate);
            this.groupBoxProject.Controls.Add(this.lableReleasedDate);
            this.groupBoxProject.Controls.Add(this.tbProjectName);
            this.groupBoxProject.Controls.Add(this.buttonSubmit);
            this.groupBoxProject.Controls.Add(this.tbProjectAdress);
            this.groupBoxProject.Controls.Add(this.tbFllor);
            this.groupBoxProject.Controls.Add(this.tbArea);
            this.groupBoxProject.Controls.Add(this.cbBulidingType);
            this.groupBoxProject.Controls.Add(this.tbCapasity);
            this.groupBoxProject.Controls.Add(this.labelProjectAddress);
            this.groupBoxProject.Controls.Add(this.labelFloor);
            this.groupBoxProject.Controls.Add(this.labelArea);
            this.groupBoxProject.Controls.Add(this.labelCapasity);
            this.groupBoxProject.Controls.Add(this.labelBulidingType);
            this.groupBoxProject.Controls.Add(this.labelProjctName);
            this.groupBoxProject.Location = new System.Drawing.Point(338, 54);
            this.groupBoxProject.Name = "groupBoxProject";
            this.groupBoxProject.Size = new System.Drawing.Size(326, 395);
            this.groupBoxProject.TabIndex = 34;
            this.groupBoxProject.TabStop = false;
            this.groupBoxProject.Text = "Project idea";
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(41, 35);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(51, 15);
            this.labelClientId.TabIndex = 39;
            this.labelClientId.Text = "Client Id";
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(173, 27);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(131, 23);
            this.tbClientId.TabIndex = 38;
            // 
            // buttonAddmage
            // 
            this.buttonAddmage.Location = new System.Drawing.Point(185, 344);
            this.buttonAddmage.Name = "buttonAddmage";
            this.buttonAddmage.Size = new System.Drawing.Size(119, 41);
            this.buttonAddmage.TabIndex = 36;
            this.buttonAddmage.Text = "Add image";
            this.buttonAddmage.UseVisualStyleBackColor = true;
            this.buttonAddmage.Click += new System.EventHandler(this.buttonAddmage_Click);
            // 
            // comboBoxProjectTown
            // 
            this.comboBoxProjectTown.FormattingEnabled = true;
            this.comboBoxProjectTown.Location = new System.Drawing.Point(173, 315);
            this.comboBoxProjectTown.Name = "comboBoxProjectTown";
            this.comboBoxProjectTown.Size = new System.Drawing.Size(131, 23);
            this.comboBoxProjectTown.TabIndex = 35;
            // 
            // labelProjectTown
            // 
            this.labelProjectTown.AutoSize = true;
            this.labelProjectTown.Location = new System.Drawing.Point(42, 316);
            this.labelProjectTown.Name = "labelProjectTown";
            this.labelProjectTown.Size = new System.Drawing.Size(35, 15);
            this.labelProjectTown.TabIndex = 34;
            this.labelProjectTown.Text = "Town";
            // 
            // tbReleasedDate
            // 
            this.tbReleasedDate.Location = new System.Drawing.Point(174, 168);
            this.tbReleasedDate.Name = "tbReleasedDate";
            this.tbReleasedDate.Size = new System.Drawing.Size(130, 23);
            this.tbReleasedDate.TabIndex = 33;
            // 
            // lableReleasedDate
            // 
            this.lableReleasedDate.AutoSize = true;
            this.lableReleasedDate.Location = new System.Drawing.Point(41, 176);
            this.lableReleasedDate.Name = "lableReleasedDate";
            this.lableReleasedDate.Size = new System.Drawing.Size(127, 15);
            this.lableReleasedDate.TabIndex = 32;
            this.lableReleasedDate.Text = "Expected released date";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(173, 58);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(131, 23);
            this.tbProjectName.TabIndex = 31;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(29, 348);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(141, 37);
            this.buttonSubmit.TabIndex = 30;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // tbProjectAdress
            // 
            this.tbProjectAdress.Location = new System.Drawing.Point(174, 278);
            this.tbProjectAdress.Name = "tbProjectAdress";
            this.tbProjectAdress.Size = new System.Drawing.Size(130, 23);
            this.tbProjectAdress.TabIndex = 28;
            // 
            // tbFllor
            // 
            this.tbFllor.Location = new System.Drawing.Point(174, 238);
            this.tbFllor.Name = "tbFllor";
            this.tbFllor.Size = new System.Drawing.Size(130, 23);
            this.tbFllor.TabIndex = 27;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(174, 202);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(130, 23);
            this.tbArea.TabIndex = 26;
            // 
            // cbBulidingType
            // 
            this.cbBulidingType.FormattingEnabled = true;
            this.cbBulidingType.Location = new System.Drawing.Point(174, 91);
            this.cbBulidingType.Name = "cbBulidingType";
            this.cbBulidingType.Size = new System.Drawing.Size(130, 23);
            this.cbBulidingType.TabIndex = 25;
            // 
            // tbCapasity
            // 
            this.tbCapasity.Location = new System.Drawing.Point(174, 132);
            this.tbCapasity.Name = "tbCapasity";
            this.tbCapasity.Size = new System.Drawing.Size(130, 23);
            this.tbCapasity.TabIndex = 24;
            // 
            // labelProjectAddress
            // 
            this.labelProjectAddress.AutoSize = true;
            this.labelProjectAddress.Location = new System.Drawing.Point(41, 284);
            this.labelProjectAddress.Name = "labelProjectAddress";
            this.labelProjectAddress.Size = new System.Drawing.Size(49, 15);
            this.labelProjectAddress.TabIndex = 20;
            this.labelProjectAddress.Text = "Address";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(41, 247);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(39, 15);
            this.labelFloor.TabIndex = 19;
            this.labelFloor.Text = "Floors";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(41, 210);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(31, 15);
            this.labelArea.TabIndex = 18;
            this.labelArea.Text = "Area";
            // 
            // labelCapasity
            // 
            this.labelCapasity.AutoSize = true;
            this.labelCapasity.Location = new System.Drawing.Point(41, 143);
            this.labelCapasity.Name = "labelCapasity";
            this.labelCapasity.Size = new System.Drawing.Size(53, 15);
            this.labelCapasity.TabIndex = 17;
            this.labelCapasity.Text = "Capacity";
            // 
            // labelBulidingType
            // 
            this.labelBulidingType.AutoSize = true;
            this.labelBulidingType.Location = new System.Drawing.Point(41, 102);
            this.labelBulidingType.Name = "labelBulidingType";
            this.labelBulidingType.Size = new System.Drawing.Size(78, 15);
            this.labelBulidingType.TabIndex = 16;
            this.labelBulidingType.Text = "Buliding Type";
            // 
            // labelProjctName
            // 
            this.labelProjctName.AutoSize = true;
            this.labelProjctName.Location = new System.Drawing.Point(41, 64);
            this.labelProjctName.Name = "labelProjctName";
            this.labelProjctName.Size = new System.Drawing.Size(77, 15);
            this.labelProjctName.TabIndex = 15;
            this.labelProjctName.Text = "Project name";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(45, 348);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 40);
            this.buttonPrevious.TabIndex = 35;
            this.buttonPrevious.Text = "Previous page";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = "Next page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(124, 328);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(38, 15);
            this.labelPages.TabIndex = 37;
            this.labelPages.Text = "label1";
            // 
            // groupBoxClients
            // 
            this.groupBoxClients.Controls.Add(this.labelPages);
            this.groupBoxClients.Controls.Add(this.button1);
            this.groupBoxClients.Controls.Add(this.buttonPrevious);
            this.groupBoxClients.Controls.Add(this.listBoxClients);
            this.groupBoxClients.Location = new System.Drawing.Point(12, 54);
            this.groupBoxClients.Name = "groupBoxClients";
            this.groupBoxClients.Size = new System.Drawing.Size(294, 395);
            this.groupBoxClients.TabIndex = 39;
            this.groupBoxClients.TabStop = false;
            this.groupBoxClients.Text = "Clients";
            // 
            // OldClientFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 471);
            this.Controls.Add(this.groupBoxClients);
            this.Controls.Add(this.groupBoxProject);
            this.Name = "OldClientFormApp";
            this.Text = "OldClientFormApp";
            this.Load += new System.EventHandler(this.OldClientFormApp_Load);
            this.groupBoxProject.ResumeLayout(false);
            this.groupBoxProject.PerformLayout();
            this.groupBoxClients.ResumeLayout(false);
            this.groupBoxClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.GroupBox groupBoxProject;
        private System.Windows.Forms.Button buttonAddmage;
        private System.Windows.Forms.ComboBox comboBoxProjectTown;
        private System.Windows.Forms.Label labelProjectTown;
        private System.Windows.Forms.TextBox tbReleasedDate;
        private System.Windows.Forms.Label lableReleasedDate;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox tbProjectAdress;
        private System.Windows.Forms.TextBox tbFllor;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.ComboBox cbBulidingType;
        private System.Windows.Forms.TextBox tbCapasity;
        private System.Windows.Forms.Label labelProjectAddress;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelCapasity;
        private System.Windows.Forms.Label labelBulidingType;
        private System.Windows.Forms.Label labelProjctName;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.GroupBox groupBoxClients;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.TextBox tbClientId;
    }
}