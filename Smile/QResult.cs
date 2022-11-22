using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class QResult
    {
        public int qrID { get; set; }
        public int qrTotalPoint { get; set; }
        public int[] qrDetailPoint { get; set; }
        public DateTime qrDate { get; set; }
        public string qrDesc { get; set; }
    }
}
