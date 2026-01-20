namespace LibreHardwareMonitor.UI
{
    partial class SerialPortBox
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
            this.SerialOKButton = new System.Windows.Forms.Button();
            this.SerialCancelButton = new System.Windows.Forms.Button();
            this.SerialPortcomboBox = new System.Windows.Forms.ComboBox();
            this.COMPortlabel = new System.Windows.Forms.Label();
            this.SerialPortSpeedcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SerialOKButton
            // 
            this.SerialOKButton.Location = new System.Drawing.Point(119, 206);
            this.SerialOKButton.Name = "SerialOKButton";
            this.SerialOKButton.Size = new System.Drawing.Size(75, 23);
            this.SerialOKButton.TabIndex = 0;
            this.SerialOKButton.Text = "OK";
            this.SerialOKButton.UseVisualStyleBackColor = true;
            this.SerialOKButton.Click += new System.EventHandler(this.SerialOKButton_Click);
            // 
            // SerialCancelButton
            // 
            this.SerialCancelButton.Location = new System.Drawing.Point(200, 206);
            this.SerialCancelButton.Name = "SerialCancelButton";
            this.SerialCancelButton.Size = new System.Drawing.Size(75, 23);
            this.SerialCancelButton.TabIndex = 1;
            this.SerialCancelButton.Text = "Cancel";
            this.SerialCancelButton.UseVisualStyleBackColor = true;
            this.SerialCancelButton.Click += new System.EventHandler(this.SerialCancelButton_Click);
            // 
            // SerialPortcomboBox
            // 
            this.SerialPortcomboBox.FormattingEnabled = true;
            this.SerialPortcomboBox.Location = new System.Drawing.Point(12, 47);
            this.SerialPortcomboBox.Name = "SerialPortcomboBox";
            this.SerialPortcomboBox.Size = new System.Drawing.Size(261, 21);
            this.SerialPortcomboBox.TabIndex = 3;
            this.SerialPortcomboBox.SelectedIndexChanged += new System.EventHandler(this.SerialPortcomboBox_SelectedIndexChanged);
            // 
            // COMPortlabel
            // 
            this.COMPortlabel.AutoSize = true;
            this.COMPortlabel.Location = new System.Drawing.Point(12, 31);
            this.COMPortlabel.Name = "COMPortlabel";
            this.COMPortlabel.Size = new System.Drawing.Size(247, 13);
            this.COMPortlabel.TabIndex = 4;
            this.COMPortlabel.Text = "Please select you COM port from the drop down list";
            // 
            // SerialPortSpeedcomboBox
            // 
            this.SerialPortSpeedcomboBox.FormattingEnabled = true;
            this.SerialPortSpeedcomboBox.Location = new System.Drawing.Point(12, 106);
            this.SerialPortSpeedcomboBox.Name = "SerialPortSpeedcomboBox";
            this.SerialPortSpeedcomboBox.Size = new System.Drawing.Size(261, 21);
            this.SerialPortSpeedcomboBox.TabIndex = 5;
            this.SerialPortSpeedcomboBox.SelectedIndexChanged += new System.EventHandler(this.SerialPortSpeedcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port Speed";
            // 
            // SerialPortBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SerialPortSpeedcomboBox);
            this.Controls.Add(this.COMPortlabel);
            this.Controls.Add(this.SerialPortcomboBox);
            this.Controls.Add(this.SerialCancelButton);
            this.Controls.Add(this.SerialOKButton);
            this.Name = "SerialPortBox";
            this.Text = "Serial Port Selection";
            this.Load += new System.EventHandler(this.SerialPortBox_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SerialOKButton;
        private System.Windows.Forms.Button SerialCancelButton;
        private System.Windows.Forms.ComboBox SerialPortcomboBox;
        private System.Windows.Forms.Label COMPortlabel;
        private System.Windows.Forms.ComboBox SerialPortSpeedcomboBox;
        private System.Windows.Forms.Label label1;
    }
}
