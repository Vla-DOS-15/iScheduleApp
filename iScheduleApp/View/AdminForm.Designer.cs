namespace iScheduleApp.View
{
    partial class AdminForm
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLessonTypeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddLessonTypeName = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.btnAddAuditory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownBuildingNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFloor = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownAuditoriumNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAddPairNumber = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.btnAddFacultyName = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbFacultyName = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewAuditory = new System.Windows.Forms.DataGridView();
            this.dataGridViewPairNumber = new System.Windows.Forms.DataGridView();
            this.dataGridViewLessonType = new System.Windows.Forms.DataGridView();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.dataGridViewFaculty = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuildingNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAuditoriumNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuditory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPairNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(29, 107);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(198, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(29, 156);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(198, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(29, 245);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(198, 33);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Додати користувача";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(29, 202);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(198, 21);
            this.comboBoxRole.TabIndex = 3;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(29, 57);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(198, 20);
            this.tbUserName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ПІБ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Роль";
            // 
            // tbLessonTypeName
            // 
            this.tbLessonTypeName.Location = new System.Drawing.Point(839, 230);
            this.tbLessonTypeName.Name = "tbLessonTypeName";
            this.tbLessonTypeName.Size = new System.Drawing.Size(198, 20);
            this.tbLessonTypeName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(836, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип пари";
            // 
            // btnAddLessonTypeName
            // 
            this.btnAddLessonTypeName.Location = new System.Drawing.Point(839, 267);
            this.btnAddLessonTypeName.Name = "btnAddLessonTypeName";
            this.btnAddLessonTypeName.Size = new System.Drawing.Size(198, 26);
            this.btnAddLessonTypeName.TabIndex = 11;
            this.btnAddLessonTypeName.Text = "Додати";
            this.btnAddLessonTypeName.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(839, 428);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(198, 25);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Додати";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(836, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Викладач";
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.Location = new System.Drawing.Point(839, 386);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(198, 20);
            this.tbTeacherName.TabIndex = 12;
            // 
            // btnAddAuditory
            // 
            this.btnAddAuditory.Location = new System.Drawing.Point(29, 590);
            this.btnAddAuditory.Name = "btnAddAuditory";
            this.btnAddAuditory.Size = new System.Drawing.Size(198, 25);
            this.btnAddAuditory.TabIndex = 20;
            this.btnAddAuditory.Text = "Додати";
            this.btnAddAuditory.UseVisualStyleBackColor = true;
            this.btnAddAuditory.Click += new System.EventHandler(this.btnAddAuditory_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер корпусу";
            // 
            // numericUpDownBuildingNumber
            // 
            this.numericUpDownBuildingNumber.Location = new System.Drawing.Point(29, 450);
            this.numericUpDownBuildingNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownBuildingNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBuildingNumber.Name = "numericUpDownBuildingNumber";
            this.numericUpDownBuildingNumber.Size = new System.Drawing.Size(198, 20);
            this.numericUpDownBuildingNumber.TabIndex = 21;
            this.numericUpDownBuildingNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownFloor
            // 
            this.numericUpDownFloor.Location = new System.Drawing.Point(29, 498);
            this.numericUpDownFloor.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFloor.Name = "numericUpDownFloor";
            this.numericUpDownFloor.Size = new System.Drawing.Size(198, 20);
            this.numericUpDownFloor.TabIndex = 22;
            this.numericUpDownFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Поверх";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Номер аудиторії";
            // 
            // numericUpDownAuditoriumNumber
            // 
            this.numericUpDownAuditoriumNumber.Location = new System.Drawing.Point(29, 548);
            this.numericUpDownAuditoriumNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownAuditoriumNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAuditoriumNumber.Name = "numericUpDownAuditoriumNumber";
            this.numericUpDownAuditoriumNumber.Size = new System.Drawing.Size(198, 20);
            this.numericUpDownAuditoriumNumber.TabIndex = 24;
            this.numericUpDownAuditoriumNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddPairNumber
            // 
            this.btnAddPairNumber.Location = new System.Drawing.Point(839, 117);
            this.btnAddPairNumber.Name = "btnAddPairNumber";
            this.btnAddPairNumber.Size = new System.Drawing.Size(198, 25);
            this.btnAddPairNumber.TabIndex = 28;
            this.btnAddPairNumber.Text = "Додати";
            this.btnAddPairNumber.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(836, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Кінець пари";
            // 
            // tbEndTime
            // 
            this.tbEndTime.Location = new System.Drawing.Point(839, 91);
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(198, 20);
            this.tbEndTime.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(836, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Початок пари";
            // 
            // tbStartTime
            // 
            this.tbStartTime.Location = new System.Drawing.Point(839, 40);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(198, 20);
            this.tbStartTime.TabIndex = 29;
            // 
            // btnAddFacultyName
            // 
            this.btnAddFacultyName.Location = new System.Drawing.Point(839, 602);
            this.btnAddFacultyName.Name = "btnAddFacultyName";
            this.btnAddFacultyName.Size = new System.Drawing.Size(198, 25);
            this.btnAddFacultyName.TabIndex = 33;
            this.btnAddFacultyName.Text = "Додати";
            this.btnAddFacultyName.UseVisualStyleBackColor = true;
            this.btnAddFacultyName.Click += new System.EventHandler(this.btnAddFacultyName_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(836, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Факультет";
            // 
            // tbFacultyName
            // 
            this.tbFacultyName.Location = new System.Drawing.Point(839, 558);
            this.tbFacultyName.Name = "tbFacultyName";
            this.tbFacultyName.Size = new System.Drawing.Size(198, 20);
            this.tbFacultyName.TabIndex = 31;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(260, 13);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(545, 333);
            this.dataGridViewUsers.TabIndex = 34;
            // 
            // dataGridViewAuditory
            // 
            this.dataGridViewAuditory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAuditory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuditory.Location = new System.Drawing.Point(260, 352);
            this.dataGridViewAuditory.Name = "dataGridViewAuditory";
            this.dataGridViewAuditory.Size = new System.Drawing.Size(545, 334);
            this.dataGridViewAuditory.TabIndex = 35;
            // 
            // dataGridViewPairNumber
            // 
            this.dataGridViewPairNumber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPairNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPairNumber.Location = new System.Drawing.Point(1085, 12);
            this.dataGridViewPairNumber.Name = "dataGridViewPairNumber";
            this.dataGridViewPairNumber.Size = new System.Drawing.Size(425, 164);
            this.dataGridViewPairNumber.TabIndex = 36;
            // 
            // dataGridViewLessonType
            // 
            this.dataGridViewLessonType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLessonType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLessonType.Location = new System.Drawing.Point(1085, 182);
            this.dataGridViewLessonType.Name = "dataGridViewLessonType";
            this.dataGridViewLessonType.Size = new System.Drawing.Size(425, 164);
            this.dataGridViewLessonType.TabIndex = 37;
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(1085, 352);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.Size = new System.Drawing.Size(425, 164);
            this.dataGridViewTeacher.TabIndex = 38;
            // 
            // dataGridViewFaculty
            // 
            this.dataGridViewFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaculty.Location = new System.Drawing.Point(1085, 522);
            this.dataGridViewFaculty.Name = "dataGridViewFaculty";
            this.dataGridViewFaculty.Size = new System.Drawing.Size(425, 164);
            this.dataGridViewFaculty.TabIndex = 39;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 731);
            this.Controls.Add(this.dataGridViewFaculty);
            this.Controls.Add(this.dataGridViewTeacher);
            this.Controls.Add(this.dataGridViewLessonType);
            this.Controls.Add(this.dataGridViewPairNumber);
            this.Controls.Add(this.dataGridViewAuditory);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnAddFacultyName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbFacultyName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.btnAddPairNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbEndTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownAuditoriumNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownFloor);
            this.Controls.Add(this.numericUpDownBuildingNumber);
            this.Controls.Add(this.btnAddAuditory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.btnAddLessonTypeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLessonTypeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuildingNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAuditoriumNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuditory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPairNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLessonTypeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddLessonTypeName;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.Button btnAddAuditory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownBuildingNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownFloor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownAuditoriumNumber;
        private System.Windows.Forms.Button btnAddPairNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEndTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.Button btnAddFacultyName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbFacultyName;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewAuditory;
        private System.Windows.Forms.DataGridView dataGridViewPairNumber;
        private System.Windows.Forms.DataGridView dataGridViewLessonType;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.DataGridView dataGridViewFaculty;
    }
}