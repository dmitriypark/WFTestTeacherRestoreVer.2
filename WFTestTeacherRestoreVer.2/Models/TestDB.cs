using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    public class TestDB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Subject { get; set; }
        public int Quantity { get; set; }
        public int QuantityPass { get; set; }
    }
}
