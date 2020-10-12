using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    public class QuestionDB
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Answer { get; set; }
        public int Test { get; set; }
    }
}
