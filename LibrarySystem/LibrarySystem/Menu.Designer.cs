﻿namespace LibrarySystem
{
    partial class Menu
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
            this.applicationName = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.libraryButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.supplierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applicationName
            // 
            this.applicationName.AutoSize = true;
            this.applicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.applicationName.Location = new System.Drawing.Point(64, 32);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(552, 31);
            this.applicationName.TabIndex = 0;
            this.applicationName.Text = "Management Information System Application";
            this.applicationName.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.selectLabel.Location = new System.Drawing.Point(283, 112);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(129, 25);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "Select a User";
            // 
            // libraryButton
            // 
            this.libraryButton.Location = new System.Drawing.Point(135, 208);
            this.libraryButton.Name = "libraryButton";
            this.libraryButton.Size = new System.Drawing.Size(75, 23);
            this.libraryButton.TabIndex = 2;
            this.libraryButton.Text = "Library Staff";
            this.libraryButton.UseVisualStyleBackColor = true;
            this.libraryButton.Click += new System.EventHandler(this.libraryButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(301, 208);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 23);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // supplierButton
            // 
            this.supplierButton.Location = new System.Drawing.Point(447, 208);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(75, 23);
            this.supplierButton.TabIndex = 4;
            this.supplierButton.Text = "Supplier";
            this.supplierButton.UseVisualStyleBackColor = true;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.supplierButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.libraryButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.applicationName);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label applicationName;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button libraryButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button supplierButton;
    }
}

