namespace AES
{
    partial class Config
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
            this.label_plaintextStringTitle = new System.Windows.Forms.Label();
            this.label_plaintextBytesTitle = new System.Windows.Forms.Label();
            this.label_keyExpansionTitle = new System.Windows.Forms.Label();
            this.label_keyBytesTitle = new System.Windows.Forms.Label();
            this.label_plaintextStringText = new System.Windows.Forms.Label();
            this.label_plaintextBytesText = new System.Windows.Forms.Label();
            this.label_keyBytesText = new System.Windows.Forms.Label();
            this.label_keyExpansionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_plaintextStringTitle
            // 
            this.label_plaintextStringTitle.AutoSize = true;
            this.label_plaintextStringTitle.Location = new System.Drawing.Point(380, 18);
            this.label_plaintextStringTitle.Name = "label_plaintextStringTitle";
            this.label_plaintextStringTitle.Size = new System.Drawing.Size(89, 13);
            this.label_plaintextStringTitle.TabIndex = 0;
            this.label_plaintextStringTitle.Text = "Plaintext in string:";
            // 
            // label_plaintextBytesTitle
            // 
            this.label_plaintextBytesTitle.AutoSize = true;
            this.label_plaintextBytesTitle.Location = new System.Drawing.Point(380, 43);
            this.label_plaintextBytesTitle.Name = "label_plaintextBytesTitle";
            this.label_plaintextBytesTitle.Size = new System.Drawing.Size(89, 13);
            this.label_plaintextBytesTitle.TabIndex = 1;
            this.label_plaintextBytesTitle.Text = "Plaintext in bytes:";
            // 
            // label_keyExpansionTitle
            // 
            this.label_keyExpansionTitle.AutoSize = true;
            this.label_keyExpansionTitle.Location = new System.Drawing.Point(12, 18);
            this.label_keyExpansionTitle.Name = "label_keyExpansionTitle";
            this.label_keyExpansionTitle.Size = new System.Drawing.Size(79, 13);
            this.label_keyExpansionTitle.TabIndex = 2;
            this.label_keyExpansionTitle.Text = "Key expansion:";
            // 
            // label_keyBytesTitle
            // 
            this.label_keyBytesTitle.AutoSize = true;
            this.label_keyBytesTitle.Location = new System.Drawing.Point(380, 69);
            this.label_keyBytesTitle.Name = "label_keyBytesTitle";
            this.label_keyBytesTitle.Size = new System.Drawing.Size(67, 13);
            this.label_keyBytesTitle.TabIndex = 3;
            this.label_keyBytesTitle.Text = "Key in bytes:";
            // 
            // label_plaintextStringText
            // 
            this.label_plaintextStringText.AutoSize = true;
            this.label_plaintextStringText.Location = new System.Drawing.Point(484, 18);
            this.label_plaintextStringText.Name = "label_plaintextStringText";
            this.label_plaintextStringText.Size = new System.Drawing.Size(35, 13);
            this.label_plaintextStringText.TabIndex = 4;
            this.label_plaintextStringText.Text = "label1";
            // 
            // label_plaintextBytesText
            // 
            this.label_plaintextBytesText.AutoSize = true;
            this.label_plaintextBytesText.Location = new System.Drawing.Point(484, 43);
            this.label_plaintextBytesText.Name = "label_plaintextBytesText";
            this.label_plaintextBytesText.Size = new System.Drawing.Size(35, 13);
            this.label_plaintextBytesText.TabIndex = 5;
            this.label_plaintextBytesText.Text = "label2";
            // 
            // label_keyBytesText
            // 
            this.label_keyBytesText.AutoSize = true;
            this.label_keyBytesText.Location = new System.Drawing.Point(484, 69);
            this.label_keyBytesText.Name = "label_keyBytesText";
            this.label_keyBytesText.Size = new System.Drawing.Size(35, 13);
            this.label_keyBytesText.TabIndex = 6;
            this.label_keyBytesText.Text = "label3";
            // 
            // label_keyExpansionText
            // 
            this.label_keyExpansionText.AutoSize = true;
            this.label_keyExpansionText.Location = new System.Drawing.Point(97, 18);
            this.label_keyExpansionText.Name = "label_keyExpansionText";
            this.label_keyExpansionText.Size = new System.Drawing.Size(35, 13);
            this.label_keyExpansionText.TabIndex = 7;
            this.label_keyExpansionText.Text = "label4";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_keyExpansionText);
            this.Controls.Add(this.label_keyBytesText);
            this.Controls.Add(this.label_plaintextBytesText);
            this.Controls.Add(this.label_plaintextStringText);
            this.Controls.Add(this.label_keyBytesTitle);
            this.Controls.Add(this.label_keyExpansionTitle);
            this.Controls.Add(this.label_plaintextBytesTitle);
            this.Controls.Add(this.label_plaintextStringTitle);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_plaintextStringTitle;
        private System.Windows.Forms.Label label_plaintextBytesTitle;
        private System.Windows.Forms.Label label_keyExpansionTitle;
        private System.Windows.Forms.Label label_keyBytesTitle;
        private System.Windows.Forms.Label label_plaintextStringText;
        private System.Windows.Forms.Label label_plaintextBytesText;
        private System.Windows.Forms.Label label_keyBytesText;
        private System.Windows.Forms.Label label_keyExpansionText;
    }
}