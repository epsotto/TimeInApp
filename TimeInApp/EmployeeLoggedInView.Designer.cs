namespace TimeInApp
{
    partial class EmployeeLoggedInView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClockInActivity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClockOut = new System.Windows.Forms.Button();
            this.ClockIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ClockOutActivity = new System.Windows.Forms.TextBox();
            this.ClockOutActivityId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGridMessage = new System.Windows.Forms.TextBox();
            this.UpdatePasswordButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UpdatePasswordButton);
            this.panel1.Controls.Add(this.ClockOutActivityId);
            this.panel1.Controls.Add(this.ClockOutActivity);
            this.panel1.Controls.Add(this.ClockInActivity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ClockOut);
            this.panel1.Controls.Add(this.ClockIn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 334);
            this.panel1.TabIndex = 3;
            // 
            // ClockInActivity
            // 
            this.ClockInActivity.FormattingEnabled = true;
            this.ClockInActivity.Location = new System.Drawing.Point(50, 93);
            this.ClockInActivity.Name = "ClockInActivity";
            this.ClockInActivity.Size = new System.Drawing.Size(235, 24);
            this.ClockInActivity.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // ClockOut
            // 
            this.ClockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockOut.Location = new System.Drawing.Point(50, 224);
            this.ClockOut.Name = "ClockOut";
            this.ClockOut.Size = new System.Drawing.Size(235, 55);
            this.ClockOut.TabIndex = 5;
            this.ClockOut.Text = "Clock Out";
            this.ClockOut.UseVisualStyleBackColor = true;
            this.ClockOut.Click += new System.EventHandler(this.ClockOut_Click);
            // 
            // ClockIn
            // 
            this.ClockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockIn.Location = new System.Drawing.Point(50, 123);
            this.ClockIn.Name = "ClockIn";
            this.ClockIn.Size = new System.Drawing.Size(235, 54);
            this.ClockIn.TabIndex = 4;
            this.ClockIn.Text = "Clock In";
            this.ClockIn.UseVisualStyleBackColor = true;
            this.ClockIn.Click += new System.EventHandler(this.ClockIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DataGridMessage);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(399, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 334);
            this.panel2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Record as of:";
            // 
            // ClockOutActivity
            // 
            this.ClockOutActivity.Location = new System.Drawing.Point(50, 196);
            this.ClockOutActivity.Name = "ClockOutActivity";
            this.ClockOutActivity.Size = new System.Drawing.Size(235, 22);
            this.ClockOutActivity.TabIndex = 9;
            // 
            // ClockOutActivityId
            // 
            this.ClockOutActivityId.Enabled = false;
            this.ClockOutActivityId.Location = new System.Drawing.Point(50, 212);
            this.ClockOutActivityId.Name = "ClockOutActivityId";
            this.ClockOutActivityId.Size = new System.Drawing.Size(100, 22);
            this.ClockOutActivityId.TabIndex = 10;
            this.ClockOutActivityId.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 272);
            this.dataGridView1.TabIndex = 2;
            // 
            // DataGridMessage
            // 
            this.DataGridMessage.Location = new System.Drawing.Point(9, 47);
            this.DataGridMessage.Name = "DataGridMessage";
            this.DataGridMessage.Size = new System.Drawing.Size(309, 22);
            this.DataGridMessage.TabIndex = 3;
            // 
            // UpdatePasswordButton
            // 
            this.UpdatePasswordButton.Location = new System.Drawing.Point(50, 295);
            this.UpdatePasswordButton.Name = "UpdatePasswordButton";
            this.UpdatePasswordButton.Size = new System.Drawing.Size(235, 23);
            this.UpdatePasswordButton.TabIndex = 11;
            this.UpdatePasswordButton.Text = "Update Password";
            this.UpdatePasswordButton.UseVisualStyleBackColor = true;
            this.UpdatePasswordButton.Click += new System.EventHandler(this.UpdatePasswordButton_Click);
            // 
            // EmployeeLoggedInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeLoggedInView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee EZ Attendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeLoggedInView_Closed);
            this.Load += new System.EventHandler(this.EmployeeLoggedInView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClockOut;
        private System.Windows.Forms.Button ClockIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClockInActivity;
        private System.Windows.Forms.TextBox ClockOutActivity;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox ClockOutActivityId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DataGridMessage;
        private System.Windows.Forms.Button UpdatePasswordButton;
    }
}