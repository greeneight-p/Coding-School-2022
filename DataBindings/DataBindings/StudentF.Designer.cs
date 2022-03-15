namespace DataBindings {
    partial class StudentF {
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
            this.components = new System.ComponentModel.Container();
            this.gridStudents = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRegNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.bsCourses = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlCourses = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Courses = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStudents
            // 
            this.gridStudents.Location = new System.Drawing.Point(12, 53);
            this.gridStudents.MainView = this.gridView1;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.Size = new System.Drawing.Size(364, 371);
            this.gridStudents.TabIndex = 0;
            this.gridStudents.UseEmbeddedNavigator = true;
            this.gridStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnAge,
            this.gridColumnRegNum});
            this.gridView1.GridControl = this.gridStudents;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            // 
            // gridColumnAge
            // 
            this.gridColumnAge.Caption = "Age";
            this.gridColumnAge.FieldName = "Age";
            this.gridColumnAge.Name = "gridColumnAge";
            this.gridColumnAge.Visible = true;
            this.gridColumnAge.VisibleIndex = 1;
            // 
            // gridColumnRegNum
            // 
            this.gridColumnRegNum.Caption = "Reg Number";
            this.gridColumnRegNum.FieldName = "RegNum";
            this.gridColumnRegNum.Name = "gridColumnRegNum";
            this.gridColumnRegNum.Visible = true;
            this.gridColumnRegNum.VisibleIndex = 2;
            // 
            // gridControlCourses
            // 
            this.gridControlCourses.Location = new System.Drawing.Point(388, 136);
            this.gridControlCourses.MainView = this.gridView2;
            this.gridControlCourses.Name = "gridControlCourses";
            this.gridControlCourses.Size = new System.Drawing.Size(400, 288);
            this.gridControlCourses.TabIndex = 1;
            this.gridControlCourses.UseEmbeddedNavigator = true;
            this.gridControlCourses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCode,
            this.gridColumnSubject});
            this.gridView2.GridControl = this.gridControlCourses;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Code";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            // 
            // gridColumnSubject
            // 
            this.gridColumnSubject.Caption = "Subject";
            this.gridColumnSubject.FieldName = "Subject";
            this.gridColumnSubject.Name = "gridColumnSubject";
            this.gridColumnSubject.Visible = true;
            this.gridColumnSubject.VisibleIndex = 1;
            // 
            // Courses
            // 
            this.Courses.AutoSize = true;
            this.Courses.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Courses.Location = new System.Drawing.Point(388, 107);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(78, 26);
            this.Courses.TabIndex = 3;
            this.Courses.Text = "Courses";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(12, 24);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(64, 26);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "label1";
            // 
            // StudentF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.gridControlCourses);
            this.Controls.Add(this.gridStudents);
            this.Name = "StudentF";
            this.Text = "StudentF";
            this.Load += new System.EventHandler(this.StudentF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BindingSource bsStudents;
        private BindingSource bsCourses;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAge;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegNum;
        private DevExpress.XtraGrid.GridControl gridControlCourses;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSubject;
 
        private Label Courses;
        private Label labelID;
    }
}