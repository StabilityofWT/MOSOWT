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
            this.WiFi_Monitor_Button = new System.Windows.Forms.Button();
            this.BL_Monitor_Button = new System.Windows.Forms.Button();
            this.Wifi_Send_Client_Button = new System.Windows.Forms.Button();
            this.BL_Send_Client_Button = new System.Windows.Forms.Button();
            this.Wifi_Send_Server_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BL_Send_Server_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WiFi_Monitor_Button
            // 
            this.WiFi_Monitor_Button.Location = new System.Drawing.Point(12, 95);
            this.WiFi_Monitor_Button.Name = "WiFi_Monitor_Button";
            this.WiFi_Monitor_Button.Size = new System.Drawing.Size(150, 25);
            this.WiFi_Monitor_Button.TabIndex = 0;
            this.WiFi_Monitor_Button.Text = "Monitor";
            this.WiFi_Monitor_Button.UseVisualStyleBackColor = true;
            this.WiFi_Monitor_Button.Click += new System.EventHandler(this.WiFi_Button_Click);
            // 
            // BL_Monitor_Button
            // 
            this.BL_Monitor_Button.Location = new System.Drawing.Point(183, 95);
            this.BL_Monitor_Button.Name = "BL_Monitor_Button";
            this.BL_Monitor_Button.Size = new System.Drawing.Size(150, 25);
            this.BL_Monitor_Button.TabIndex = 1;
            this.BL_Monitor_Button.Text = "Monitor";
            this.BL_Monitor_Button.UseVisualStyleBackColor = true;
            this.BL_Monitor_Button.Click += new System.EventHandler(this.BL_Button_Click);
            // 
            // Wifi_Send_Client_Button
            // 
            this.Wifi_Send_Client_Button.Location = new System.Drawing.Point(12, 64);
            this.Wifi_Send_Client_Button.Name = "Wifi_Send_Client_Button";
            this.Wifi_Send_Client_Button.Size = new System.Drawing.Size(150, 25);
            this.Wifi_Send_Client_Button.TabIndex = 2;
            this.Wifi_Send_Client_Button.Text = "Send File - Client";
            this.Wifi_Send_Client_Button.UseVisualStyleBackColor = true;
            // 
            // BL_Send_Client_Button
            // 
            this.BL_Send_Client_Button.Location = new System.Drawing.Point(183, 64);
            this.BL_Send_Client_Button.Name = "BL_Send_Client_Button";
            this.BL_Send_Client_Button.Size = new System.Drawing.Size(150, 25);
            this.BL_Send_Client_Button.TabIndex = 3;
            this.BL_Send_Client_Button.Text = "Send File - Client";
            this.BL_Send_Client_Button.UseVisualStyleBackColor = true;
            // 
            // Wifi_Send_Server_Button
            // 
            this.Wifi_Send_Server_Button.Location = new System.Drawing.Point(12, 33);
            this.Wifi_Send_Server_Button.Name = "Wifi_Send_Server_Button";
            this.Wifi_Send_Server_Button.Size = new System.Drawing.Size(150, 25);
            this.Wifi_Send_Server_Button.TabIndex = 4;
            this.Wifi_Send_Server_Button.Text = "Send File - Server";
            this.Wifi_Send_Server_Button.UseVisualStyleBackColor = true;
            this.Wifi_Send_Server_Button.Click += new System.EventHandler(this.Wifi_Send_Server_Button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(62, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wi-Fi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(223, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bluetooth";
            // 
            // BL_Send_Server_Button
            // 
            this.BL_Send_Server_Button.Location = new System.Drawing.Point(183, 33);
            this.BL_Send_Server_Button.Name = "BL_Send_Server_Button";
            this.BL_Send_Server_Button.Size = new System.Drawing.Size(150, 25);
            this.BL_Send_Server_Button.TabIndex = 7;
            this.BL_Send_Server_Button.Text = "Send File - Server";
            this.BL_Send_Server_Button.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 150);
            this.Controls.Add(this.BL_Send_Server_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wifi_Send_Server_Button);
            this.Controls.Add(this.BL_Send_Client_Button);
            this.Controls.Add(this.Wifi_Send_Client_Button);
            this.Controls.Add(this.BL_Monitor_Button);
            this.Controls.Add(this.WiFi_Monitor_Button);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WiFi_Monitor_Button;
        private System.Windows.Forms.Button BL_Monitor_Button;
        private System.Windows.Forms.Button Wifi_Send_Client_Button;
        private System.Windows.Forms.Button BL_Send_Client_Button;
        private System.Windows.Forms.Button Wifi_Send_Server_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BL_Send_Server_Button;
    }
}