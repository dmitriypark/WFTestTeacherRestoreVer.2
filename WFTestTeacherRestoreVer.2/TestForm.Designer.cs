namespace WFTestTeacherRestoreVer._2
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDelete});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GradeName,
            this.GradeNumber,
            this.GradeId,
            this.testName,
            this.SubjectId,
            this.SubjectName,
            this.Quantity,
            this.QuantityPass});
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // GradeName
            // 
            resources.ApplyResources(this.GradeName, "GradeName");
            this.GradeName.Name = "GradeName";
            // 
            // GradeNumber
            // 
            resources.ApplyResources(this.GradeNumber, "GradeNumber");
            this.GradeNumber.Name = "GradeNumber";
            // 
            // GradeId
            // 
            resources.ApplyResources(this.GradeId, "GradeId");
            this.GradeId.Name = "GradeId";
            // 
            // testName
            // 
            resources.ApplyResources(this.testName, "testName");
            this.testName.Name = "testName";
            // 
            // SubjectId
            // 
            resources.ApplyResources(this.SubjectId, "SubjectId");
            this.SubjectId.Name = "SubjectId";
            // 
            // SubjectName
            // 
            resources.ApplyResources(this.SubjectName, "SubjectName");
            this.SubjectName.Name = "SubjectName";
            // 
            // Quantity
            // 
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.Name = "Quantity";
            // 
            // QuantityPass
            // 
            resources.ApplyResources(this.QuantityPass, "QuantityPass");
            this.QuantityPass.Name = "QuantityPass";
            // 
            // TestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TestForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn testName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPass;
    }
}