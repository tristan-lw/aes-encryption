namespace AES
{
    partial class Round0
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
            this.button_addRoundKey = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label_stateMatrixText = new System.Windows.Forms.Label();
            this.label_stateMatrixValue = new System.Windows.Forms.Label();
            this.label_additionSymbol = new System.Windows.Forms.Label();
            this.label_roundKeyText = new System.Windows.Forms.Label();
            this.label_roundKeyValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addRoundKey
            // 
            this.button_addRoundKey.Location = new System.Drawing.Point(81, 42);
            this.button_addRoundKey.Name = "button_addRoundKey";
            this.button_addRoundKey.Size = new System.Drawing.Size(136, 23);
            this.button_addRoundKey.TabIndex = 2;
            this.button_addRoundKey.Text = "Add round key";
            this.button_addRoundKey.UseVisualStyleBackColor = true;
            this.button_addRoundKey.Click += new System.EventHandler(this.button_addRoundKey_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(81, 335);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(467, 335);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 4;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Visible = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_stateMatrixText
            // 
            this.label_stateMatrixText.AutoSize = true;
            this.label_stateMatrixText.Location = new System.Drawing.Point(131, 131);
            this.label_stateMatrixText.Name = "label_stateMatrixText";
            this.label_stateMatrixText.Size = new System.Drawing.Size(81, 13);
            this.label_stateMatrixText.TabIndex = 5;
            this.label_stateMatrixText.Text = "StateMatrixText";
            this.label_stateMatrixText.Visible = false;
            // 
            // label_stateMatrixValue
            // 
            this.label_stateMatrixValue.AutoSize = true;
            this.label_stateMatrixValue.Location = new System.Drawing.Point(131, 208);
            this.label_stateMatrixValue.Name = "label_stateMatrixValue";
            this.label_stateMatrixValue.Size = new System.Drawing.Size(87, 13);
            this.label_stateMatrixValue.TabIndex = 6;
            this.label_stateMatrixValue.Text = "StateMatrixValue";
            this.label_stateMatrixValue.Visible = false;
            // 
            // label_additionSymbol
            // 
            this.label_additionSymbol.AutoSize = true;
            this.label_additionSymbol.Location = new System.Drawing.Point(277, 175);
            this.label_additionSymbol.Name = "label_additionSymbol";
            this.label_additionSymbol.Size = new System.Drawing.Size(13, 13);
            this.label_additionSymbol.TabIndex = 7;
            this.label_additionSymbol.Text = "+";
            this.label_additionSymbol.Visible = false;
            // 
            // label_roundKeyText
            // 
            this.label_roundKeyText.AutoSize = true;
            this.label_roundKeyText.Location = new System.Drawing.Point(328, 131);
            this.label_roundKeyText.Name = "label_roundKeyText";
            this.label_roundKeyText.Size = new System.Drawing.Size(78, 13);
            this.label_roundKeyText.TabIndex = 8;
            this.label_roundKeyText.Text = "RoundKeyText";
            this.label_roundKeyText.Visible = false;
            // 
            // label_roundKeyValue
            // 
            this.label_roundKeyValue.AutoSize = true;
            this.label_roundKeyValue.Location = new System.Drawing.Point(328, 208);
            this.label_roundKeyValue.Name = "label_roundKeyValue";
            this.label_roundKeyValue.Size = new System.Drawing.Size(84, 13);
            this.label_roundKeyValue.TabIndex = 9;
            this.label_roundKeyValue.Text = "RoundKeyValue";
            this.label_roundKeyValue.Visible = false;
            // 
            // Round0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_roundKeyValue);
            this.Controls.Add(this.label_roundKeyText);
            this.Controls.Add(this.label_additionSymbol);
            this.Controls.Add(this.label_stateMatrixValue);
            this.Controls.Add(this.label_stateMatrixText);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_addRoundKey);
            this.Name = "Round0";
            this.Text = "Round0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addRoundKey;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_stateMatrixText;
        internal System.Windows.Forms.Label label_stateMatrixValue;
        private System.Windows.Forms.Label label_additionSymbol;
        private System.Windows.Forms.Label label_roundKeyText;
        private System.Windows.Forms.Label label_roundKeyValue;
    }
}