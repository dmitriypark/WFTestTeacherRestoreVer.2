namespace WFTestTeacherRestoreVer._2
{
    partial class GradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddGrade = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteGrade = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Number,
            this.gradeName});
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // Number
            // 
            resources.ApplyResources(this.Number, "Number");
            this.Number.Name = "Number";
            // 
            // gradeName
            // 
            resources.ApplyResources(this.gradeName, "gradeName");
            this.gradeName.Name = "gradeName";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddGrade,
            this.btnDeleteGrade});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnAddGrade
            // 
            resources.ApplyResources(this.btnAddGrade, "btnAddGrade");
            this.btnAddGrade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnDeleteGrade
            // 
            resources.ApplyResources(this.btnDeleteGrade, "btnDeleteGrade");
            this.btnDeleteGrade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteGrade.Name = "btnDeleteGrade";
            this.btnDeleteGrade.Click += new System.EventHandler(this.btnDeleteGrade_Click);
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // GradeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView);
            this.Name = "GradeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddGrade;
        private System.Windows.Forms.ToolStripButton btnDeleteGrade;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeName;
    }
}