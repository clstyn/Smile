using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class SchedulePlan
    {
        public int planID { get; set; }
        public int[] planListAct { get; set; }
        public DateTime planDate { get; set; }
        public string planDesc { get; set; }
    }
}
