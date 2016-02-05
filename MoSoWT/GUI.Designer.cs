namespace MoSoWT
{
    partial class GUI
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
            this.WiFi_Button = new System.Windows.Forms.Button();
            this.BL_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WiFi_Button
            // 
            this.WiFi_Button.Location = new System.Drawing.Point(12, 12);
            this.WiFi_Button.Name = "WiFi_Button";
            this.WiFi_Button.Size = new System.Drawing.Size(75, 23);
            this.WiFi_Button.TabIndex = 0;
            this.WiFi_Button.Text = "Wi-Fi";
            this.WiFi_Button.UseVisualStyleBackColor = true;
            this.WiFi_Button.Click += new System.EventHandler(this.WiFi_Button_Click);
            // 
            // BL_Button
            // 
            this.BL_Button.Location = new System.Drawing.Point(197, 12);
            this.BL_Button.Name = "BL_Button";
            this.BL_Button.Size = new System.Drawing.Size(75, 23);
            this.BL_Button.TabIndex = 1;
            this.BL_Button.Text = "Bluetooth";
            this.BL_Button.UseVisualStyleBackColor = true;
            this.BL_Button.Click += new System.EventHandler(this.BL_Button_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BL_Button);
            this.Controls.Add(this.WiFi_Button);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WiFi_Button;
        private System.Windows.Forms.Button BL_Button;
    }
}