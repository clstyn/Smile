using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class Mood
    {
        private string status;
        private string category;
        private string totalPoint;

        public string Status { get => status; set => status = value; }
        public string Category { get => category; set => category = value; }
        public string TotalPoint { get => totalPoint; set => totalPoint = value; }
    }
}
