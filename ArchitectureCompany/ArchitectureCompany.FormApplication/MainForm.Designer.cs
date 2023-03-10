namespace ArchitectureCompany.FormApplication
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnEmployee = new System.Windows.Forms.Button();
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelArtLife = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOldClient = new System.Windows.Forms.Button();
            this.btnAddImageToProject = new System.Windows.Forms.Button();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(23, 275);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(134, 41);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Our Employees";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelabel.CausesValidation = false;
            this.Welcomelabel.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Welcomelabel.Location = new System.Drawing.Point(193, 9);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(221, 62);
            this.Welcomelabel.TabIndex = 1;
            this.Welcomelabel.Text = "Welcome";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Transparent;
            this.labelTo.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(271, 71);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(72, 62);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "to";
            // 
            // labelArtLife
            // 
            this.labelArtLife.AutoSize = true;
            this.labelArtLife.BackColor = System.Drawing.Color.Transparent;
            this.labelArtLife.Font = new System.Drawing.Font("Pristina", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelArtLife.Location = new System.Drawing.Point(161, 124);
            this.labelArtLife.Name = "labelArtLife";
            this.labelArtLife.Size = new System.Drawing.Size(295, 126);
            this.labelArtLife.TabIndex = 3;
            this.labelArtLife.Text = "ArtLife";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(177, 275);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(134, 41);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "Add client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose your team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOldClient
            // 
            this.btnOldClient.Location = new System.Drawing.Point(462, 275);
            this.btnOldClient.Name = "btnOldClient";
            this.btnOldClient.Size = new System.Drawing.Size(134, 41);
            this.btnOldClient.TabIndex = 6;
            this.btnOldClient.Text = "Already a client";
            this.btnOldClient.UseVisualStyleBackColor = true;
            this.btnOldClient.Click += new System.EventHandler(this.btnOldClient_Click);
            // 
            // btnAddImageToProject
            // 
            this.btnAddImageToProject.Location = new System.Drawing.Point(23, 139);
            this.btnAddImageToProject.Name = "btnAddImageToProject";
            this.btnAddImageToProject.Size = new System.Drawing.Size(93, 44);
            this.btnAddImageToProject.TabIndex = 7;
            this.btnAddImageToProject.Text = "Add image to project";
            this.btnAddImageToProject.UseVisualStyleBackColor = true;
            this.btnAddImageToProject.Click += new System.EventHandler(this.btnAddImageToProject_Click);
            // 
            // btnCatalog
            // 
            this.btnCatalog.Location = new System.Drawing.Point(479, 147);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(75, 23);
            this.btnCatalog.TabIndex = 8;
            this.btnCatalog.Text = "Catalog";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(610, 336);
            this.Controls.Add(this.btnCatalog);
            this.Controls.Add(this.btnAddImageToProject);
            this.Controls.Add(this.btnOldClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.labelArtLife);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.Welcomelabel);
            this.Controls.Add(this.btnEmployee);
            this.Name = "MainForm";
            this.Text = "MainFormApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelArtLife;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOldClient;
        private System.Windows.Forms.Button btnAddImageToProject;
        private System.Windows.Forms.Button btnCatalog;
    }
}
