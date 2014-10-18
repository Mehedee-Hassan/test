namespace Department_Using_Layer_Arch_App
{
    partial class University_UI
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
            this.departmentUiButton = new System.Windows.Forms.Button();
            this.studentUiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentUiButton
            // 
            this.departmentUiButton.Location = new System.Drawing.Point(59, 90);
            this.departmentUiButton.Name = "departmentUiButton";
            this.departmentUiButton.Size = new System.Drawing.Size(106, 128);
            this.departmentUiButton.TabIndex = 0;
            this.departmentUiButton.Text = "Department UI";
            this.departmentUiButton.UseVisualStyleBackColor = true;
            this.departmentUiButton.Click += new System.EventHandler(this.departmentUiButton_Click);
            // 
            // studentUiButton
            // 
            this.studentUiButton.Location = new System.Drawing.Point(226, 90);
            this.studentUiButton.Name = "studentUiButton";
            this.studentUiButton.Size = new System.Drawing.Size(106, 128);
            this.studentUiButton.TabIndex = 0;
            this.studentUiButton.Text = "Student UI";
            this.studentUiButton.UseVisualStyleBackColor = true;
            this.studentUiButton.Click += new System.EventHandler(this.studentUiButton_Click);
            // 
            // University_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 333);
            this.Controls.Add(this.studentUiButton);
            this.Controls.Add(this.departmentUiButton);
            this.Name = "University_UI";
            this.Text = "University_UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button departmentUiButton;
        private System.Windows.Forms.Button studentUiButton;
    }
}