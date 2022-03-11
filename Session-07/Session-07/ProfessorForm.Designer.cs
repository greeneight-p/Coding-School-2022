namespace Session_07 {
    partial class ProfessorForm {
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
            this.listBoxProfStorage = new System.Windows.Forms.ListBox();
            this.labelProfessors = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.labelCourses = new System.Windows.Forms.Label();
            this.buttonRevertFrontEnd = new System.Windows.Forms.Button();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProfStorage
            // 
            this.listBoxProfStorage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBoxProfStorage.FormattingEnabled = true;
            this.listBoxProfStorage.ItemHeight = 19;
            this.listBoxProfStorage.Location = new System.Drawing.Point(12, 37);
            this.listBoxProfStorage.Name = "listBoxProfStorage";
            this.listBoxProfStorage.Size = new System.Drawing.Size(221, 403);
            this.listBoxProfStorage.TabIndex = 0;
            this.listBoxProfStorage.SelectedIndexChanged += new System.EventHandler(this.listBoxProfStorage_SelectedIndexChanged);
            // 
            // labelProfessors
            // 
            this.labelProfessors.AutoSize = true;
            this.labelProfessors.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelProfessors.Location = new System.Drawing.Point(7, 5);
            this.labelProfessors.Name = "labelProfessors";
            this.labelProfessors.Size = new System.Drawing.Size(112, 29);
            this.labelProfessors.TabIndex = 1;
            this.labelProfessors.Text = "Professors";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelName.Location = new System.Drawing.Point(270, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelAge.Location = new System.Drawing.Point(286, 136);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(39, 23);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age";
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelRank.Location = new System.Drawing.Point(277, 179);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(48, 23);
            this.labelRank.TabIndex = 4;
            this.labelRank.Text = "Rank";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxName.Location = new System.Drawing.Point(331, 85);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 31);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.textBoxAge.Location = new System.Drawing.Point(331, 133);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(35, 31);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxRank
            // 
            this.textBoxRank.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.textBoxRank.Location = new System.Drawing.Point(331, 176);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(123, 31);
            this.textBoxRank.TabIndex = 7;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelID.Location = new System.Drawing.Point(297, 40);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 23);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxID.Location = new System.Drawing.Point(331, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(442, 31);
            this.textBoxID.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonDelete.Location = new System.Drawing.Point(708, 348);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 43);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(627, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonSave.Location = new System.Drawing.Point(627, 397);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 43);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonCancel.Location = new System.Drawing.Point(708, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 43);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 19;
            this.listBoxCourses.Location = new System.Drawing.Point(331, 227);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(123, 213);
            this.listBoxCourses.TabIndex = 14;
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCourses.Location = new System.Drawing.Point(253, 227);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(72, 23);
            this.labelCourses.TabIndex = 15;
            this.labelCourses.Text = "Courses";
            // 
            // buttonRevertFrontEnd
            // 
            this.buttonRevertFrontEnd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonRevertFrontEnd.Location = new System.Drawing.Point(627, 299);
            this.buttonRevertFrontEnd.Name = "buttonRevertFrontEnd";
            this.buttonRevertFrontEnd.Size = new System.Drawing.Size(156, 43);
            this.buttonRevertFrontEnd.TabIndex = 16;
            this.buttonRevertFrontEnd.Text = "Revert(Fake?)";
            this.buttonRevertFrontEnd.UseVisualStyleBackColor = true;
            this.buttonRevertFrontEnd.Click += new System.EventHandler(this.buttonRevertFrontEnd_Click);
            // 
            // buttonRevert
            // 
            this.buttonRevert.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonRevert.Location = new System.Drawing.Point(627, 250);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(156, 43);
            this.buttonRevert.TabIndex = 17;
            this.buttonRevert.Text = "RevertLastSave";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRevert);
            this.Controls.Add(this.buttonRevertFrontEnd);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelProfessors);
            this.Controls.Add(this.listBoxProfStorage);
            this.Name = "ProfessorForm";
            this.Text = "Professor Screen";
            this.Load += new System.EventHandler(this.ProfessorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProfStorage;
        private System.Windows.Forms.Label labelProfessors;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.Button buttonRevertFrontEnd;
        private System.Windows.Forms.Button buttonRevert;
    }
}