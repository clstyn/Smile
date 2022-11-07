using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class Activity
    {
        public int actID { get; set; }
        public string actName { get; set; }
        public DateTime actDate { get; set; }
        public DateTime actTime { get; set; }
        public int actPriority { get; set; }
        public string actDesc { get; set; }
    }
}
