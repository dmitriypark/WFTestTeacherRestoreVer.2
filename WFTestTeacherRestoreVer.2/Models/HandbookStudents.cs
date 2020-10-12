using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    public class HandbookStudents
    {
        public int userId { get; set; }
        public string gradeNumberName { get; set; }
        public string userName { get; set; }
        public string subject { get; set; }
        public string test { get; set; }
        public int testId { get; set; }
        public int taskSum { get; set; }
        public int taskPas { get; set; }
        public int taskId { get; set; }
        public Nullable<DateTime> taskStart { get; set; } = null;
    }
}
