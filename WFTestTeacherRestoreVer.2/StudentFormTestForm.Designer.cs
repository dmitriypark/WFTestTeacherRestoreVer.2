namespace WFTestTeacherRestoreVer._2
{
    partial class StudentFormTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFormTestForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SGrade = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.StudentAnswer,
            this.CorrectAnswer});
            this.dataGridView.Name = "dataGridView";
            // 
            // SGrade
            // 
            resources.ApplyResources(this.SGrade, "SGrade");
            this.SGrade.Name = "SGrade";
            // 
            // Sname
            // 
            resources.ApplyResources(this.Sname, "Sname");
            this.Sname.Name = "Sname";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Question
            // 
            resources.ApplyResources(this.Question, "Question");
            this.Question.Name = "Question";
            // 
            // StudentAnswer
            // 
            resources.ApplyResources(this.StudentAnswer, "StudentAnswer");
            this.StudentAnswer.Name = "StudentAnswer";
            // 
            // CorrectAnswer
            // 
            resources.ApplyResources(this.CorrectAnswer, "CorrectAnswer");
            this.CorrectAnswer.Name = "CorrectAnswer";
            // 
            // StudentFormTestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.SGrade);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentFormTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label SGrade;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectAnswer;
    }
}