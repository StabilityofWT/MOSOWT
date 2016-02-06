namespace MoSoWT
{
    partial class Wifi_Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Address_textbox = new System.Windows.Forms.TextBox();
            this.Port_textbox = new System.Windows.Forms.TextBox();
            this.Listen_Button = new System.Windows.Forms.Button();
            this.Status_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // Address_textbox
            // 
            this.Address_textbox.Location = new System.Drawing.Point(94, 12);
            this.Address_textbox.Name = "Address_textbox";
            this.Address_textbox.Size = new System.Drawing.Size(102, 20);
            this.Address_textbox.TabIndex = 2;
            this.Address_textbox.Text = "192.168.5.101";
            // 
            // Port_textbox
            // 
            this.Port_textbox.Location = new System.Drawing.Point(47, 43);
            this.Port_textbox.Name = "Port_textbox";
            this.Port_textbox.Size = new System.Drawing.Size(59, 20);
            this.Port_textbox.TabIndex = 3;
            this.Port_textbox.Text = "5000";
            // 
            // Listen_Button
            // 
            this.Listen_Button.Location = new System.Drawing.Point(15, 78);
            this.Listen_Button.Name = "Listen_Button";
            this.Listen_Button.Size = new System.Drawing.Size(75, 23);
            this.Listen_Button.TabIndex = 4;
            this.Listen_Button.Text = "LISTENING";
            this.Listen_Button.UseVisualStyleBackColor = true;
            this.Listen_Button.Click += new System.EventHandler(this.Listen_Button_Click);
            // 
            // Status_textbox
            // 
            this.Status_textbox.Location = new System.Drawing.Point(15, 116);
            this.Status_textbox.Multiline = true;
            this.Status_textbox.Name = "Status_textbox";
            this.Status_textbox.ReadOnly = true;
            this.Status_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Status_textbox.Size = new System.Drawing.Size(181, 133);
            this.Status_textbox.TabIndex = 5;
            // 
            // Wifi_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 261);
            this.Controls.Add(this.Status_textbox);
            this.Controls.Add(this.Listen_Button);
            this.Controls.Add(this.Port_textbox);
            this.Controls.Add(this.Address_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Wifi_Server";
            this.Text = "Wifi_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Address_textbox;
        private System.Windows.Forms.TextBox Port_textbox;
        private System.Windows.Forms.Button Listen_Button;
        private System.Windows.Forms.TextBox Status_textbox;
    }
}