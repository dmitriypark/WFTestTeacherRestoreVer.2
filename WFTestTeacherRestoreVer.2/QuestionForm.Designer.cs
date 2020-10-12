namespace WFTestTeacherRestoreVer._2
{
    partial class QuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGradeName = new System.Windows.Forms.Label();
            this.lblGradeNumber = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.buttonAdd = new System.Windows.Forms.ToolStripButton();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestQuantityPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.No,
            this.TestId,
            this.TestName,
            this.SubjectId,
            this.SubjectName,
            this.GradeId,
            this.GradeNumber,
            this.Content,
            this.Answer,
            this.TestQuantity,
            this.TestQuantityPass});
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbTest
            // 
            resources.ApplyResources(this.cbTest, "cbTest");
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Name = "cbTest";
            this.cbTest.SelectionChangeCommitted += new System.EventHandler(this.cbTest_SelectionChangeCommitted);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblGradeName
            // 
            resources.ApplyResources(this.lblGradeName, "lblGradeName");
            this.lblGradeName.Name = "lblGradeName";
            // 
            // lblGradeNumber
            // 
            resources.ApplyResources(this.lblGradeNumber, "lblGradeNumber");
            this.lblGradeNumber.Name = "lblGradeNumber";
            // 
            // lblSubjectName
            // 
            resources.ApplyResources(this.lblSubjectName, "lblSubjectName");
            this.lblSubjectName.Name = "lblSubjectName";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Name = "panel1";
            // 
            // toolStrip2
            // 
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAdd,
            this.buttonDelete});
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // No
            // 
            resources.ApplyResources(this.No, "No");
            this.No.Name = "No";
            // 
            // TestId
            // 
            resources.ApplyResources(this.TestId, "TestId");
            this.TestId.Name = "TestId";
            // 
            // TestName
            // 
            resources.ApplyResources(this.TestName, "TestName");
            this.TestName.Name = "TestName";
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
            // GradeId
            // 
            resources.ApplyResources(this.GradeId, "GradeId");
            this.GradeId.Name = "GradeId";
            // 
            // GradeNumber
            // 
            resources.ApplyResources(this.GradeNumber, "GradeNumber");
            this.GradeNumber.Name = "GradeNumber";
            // 
            // Content
            // 
            this.Content.FillWeight = 200F;
            resources.ApplyResources(this.Content, "Content");
            this.Content.Name = "Content";
            // 
            // Answer
            // 
            resources.ApplyResources(this.Answer, "Answer");
            this.Answer.Name = "Answer";
            // 
            // TestQuantity
            // 
            resources.ApplyResources(this.TestQuantity, "TestQuantity");
            this.TestQuantity.Name = "TestQuantity";
            // 
            // TestQuantityPass
            // 
            resources.ApplyResources(this.TestQuantityPass, "TestQuantityPass");
            this.TestQuantityPass.Name = "TestQuantityPass";
            // 
            // QuestionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbTest);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGradeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGradeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "QuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGradeName;
        private System.Windows.Forms.Label lblGradeNumber;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton buttonAdd;
        private System.Windows.Forms.ToolStripButton buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestQuantityPass;
    }
}