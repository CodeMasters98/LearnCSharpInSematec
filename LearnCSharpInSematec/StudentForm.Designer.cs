﻿namespace LearnCSharpInSematec
{
    partial class StudentForm
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
            registerButton = new Button();
            label6 = new Label();
            nationalCodeTextBox = new TextBox();
            label5 = new Label();
            phoneNumberTextBox = new TextBox();
            label4 = new Label();
            lastNameTextBox = new TextBox();
            label3 = new Label();
            firstNameTextBox = new TextBox();
            studentDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Location = new Point(8, 141);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(249, 39);
            registerButton.TabIndex = 22;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 120);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 21;
            label6.Text = "NationalCode:";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(103, 112);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(470, 23);
            nationalCodeTextBox.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 19;
            label5.Text = "PhoneNumber: ";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(103, 80);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(470, 23);
            phoneNumberTextBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 42);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 17;
            label4.Text = "LastName: ";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(74, 39);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(499, 23);
            lastNameTextBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 6);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 15;
            label3.Text = "FirstName:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(74, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(499, 23);
            firstNameTextBox.TabIndex = 14;
            // 
            // studentDataGridView
            // 
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Location = new Point(6, 186);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.Size = new Size(567, 235);
            studentDataGridView.TabIndex = 23;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 433);
            Controls.Add(studentDataGridView);
            Controls.Add(registerButton);
            Controls.Add(label6);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(label5);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(label4);
            Controls.Add(lastNameTextBox);
            Controls.Add(label3);
            Controls.Add(firstNameTextBox);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label label6;
        private TextBox nationalCodeTextBox;
        private Label label5;
        private TextBox phoneNumberTextBox;
        private Label label4;
        private TextBox lastNameTextBox;
        private Label label3;
        private TextBox firstNameTextBox;
        private DataGridView studentDataGridView;
    }
}