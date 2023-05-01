namespace LibrarySystem
{
    partial class SupplierOptions
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
            this.searchButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.optionsLabel.Location = new System.Drawing.Point(206, 29);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(157, 25);
            this.optionsLabel.TabIndex = 0;
            this.optionsLabel.Text = "Select an Option";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(178, 89);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search Book";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(301, 89);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(83, 23);
            this.sellButton.TabIndex = 2;
            this.sellButton.Text = "Sell Book";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // SupplierOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.optionsLabel);
            this.Name = "SupplierOptions";
            this.Text = "Supplier Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button sellButton;
    }
}