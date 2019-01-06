namespace TimeInApp
{
    partial class AdminDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeMaintenanceButton = new System.Windows.Forms.Button();
            this.ActivityMaintenanceButton = new System.Windows.Forms.Button();
            this.ClockInOverrideButton = new System.Windows.Forms.Button();
            this.ClockOutOverrideButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(298, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(456, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 30);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 6, 20, 20, 35, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Records as of:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // EmployeeMaintenanceButton
            // 
            this.EmployeeMaintenanceButton.Location = new System.Drawing.Point(30, 159);
            this.EmployeeMaintenanceButton.Name = "EmployeeMaintenanceButton";
            this.EmployeeMaintenanceButton.Size = new System.Drawing.Size(241, 40);
            this.EmployeeMaintenanceButton.TabIndex = 5;
            this.EmployeeMaintenanceButton.Text = "Employee Maintenance";
            this.EmployeeMaintenanceButton.UseVisualStyleBackColor = true;
            // 
            // ActivityMaintenanceButton
            // 
            this.ActivityMaintenanceButton.Location = new System.Drawing.Point(30, 205);
            this.ActivityMaintenanceButton.Name = "ActivityMaintenanceButton";
            this.ActivityMaintenanceButton.Size = new System.Drawing.Size(241, 40);
            this.ActivityMaintenanceButton.TabIndex = 6;
            this.ActivityMaintenanceButton.Text = "Activity Maintenance";
            this.ActivityMaintenanceButton.UseVisualStyleBackColor = true;
            // 
            // ClockInOverrideButton
            // 
            this.ClockInOverrideButton.Location = new System.Drawing.Point(30, 251);
            this.ClockInOverrideButton.Name = "ClockInOverrideButton";
            this.ClockInOverrideButton.Size = new System.Drawing.Size(241, 40);
            this.ClockInOverrideButton.TabIndex = 7;
            this.ClockInOverrideButton.Text = "Clock-In Override";
            this.ClockInOverrideButton.UseVisualStyleBackColor = true;
            // 
            // ClockOutOverrideButton
            // 
            this.ClockOutOverrideButton.Location = new System.Drawing.Point(30, 297);
            this.ClockOutOverrideButton.Name = "ClockOutOverrideButton";
            this.ClockOutOverrideButton.Size = new System.Drawing.Size(241, 40);
            this.ClockOutOverrideButton.TabIndex = 8;
            this.ClockOutOverrideButton.Text = "Clock-Out Override";
            this.ClockOutOverrideButton.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.ClockOutOverrideButton);
            this.Controls.Add(this.ClockInOverrideButton);
            this.Controls.Add(this.ActivityMaintenanceButton);
            this.Controls.Add(this.EmployeeMaintenanceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDashboard";
            this.Text = "Admin TimeIn Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EmployeeMaintenanceButton;
        private System.Windows.Forms.Button ActivityMaintenanceButton;
        private System.Windows.Forms.Button ClockInOverrideButton;
        private System.Windows.Forms.Button ClockOutOverrideButton;
    }
}