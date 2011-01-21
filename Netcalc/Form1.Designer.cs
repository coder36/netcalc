namespace Netcalc
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
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.masktextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bitTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.networkTextbox = new System.Windows.Forms.TextBox();
            this.ipFromTextbox = new System.Windows.Forms.TextBox();
            this.ipToTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(72, 12);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(117, 20);
            this.ipTextBox.TabIndex = 0;
            // 
            // masktextBox
            // 
            this.masktextBox.Location = new System.Drawing.Point(72, 39);
            this.masktextBox.Name = "masktextBox";
            this.masktextBox.Size = new System.Drawing.Size(117, 20);
            this.masktextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mask";
            // 
            // bitTextBox
            // 
            this.bitTextBox.Location = new System.Drawing.Point(208, 12);
            this.bitTextBox.Name = "bitTextBox";
            this.bitTextBox.Size = new System.Drawing.Size(36, 20);
            this.bitTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // networkTextbox
            // 
            this.networkTextbox.Location = new System.Drawing.Point(72, 143);
            this.networkTextbox.Name = "networkTextbox";
            this.networkTextbox.ReadOnly = true;
            this.networkTextbox.Size = new System.Drawing.Size(117, 20);
            this.networkTextbox.TabIndex = 6;
            // 
            // ipFromTextbox
            // 
            this.ipFromTextbox.Location = new System.Drawing.Point(72, 169);
            this.ipFromTextbox.Name = "ipFromTextbox";
            this.ipFromTextbox.ReadOnly = true;
            this.ipFromTextbox.Size = new System.Drawing.Size(117, 20);
            this.ipFromTextbox.TabIndex = 7;
            // 
            // ipToTextBox
            // 
            this.ipToTextBox.Location = new System.Drawing.Point(217, 169);
            this.ipToTextBox.Name = "ipToTextBox";
            this.ipToTextBox.ReadOnly = true;
            this.ipToTextBox.Size = new System.Drawing.Size(117, 20);
            this.ipToTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Network";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "IP range";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "to";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ipToTextBox);
            this.Controls.Add(this.ipFromTextbox);
            this.Controls.Add(this.networkTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bitTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masktextBox);
            this.Controls.Add(this.ipTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NetCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox masktextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bitTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox networkTextbox;
        private System.Windows.Forms.TextBox ipFromTextbox;
        private System.Windows.Forms.TextBox ipToTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

