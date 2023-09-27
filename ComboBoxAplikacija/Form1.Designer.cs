namespace ComboBoxAplikacija
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
            this.dorucakButton = new System.Windows.Forms.CheckBox();
            this.rucakButton = new System.Windows.Forms.CheckBox();
            this.veceraButton = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sakrijNarudzbuCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dorucakButton
            // 
            this.dorucakButton.AutoSize = true;
            this.dorucakButton.Location = new System.Drawing.Point(33, 48);
            this.dorucakButton.Name = "dorucakButton";
            this.dorucakButton.Size = new System.Drawing.Size(67, 17);
            this.dorucakButton.TabIndex = 0;
            this.dorucakButton.Text = "Dorucak";
            this.dorucakButton.UseVisualStyleBackColor = true;
            // 
            // rucakButton
            // 
            this.rucakButton.AutoSize = true;
            this.rucakButton.Location = new System.Drawing.Point(33, 86);
            this.rucakButton.Name = "rucakButton";
            this.rucakButton.Size = new System.Drawing.Size(58, 17);
            this.rucakButton.TabIndex = 1;
            this.rucakButton.Text = "Rucak";
            this.rucakButton.UseVisualStyleBackColor = true;
            // 
            // veceraButton
            // 
            this.veceraButton.AutoSize = true;
            this.veceraButton.Location = new System.Drawing.Point(33, 127);
            this.veceraButton.Name = "veceraButton";
            this.veceraButton.Size = new System.Drawing.Size(60, 17);
            this.veceraButton.TabIndex = 2;
            this.veceraButton.Text = "Vecera";
            this.veceraButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 96);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sakrijNarudzbuCheckBox
            // 
            this.sakrijNarudzbuCheckBox.AutoSize = true;
            this.sakrijNarudzbuCheckBox.Location = new System.Drawing.Point(163, 210);
            this.sakrijNarudzbuCheckBox.Name = "sakrijNarudzbuCheckBox";
            this.sakrijNarudzbuCheckBox.Size = new System.Drawing.Size(99, 17);
            this.sakrijNarudzbuCheckBox.TabIndex = 6;
            this.sakrijNarudzbuCheckBox.Text = "Sakrij narudžbu";
            this.sakrijNarudzbuCheckBox.UseVisualStyleBackColor = true;
            this.sakrijNarudzbuCheckBox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 266);
            this.Controls.Add(this.sakrijNarudzbuCheckBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.veceraButton);
            this.Controls.Add(this.rucakButton);
            this.Controls.Add(this.dorucakButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dorucakButton;
        private System.Windows.Forms.CheckBox rucakButton;
        private System.Windows.Forms.CheckBox veceraButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox sakrijNarudzbuCheckBox;
    }
}

