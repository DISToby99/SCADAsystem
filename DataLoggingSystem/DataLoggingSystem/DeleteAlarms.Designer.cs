namespace DataLoggingSystem
{
    partial class DeleteAlarms
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
            this.Alarm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alarm
            // 
            this.Alarm.FormattingEnabled = true;
            this.Alarm.Location = new System.Drawing.Point(168, 24);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(159, 21);
            this.Alarm.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select Alarm by description";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(26, 80);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(283, 23);
            this.Create.TabIndex = 14;
            this.Create.Text = "Delete";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // DeleteAlarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 115);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Alarm);
            this.Name = "DeleteAlarms";
            this.Text = "DeleteAlarms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Alarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Create;
    }
}