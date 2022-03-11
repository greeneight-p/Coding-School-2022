namespace Session_07 {
    partial class StudentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelCourses = new System.Windows.Forms.Label();
            this.listBoxStudentCourses = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxRegNum = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelRegBum = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStudents = new System.Windows.Forms.Label();
            this.listBoxStudentStorage = new System.Windows.Forms.ListBox();
            this.listBoxAvailableCourses = new System.Windows.Forms.ListBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCourses.Location = new System.Drawing.Point(258, 230);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(72, 23);
            this.labelCourses.TabIndex = 33;
            this.labelCourses.Text = "Courses";
            // 
            // listBoxStudentCourses
            // 
            this.listBoxStudentCourses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBoxStudentCourses.FormattingEnabled = true;
            this.listBoxStudentCourses.ItemHeight = 19;
            this.listBoxStudentCourses.Location = new System.Drawing.Point(336, 230);
            this.listBoxStudentCourses.Name = "listBoxStudentCourses";
            this.listBoxStudentCourses.Size = new System.Drawing.Size(123, 213);
            this.listBoxStudentCourses.TabIndex = 32;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonCancel.Location = new System.Drawing.Point(719, 139);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 43);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonSave.Location = new System.Drawing.Point(719, 91);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 43);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonNew.Location = new System.Drawing.Point(638, 91);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 43);
            this.buttonNew.TabIndex = 29;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonDelete.Location = new System.Drawing.Point(638, 140);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 43);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxID.Location = new System.Drawing.Point(336, 40);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(442, 31);
            this.textBoxID.TabIndex = 27;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelID.Location = new System.Drawing.Point(302, 43);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 23);
            this.labelID.TabIndex = 26;
            this.labelID.Text = "ID";
            // 
            // textBoxRegNum
            // 
            this.textBoxRegNum.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.textBoxRegNum.Location = new System.Drawing.Point(336, 179);
            this.textBoxRegNum.Name = "textBoxRegNum";
            this.textBoxRegNum.Size = new System.Drawing.Size(123, 31);
            this.textBoxRegNum.TabIndex = 25;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.textBoxAge.Location = new System.Drawing.Point(336, 136);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(35, 31);
            this.textBoxAge.TabIndex = 24;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxName.Location = new System.Drawing.Point(336, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 31);
            this.textBoxName.TabIndex = 23;
            // 
            // labelRegBum
            // 
            this.labelRegBum.AutoSize = true;
            this.labelRegBum.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelRegBum.Location = new System.Drawing.Point(255, 182);
            this.labelRegBum.Name = "labelRegBum";
            this.labelRegBum.Size = new System.Drawing.Size(75, 23);
            this.labelRegBum.TabIndex = 22;
            this.labelRegBum.Text = "RegNum";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelAge.Location = new System.Drawing.Point(291, 139);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(39, 23);
            this.labelAge.TabIndex = 21;
            this.labelAge.Text = "Age";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelName.Location = new System.Drawing.Point(275, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 23);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name";
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelStudents.Location = new System.Drawing.Point(12, 8);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(100, 29);
            this.labelStudents.TabIndex = 19;
            this.labelStudents.Text = "Students";
            // 
            // listBoxStudentStorage
            // 
            this.listBoxStudentStorage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBoxStudentStorage.FormattingEnabled = true;
            this.listBoxStudentStorage.ItemHeight = 19;
            this.listBoxStudentStorage.Location = new System.Drawing.Point(17, 40);
            this.listBoxStudentStorage.Name = "listBoxStudentStorage";
            this.listBoxStudentStorage.Size = new System.Drawing.Size(221, 403);
            this.listBoxStudentStorage.TabIndex = 18;
            this.listBoxStudentStorage.SelectedIndexChanged += new System.EventHandler(this.listBoxStudentStorage_SelectedIndexChanged);
            // 
            // listBoxAvailableCourses
            // 
            this.listBoxAvailableCourses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBoxAvailableCourses.FormattingEnabled = true;
            this.listBoxAvailableCourses.ItemHeight = 19;
            this.listBoxAvailableCourses.Location = new System.Drawing.Point(489, 230);
            this.listBoxAvailableCourses.Name = "listBoxAvailableCourses";
            this.listBoxAvailableCourses.Size = new System.Drawing.Size(123, 213);
            this.listBoxAvailableCourses.TabIndex = 34;
            this.listBoxAvailableCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxAvailableCourses_SelectedIndexChanged);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonAddCourse.Location = new System.Drawing.Point(638, 400);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(156, 43);
            this.buttonAddCourse.TabIndex = 35;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(618, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Available Courses";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.listBoxAvailableCourses);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.listBoxStudentCourses);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxRegNum);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelRegBum);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.listBoxStudentStorage);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.ListBox listBoxStudentCourses;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxRegNum;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelRegBum;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.ListBox listBoxStudentStorage;
        private System.Windows.Forms.ListBox listBoxAvailableCourses;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Label label1;
    }
}