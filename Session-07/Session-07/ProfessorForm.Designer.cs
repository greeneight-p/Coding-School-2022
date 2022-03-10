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
            this.textBoxProfScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxProfScreen
            // 
            this.textBoxProfScreen.Location = new System.Drawing.Point(114, 120);
            this.textBoxProfScreen.Name = "textBoxProfScreen";
            this.textBoxProfScreen.Size = new System.Drawing.Size(335, 20);
            this.textBoxProfScreen.TabIndex = 0;
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxProfScreen);
            this.Name = "ProfessorForm";
            this.Text = "Professor Screen";
            this.Load += new System.EventHandler(this.ProfessorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProfScreen;
    }
}