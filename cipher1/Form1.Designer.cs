namespace cipher1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.ciphertext = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textorg = new System.Windows.Forms.TextBox();
            this.deckey = new System.Windows.Forms.TextBox();
            this.cipherorg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orignal Yext";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(165, 36);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(116, 20);
            this.text.TabIndex = 2;
            // 
            // ciphertext
            // 
            this.ciphertext.Location = new System.Drawing.Point(165, 104);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.ReadOnly = true;
            this.ciphertext.Size = new System.Drawing.Size(116, 20);
            this.ciphertext.TabIndex = 3;
            this.ciphertext.TextChanged += new System.EventHandler(this.cipher_TextChanged);
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.SystemColors.Window;
            this.key.Location = new System.Drawing.Point(165, 168);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(116, 20);
            this.key.TabIndex = 4;
            this.key.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Converted Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textorg);
            this.groupBox1.Controls.Add(this.deckey);
            this.groupBox1.Controls.Add(this.cipherorg);
            this.groupBox1.Location = new System.Drawing.Point(357, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 233);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decoding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Orignal text";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cipher Text";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Decode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textorg
            // 
            this.textorg.Location = new System.Drawing.Point(108, 137);
            this.textorg.Name = "textorg";
            this.textorg.ReadOnly = true;
            this.textorg.Size = new System.Drawing.Size(121, 20);
            this.textorg.TabIndex = 2;
            // 
            // deckey
            // 
            this.deckey.Location = new System.Drawing.Point(108, 77);
            this.deckey.Name = "deckey";
            this.deckey.Size = new System.Drawing.Size(121, 20);
            this.deckey.TabIndex = 1;
            this.deckey.TextChanged += new System.EventHandler(this.deckey_TextChanged);
            // 
            // cipherorg
            // 
            this.cipherorg.Location = new System.Drawing.Point(108, 32);
            this.cipherorg.Name = "cipherorg";
            this.cipherorg.Size = new System.Drawing.Size(121, 20);
            this.cipherorg.TabIndex = 0;
            this.cipherorg.TextChanged += new System.EventHandler(this.cipherorg_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 285);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key);
            this.Controls.Add(this.ciphertext);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ceaser Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox ciphertext;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textorg;
        private System.Windows.Forms.TextBox deckey;
        private System.Windows.Forms.TextBox cipherorg;
        private System.Windows.Forms.Button button3;
    }
}

