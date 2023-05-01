namespace LibrarySystem
{
    partial class LibraryOptions
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
            this.optionsLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.lendButton = new System.Windows.Forms.Button();
            this.memberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.optionsLabel.Location = new System.Drawing.Point(211, 27);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(157, 25);
            this.optionsLabel.TabIndex = 0;
            this.optionsLabel.Text = "Select an Option";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 115);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = " Add Book";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(102, 115);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search Book";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(204, 115);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(75, 23);
            this.reserveButton.TabIndex = 3;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(297, 115);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // lendButton
            // 
            this.lendButton.Location = new System.Drawing.Point(393, 115);
            this.lendButton.Name = "lendButton";
            this.lendButton.Size = new System.Drawing.Size(75, 23);
            this.lendButton.TabIndex = 5;
            this.lendButton.Text = "Lend Book";
            this.lendButton.UseVisualStyleBackColor = true;
            // 
            // memberButton
            // 
            this.memberButton.Location = new System.Drawing.Point(495, 115);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(75, 23);
            this.memberButton.TabIndex = 6;
            this.memberButton.Text = "Add Member";
            this.memberButton.UseVisualStyleBackColor = true;
            // 
            // LibraryOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.memberButton);
            this.Controls.Add(this.lendButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.optionsLabel);
            this.Name = "LibraryOptions";
            this.Text = "Library Options";
            this.Load += new System.EventHandler(this.LibaryOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button lendButton;
        private System.Windows.Forms.Button memberButton;
    }
}