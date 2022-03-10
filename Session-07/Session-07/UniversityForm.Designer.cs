namespace Session_07 {
    partial class UniversityForm {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditScreen = new DevExpress.XtraEditors.TextEdit();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonShowProfessors = new System.Windows.Forms.Button();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditScreen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootToolStripMenuItem,
            this.professorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rootToolStripMenuItem
            // 
            this.rootToolStripMenuItem.Name = "rootToolStripMenuItem";
            this.rootToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.rootToolStripMenuItem.Text = "Root";
            // 
            // professorsToolStripMenuItem
            // 
            this.professorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem});
            this.professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            this.professorsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.professorsToolStripMenuItem.Text = "Professors";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // textEditScreen
            // 
            this.textEditScreen.Location = new System.Drawing.Point(12, 200);
            this.textEditScreen.Name = "textEditScreen";
            this.textEditScreen.Size = new System.Drawing.Size(766, 20);
            this.textEditScreen.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 282);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(93, 282);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonShowProfessors
            // 
            this.buttonShowProfessors.Location = new System.Drawing.Point(175, 281);
            this.buttonShowProfessors.Name = "buttonShowProfessors";
            this.buttonShowProfessors.Size = new System.Drawing.Size(75, 23);
            this.buttonShowProfessors.TabIndex = 7;
            this.buttonShowProfessors.Text = "Professors";
            this.buttonShowProfessors.UseVisualStyleBackColor = true;
            this.buttonShowProfessors.Click += new System.EventHandler(this.buttonShowProfessors_Click);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(274, 281);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(504, 157);
            this.textBoxShow.TabIndex = 8;
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.buttonShowProfessors);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textEditScreen);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UniversityForm";
            this.Text = "University";
            this.Load += new System.EventHandler(this.UniversityForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditScreen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorsToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit textEditScreen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Button buttonShowProfessors;
        private System.Windows.Forms.TextBox textBoxShow;
    }
}

