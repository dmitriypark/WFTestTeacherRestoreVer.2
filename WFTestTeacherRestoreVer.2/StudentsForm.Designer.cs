namespace WFTestTeacherRestoreVer._2
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.cbTest = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chbTest = new System.Windows.Forms.CheckBox();
            this.chbSubject = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.chbGrade = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTest
            // 
            resources.ApplyResources(this.cbTest, "cbTest");
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Name = "cbTest";
            this.cbTest.SelectedIndexChanged += new System.EventHandler(this.cbTest_SelectedIndexChanged);
            // 
            // cbSubject
            // 
            resources.ApplyResources(this.cbSubject, "cbSubject");
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // cbName
            // 
            resources.ApplyResources(this.cbName, "cbName");
            this.cbName.FormattingEnabled = true;
            this.cbName.Name = "cbName";
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // cbGrade
            // 
            resources.ApplyResources(this.cbGrade, "cbGrade");
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grade,
            this.studentName,
            this.Subject,
            this.Test,
            this.Pass,
            this.taskId,
            this.DateStart});
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // chbTest
            // 
            resources.ApplyResources(this.chbTest, "chbTest");
            this.chbTest.Name = "chbTest";
            this.chbTest.UseVisualStyleBackColor = true;
            this.chbTest.CheckedChanged += new System.EventHandler(this.chbTest_CheckedChanged);
            // 
            // chbSubject
            // 
            resources.ApplyResources(this.chbSubject, "chbSubject");
            this.chbSubject.Name = "chbSubject";
            this.chbSubject.UseVisualStyleBackColor = true;
            this.chbSubject.CheckedChanged += new System.EventHandler(this.chbSubject_CheckedChanged);
            // 
            // chbName
            // 
            resources.ApplyResources(this.chbName, "chbName");
            this.chbName.Name = "chbName";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // chbGrade
            // 
            resources.ApplyResources(this.chbGrade, "chbGrade");
            this.chbGrade.Name = "chbGrade";
            this.chbGrade.UseVisualStyleBackColor = true;
            this.chbGrade.CheckedChanged += new System.EventHandler(this.chbGrade_CheckedChanged);
            // 
            // btnFilter
            // 
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Grade
            // 
            resources.ApplyResources(this.Grade, "Grade");
            this.Grade.Name = "Grade";
            // 
            // studentName
            // 
            resources.ApplyResources(this.studentName, "studentName");
            this.studentName.Name = "studentName";
            // 
            // Subject
            // 
            resources.ApplyResources(this.Subject, "Subject");
            this.Subject.Name = "Subject";
            // 
            // Test
            // 
            resources.ApplyResources(this.Test, "Test");
            this.Test.Name = "Test";
            // 
            // Pass
            // 
            resources.ApplyResources(this.Pass, "Pass");
            this.Pass.Name = "Pass";
            // 
            // taskId
            // 
            resources.ApplyResources(this.taskId, "taskId");
            this.taskId.Name = "taskId";
            // 
            // DateStart
            // 
            resources.ApplyResources(this.DateStart, "DateStart");
            this.DateStart.Name = "DateStart";
            // 
            // StudentsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTest);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chbTest);
            this.Controls.Add(this.chbSubject);
            this.Controls.Add(this.chbName);
            this.Controls.Add(this.chbGrade);
            this.Controls.Add(this.btnFilter);
            this.Name = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTest;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox chbTest;
        private System.Windows.Forms.CheckBox chbSubject;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.CheckBox chbGrade;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
    }
}