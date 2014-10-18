namespace Department_Using_Layer_Arch_App
{
    partial class DepartmentUI
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.departmentInfoGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            this.departmentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(81, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(81, 64);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(185, 20);
            this.codeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(162, 100);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Location = new System.Drawing.Point(12, 181);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.Size = new System.Drawing.Size(277, 336);
            this.departmentDataGridView.TabIndex = 4;
            // 
            // departmentInfoGroupBox
            // 
            this.departmentInfoGroupBox.Controls.Add(this.nameTextBox);
            this.departmentInfoGroupBox.Controls.Add(this.codeTextBox);
            this.departmentInfoGroupBox.Controls.Add(this.saveButton);
            this.departmentInfoGroupBox.Controls.Add(this.label1);
            this.departmentInfoGroupBox.Controls.Add(this.label2);
            this.departmentInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.departmentInfoGroupBox.Name = "departmentInfoGroupBox";
            this.departmentInfoGroupBox.Size = new System.Drawing.Size(277, 150);
            this.departmentInfoGroupBox.TabIndex = 5;
            this.departmentInfoGroupBox.TabStop = false;
            this.departmentInfoGroupBox.Text = "Department Information";
            // 
            // DepartmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 529);
            this.Controls.Add(this.departmentInfoGroupBox);
            this.Controls.Add(this.departmentDataGridView);
            this.Name = "DepartmentUI";
            this.ShowInTaskbar = false;
            this.Text = "Department Information UI";
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            this.departmentInfoGroupBox.ResumeLayout(false);
            this.departmentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.GroupBox departmentInfoGroupBox;
    }
}

