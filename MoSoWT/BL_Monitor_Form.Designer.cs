namespace MoSoWT
{
    partial class BL_Monitor_Form
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
            this.BL_start = new System.Windows.Forms.Button();
            this.BL_monitor_TBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BL_start
            // 
            this.BL_start.Location = new System.Drawing.Point(12, 12);
            this.BL_start.Name = "BL_start";
            this.BL_start.Size = new System.Drawing.Size(134, 23);
            this.BL_start.TabIndex = 0;
            this.BL_start.Text = "START MONITOR";
            this.BL_start.UseVisualStyleBackColor = true;
            this.BL_start.Click += new System.EventHandler(this.BL_start_Click);
            // 
            // BL_monitor_TBox
            // 
            this.BL_monitor_TBox.Location = new System.Drawing.Point(12, 41);
            this.BL_monitor_TBox.Multiline = true;
            this.BL_monitor_TBox.Name = "BL_monitor_TBox";
            this.BL_monitor_TBox.ReadOnly = true;
            this.BL_monitor_TBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BL_monitor_TBox.Size = new System.Drawing.Size(260, 208);
            this.BL_monitor_TBox.TabIndex = 1;
            // 
            // BL_Monitor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BL_monitor_TBox);
            this.Controls.Add(this.BL_start);
            this.Name = "BL_Monitor_Form";
            this.Text = "BL_Monitor_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BL_start;
        private System.Windows.Forms.TextBox BL_monitor_TBox;
    }
}