namespace AES
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
            this.label_plaintext = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.label_ciphertextLabel = new System.Windows.Forms.Label();
            this.textBox_plaintext = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.label_ciphertextAnswer = new System.Windows.Forms.Label();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_keyInString = new System.Windows.Forms.Button();
            this.button_keyInBytes = new System.Windows.Forms.Button();
            this.label_selectKeyFormat = new System.Windows.Forms.Label();
            this.button_round1 = new System.Windows.Forms.Button();
            this.button_round2 = new System.Windows.Forms.Button();
            this.button_round3 = new System.Windows.Forms.Button();
            this.button_round4 = new System.Windows.Forms.Button();
            this.button_round5 = new System.Windows.Forms.Button();
            this.button_round6 = new System.Windows.Forms.Button();
            this.button_round7 = new System.Windows.Forms.Button();
            this.button_round8 = new System.Windows.Forms.Button();
            this.button_round9 = new System.Windows.Forms.Button();
            this.button_round0 = new System.Windows.Forms.Button();
            this.button_config = new System.Windows.Forms.Button();
            this.label_timeTaken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_plaintext
            // 
            this.label_plaintext.AutoSize = true;
            this.label_plaintext.Location = new System.Drawing.Point(73, 133);
            this.label_plaintext.Name = "label_plaintext";
            this.label_plaintext.Size = new System.Drawing.Size(50, 13);
            this.label_plaintext.TabIndex = 0;
            this.label_plaintext.Text = "Plaintext:";
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(73, 184);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(28, 13);
            this.label_key.TabIndex = 1;
            this.label_key.Text = "Key:";
            // 
            // label_ciphertextLabel
            // 
            this.label_ciphertextLabel.AutoSize = true;
            this.label_ciphertextLabel.Location = new System.Drawing.Point(73, 332);
            this.label_ciphertextLabel.Name = "label_ciphertextLabel";
            this.label_ciphertextLabel.Size = new System.Drawing.Size(57, 13);
            this.label_ciphertextLabel.TabIndex = 2;
            this.label_ciphertextLabel.Text = "Ciphertext:";
            // 
            // textBox_plaintext
            // 
            this.textBox_plaintext.Location = new System.Drawing.Point(129, 130);
            this.textBox_plaintext.Name = "textBox_plaintext";
            this.textBox_plaintext.Size = new System.Drawing.Size(100, 20);
            this.textBox_plaintext.TabIndex = 3;
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(129, 184);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(100, 20);
            this.textBox_key.TabIndex = 4;
            // 
            // label_ciphertextAnswer
            // 
            this.label_ciphertextAnswer.AutoSize = true;
            this.label_ciphertextAnswer.Location = new System.Drawing.Point(148, 332);
            this.label_ciphertextAnswer.Name = "label_ciphertextAnswer";
            this.label_ciphertextAnswer.Size = new System.Drawing.Size(0, 13);
            this.label_ciphertextAnswer.TabIndex = 5;
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(129, 233);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(75, 23);
            this.button_encrypt.TabIndex = 6;
            this.button_encrypt.Text = "Encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_keyInString
            // 
            this.button_keyInString.BackColor = System.Drawing.Color.Green;
            this.button_keyInString.Location = new System.Drawing.Point(319, 133);
            this.button_keyInString.Name = "button_keyInString";
            this.button_keyInString.Size = new System.Drawing.Size(75, 23);
            this.button_keyInString.TabIndex = 9;
            this.button_keyInString.Text = "String";
            this.button_keyInString.UseVisualStyleBackColor = false;
            this.button_keyInString.Click += new System.EventHandler(this.button_keyInString_Click);
            // 
            // button_keyInBytes
            // 
            this.button_keyInBytes.BackColor = System.Drawing.Color.Red;
            this.button_keyInBytes.Location = new System.Drawing.Point(319, 162);
            this.button_keyInBytes.Name = "button_keyInBytes";
            this.button_keyInBytes.Size = new System.Drawing.Size(75, 23);
            this.button_keyInBytes.TabIndex = 10;
            this.button_keyInBytes.Text = "Bytes";
            this.button_keyInBytes.UseVisualStyleBackColor = false;
            this.button_keyInBytes.Click += new System.EventHandler(this.button_keyInBytes_Click);
            // 
            // label_selectKeyFormat
            // 
            this.label_selectKeyFormat.AutoSize = true;
            this.label_selectKeyFormat.Location = new System.Drawing.Point(316, 113);
            this.label_selectKeyFormat.Name = "label_selectKeyFormat";
            this.label_selectKeyFormat.Size = new System.Drawing.Size(93, 13);
            this.label_selectKeyFormat.TabIndex = 11;
            this.label_selectKeyFormat.Text = "Select Key Format";
            // 
            // button_round1
            // 
            this.button_round1.Location = new System.Drawing.Point(856, 184);
            this.button_round1.Name = "button_round1";
            this.button_round1.Size = new System.Drawing.Size(75, 23);
            this.button_round1.TabIndex = 12;
            this.button_round1.Text = "Round 1";
            this.button_round1.UseVisualStyleBackColor = true;
            this.button_round1.Click += new System.EventHandler(this.button_round1_Click);
            // 
            // button_round2
            // 
            this.button_round2.Location = new System.Drawing.Point(937, 184);
            this.button_round2.Name = "button_round2";
            this.button_round2.Size = new System.Drawing.Size(75, 23);
            this.button_round2.TabIndex = 13;
            this.button_round2.Text = "Round 2";
            this.button_round2.UseVisualStyleBackColor = true;
            this.button_round2.Click += new System.EventHandler(this.button_round2_Click);
            // 
            // button_round3
            // 
            this.button_round3.Location = new System.Drawing.Point(1018, 184);
            this.button_round3.Name = "button_round3";
            this.button_round3.Size = new System.Drawing.Size(75, 23);
            this.button_round3.TabIndex = 14;
            this.button_round3.Text = "Round 3";
            this.button_round3.UseVisualStyleBackColor = true;
            this.button_round3.Click += new System.EventHandler(this.button_round3_Click);
            // 
            // button_round4
            // 
            this.button_round4.Location = new System.Drawing.Point(856, 213);
            this.button_round4.Name = "button_round4";
            this.button_round4.Size = new System.Drawing.Size(75, 23);
            this.button_round4.TabIndex = 15;
            this.button_round4.Text = "Round 4";
            this.button_round4.UseVisualStyleBackColor = true;
            this.button_round4.Click += new System.EventHandler(this.button_round4_Click);
            // 
            // button_round5
            // 
            this.button_round5.Location = new System.Drawing.Point(937, 213);
            this.button_round5.Name = "button_round5";
            this.button_round5.Size = new System.Drawing.Size(75, 23);
            this.button_round5.TabIndex = 16;
            this.button_round5.Text = "Round 5";
            this.button_round5.UseVisualStyleBackColor = true;
            this.button_round5.Click += new System.EventHandler(this.button_round5_Click);
            // 
            // button_round6
            // 
            this.button_round6.Location = new System.Drawing.Point(1018, 213);
            this.button_round6.Name = "button_round6";
            this.button_round6.Size = new System.Drawing.Size(75, 23);
            this.button_round6.TabIndex = 17;
            this.button_round6.Text = "Round 6";
            this.button_round6.UseVisualStyleBackColor = true;
            this.button_round6.Click += new System.EventHandler(this.button_round6_Click);
            // 
            // button_round7
            // 
            this.button_round7.Location = new System.Drawing.Point(856, 242);
            this.button_round7.Name = "button_round7";
            this.button_round7.Size = new System.Drawing.Size(75, 23);
            this.button_round7.TabIndex = 18;
            this.button_round7.Text = "Round 7";
            this.button_round7.UseVisualStyleBackColor = true;
            this.button_round7.Click += new System.EventHandler(this.button_round7_Click);
            // 
            // button_round8
            // 
            this.button_round8.Location = new System.Drawing.Point(937, 242);
            this.button_round8.Name = "button_round8";
            this.button_round8.Size = new System.Drawing.Size(75, 23);
            this.button_round8.TabIndex = 19;
            this.button_round8.Text = "Round 8";
            this.button_round8.UseVisualStyleBackColor = true;
            this.button_round8.Click += new System.EventHandler(this.button_round8_Click);
            // 
            // button_round9
            // 
            this.button_round9.Location = new System.Drawing.Point(1018, 242);
            this.button_round9.Name = "button_round9";
            this.button_round9.Size = new System.Drawing.Size(75, 23);
            this.button_round9.TabIndex = 20;
            this.button_round9.Text = "Round 9";
            this.button_round9.UseVisualStyleBackColor = true;
            this.button_round9.Click += new System.EventHandler(this.button_round9_Click);
            // 
            // button_round0
            // 
            this.button_round0.Location = new System.Drawing.Point(856, 155);
            this.button_round0.Name = "button_round0";
            this.button_round0.Size = new System.Drawing.Size(75, 23);
            this.button_round0.TabIndex = 21;
            this.button_round0.Text = "Round 0";
            this.button_round0.UseVisualStyleBackColor = true;
            this.button_round0.Click += new System.EventHandler(this.button_round0_Click);
            // 
            // button_config
            // 
            this.button_config.Location = new System.Drawing.Point(856, 126);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(75, 23);
            this.button_config.TabIndex = 22;
            this.button_config.Text = "Config";
            this.button_config.UseVisualStyleBackColor = true;
            this.button_config.Click += new System.EventHandler(this.button_config_Click);
            // 
            // label_timeTaken
            // 
            this.label_timeTaken.AutoSize = true;
            this.label_timeTaken.Location = new System.Drawing.Point(316, 238);
            this.label_timeTaken.Name = "label_timeTaken";
            this.label_timeTaken.Size = new System.Drawing.Size(63, 13);
            this.label_timeTaken.TabIndex = 23;
            this.label_timeTaken.Text = "Time taken:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 817);
            this.Controls.Add(this.label_timeTaken);
            this.Controls.Add(this.button_config);
            this.Controls.Add(this.button_round0);
            this.Controls.Add(this.button_round9);
            this.Controls.Add(this.button_round8);
            this.Controls.Add(this.button_round7);
            this.Controls.Add(this.button_round6);
            this.Controls.Add(this.button_round5);
            this.Controls.Add(this.button_round4);
            this.Controls.Add(this.button_round3);
            this.Controls.Add(this.button_round2);
            this.Controls.Add(this.button_round1);
            this.Controls.Add(this.label_selectKeyFormat);
            this.Controls.Add(this.button_keyInBytes);
            this.Controls.Add(this.button_keyInString);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.label_ciphertextAnswer);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.textBox_plaintext);
            this.Controls.Add(this.label_ciphertextLabel);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label_plaintext);
            this.Name = "Main";
            this.Text = "AES Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_plaintext;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_ciphertextLabel;
        private System.Windows.Forms.TextBox textBox_plaintext;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Label label_ciphertextAnswer;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_keyInString;
        private System.Windows.Forms.Button button_keyInBytes;
        private System.Windows.Forms.Label label_selectKeyFormat;
        private System.Windows.Forms.Button button_round1;
        private System.Windows.Forms.Button button_round2;
        private System.Windows.Forms.Button button_round3;
        private System.Windows.Forms.Button button_round4;
        private System.Windows.Forms.Button button_round5;
        private System.Windows.Forms.Button button_round6;
        private System.Windows.Forms.Button button_round7;
        private System.Windows.Forms.Button button_round8;
        private System.Windows.Forms.Button button_round9;
        private System.Windows.Forms.Button button_round0;
        private System.Windows.Forms.Button button_config;
        private System.Windows.Forms.Label label_timeTaken;
    }
}

