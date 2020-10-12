using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    public class HandbookStudentTest
    {
        public int TaskID { get; set; }
        public string QuestionContent { get; set; }
        public int StudentAnswer { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
