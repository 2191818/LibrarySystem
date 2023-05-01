namespace LibrarySystem
{
    partial class UserOptions
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
            this.optionLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.optionLabel.Location = new System.Drawing.Point(204, 25);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(157, 25);
            this.optionLabel.TabIndex = 0;
            this.optionLabel.Text = "Select an Option";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(66, 88);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search Book";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(166, 88);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(108, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply Membership";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(296, 88);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(96, 23);
            this.borrowButton.TabIndex = 3;
            this.borrowButton.Text = "Borrow Book";
            this.borrowButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(409, 88);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Return Book";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // UserOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.optionLabel);
            this.Name = "UserOptions";
            this.Text = "User Options";
            this.Load += new System.EventHandler(this.UserOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button returnButton;
    }
}