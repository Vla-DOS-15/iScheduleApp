﻿namespace iScheduleApp.View
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameStudent = new System.Windows.Forms.TextBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.btnReadSchedule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ви увійшли як";
            // 
            // tbNameStudent
            // 
            this.tbNameStudent.Location = new System.Drawing.Point(452, 9);
            this.tbNameStudent.Name = "tbNameStudent";
            this.tbNameStudent.Size = new System.Drawing.Size(163, 20);
            this.tbNameStudent.TabIndex = 1;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(103, 62);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(804, 21);
            this.comboBoxFaculty.TabIndex = 2;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(542, 119);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(143, 21);
            this.comboBoxGroup.TabIndex = 3;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxCourse.Location = new System.Drawing.Point(331, 119);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(143, 21);
            this.comboBoxCourse.TabIndex = 4;
            // 
            // btnReadSchedule
            // 
            this.btnReadSchedule.Location = new System.Drawing.Point(737, 110);
            this.btnReadSchedule.Name = "btnReadSchedule";
            this.btnReadSchedule.Size = new System.Drawing.Size(170, 37);
            this.btnReadSchedule.TabIndex = 5;
            this.btnReadSchedule.Text = "Показати розклад занять";
            this.btnReadSchedule.UseVisualStyleBackColor = true;
            this.btnReadSchedule.Click += new System.EventHandler(this.btnReadSchedule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1001, 246);
            this.dataGridView1.TabIndex = 6;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "Понеділок",
            "Вівторок",
            "Середа",
            "Четвер",
            "П\'ятниця"});
            this.comboBoxDay.Location = new System.Drawing.Point(103, 119);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(143, 21);
            this.comboBoxDay.TabIndex = 8;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReadSchedule);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.tbNameStudent);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameStudent;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Button btnReadSchedule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxDay;
    }
}