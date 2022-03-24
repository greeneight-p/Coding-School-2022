namespace Session_15 {
    partial class ProductDetailsForm {
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.grdProductCats = new DevExpress.XtraGrid.GridControl();
            this.grvProductCats = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.bsProductCategories = new System.Windows.Forms.BindingSource(this.components);
            this.textEditCode = new DevExpress.XtraEditors.TextEdit();
            this.Code = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditDescription = new DevExpress.XtraEditors.TextEdit();
            this.Description = new DevExpress.XtraLayout.LayoutControlItem();
            this.calcEditCost = new DevExpress.XtraEditors.CalcEdit();
            this.Cost = new DevExpress.XtraLayout.LayoutControlItem();
            this.calcEditPrice = new DevExpress.XtraEditors.CalcEdit();
            this.Price = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductCats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.calcEditPrice);
            this.layoutControl1.Controls.Add(this.calcEditCost);
            this.layoutControl1.Controls.Add(this.textEditDescription);
            this.layoutControl1.Controls.Add(this.textEditCode);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.grdProductCats);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(776, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(776, 22);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdProductCats
            // 
            this.grdProductCats.Location = new System.Drawing.Point(12, 108);
            this.grdProductCats.MainView = this.grvProductCats;
            this.grdProductCats.Name = "grdProductCats";
            this.grdProductCats.Size = new System.Drawing.Size(776, 284);
            this.grdProductCats.TabIndex = 8;
            this.grdProductCats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProductCats});
            // 
            // grvProductCats
            // 
            this.grvProductCats.GridControl = this.grdProductCats;
            this.grvProductCats.Name = "grvProductCats";
            this.grvProductCats.OptionsBehavior.Editable = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.Code,
            this.Description,
            this.Cost,
            this.Price});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 282);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnClose;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 404);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 378);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // textEditCode
            // 
            this.textEditCode.Location = new System.Drawing.Point(77, 12);
            this.textEditCode.Name = "textEditCode";
            this.textEditCode.Size = new System.Drawing.Size(711, 20);
            this.textEditCode.StyleController = this.layoutControl1;
            this.textEditCode.TabIndex = 11;
            // 
            // Code
            // 
            this.Code.Control = this.textEditCode;
            this.Code.Location = new System.Drawing.Point(0, 0);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(780, 24);
            this.Code.TextSize = new System.Drawing.Size(53, 13);
            // 
            // textEditDescription
            // 
            this.textEditDescription.Location = new System.Drawing.Point(77, 36);
            this.textEditDescription.Name = "textEditDescription";
            this.textEditDescription.Size = new System.Drawing.Size(711, 20);
            this.textEditDescription.StyleController = this.layoutControl1;
            this.textEditDescription.TabIndex = 12;
            // 
            // Description
            // 
            this.Description.Control = this.textEditDescription;
            this.Description.Location = new System.Drawing.Point(0, 24);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(780, 24);
            this.Description.TextSize = new System.Drawing.Size(53, 13);
            // 
            // calcEditCost
            // 
            this.calcEditCost.Location = new System.Drawing.Point(77, 60);
            this.calcEditCost.Name = "calcEditCost";
            this.calcEditCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditCost.Size = new System.Drawing.Size(711, 20);
            this.calcEditCost.StyleController = this.layoutControl1;
            this.calcEditCost.TabIndex = 13;
            // 
            // Cost
            // 
            this.Cost.Control = this.calcEditCost;
            this.Cost.Location = new System.Drawing.Point(0, 48);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(780, 24);
            this.Cost.TextSize = new System.Drawing.Size(53, 13);
            // 
            // calcEditPrice
            // 
            this.calcEditPrice.Location = new System.Drawing.Point(77, 84);
            this.calcEditPrice.Name = "calcEditPrice";
            this.calcEditPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditPrice.Size = new System.Drawing.Size(711, 20);
            this.calcEditPrice.StyleController = this.layoutControl1;
            this.calcEditPrice.TabIndex = 14;
            // 
            // Price
            // 
            this.Price.Control = this.calcEditPrice;
            this.Price.Location = new System.Drawing.Point(0, 72);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(780, 24);
            this.Price.TextSize = new System.Drawing.Size(53, 13);
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ProductDetailsForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductCats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl grdProductCats;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProductCats;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private BindingSource bsProduct;
        private BindingSource bsProductCategories;
        private DevExpress.XtraEditors.CalcEdit calcEditPrice;
        private DevExpress.XtraEditors.CalcEdit calcEditCost;
        private DevExpress.XtraEditors.TextEdit textEditDescription;
        private DevExpress.XtraEditors.TextEdit textEditCode;
        private DevExpress.XtraLayout.LayoutControlItem Code;
        private DevExpress.XtraLayout.LayoutControlItem Description;
        private DevExpress.XtraLayout.LayoutControlItem Cost;
        private DevExpress.XtraLayout.LayoutControlItem Price;
    }
}