using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class MoodIntensity : Mood 
    {
        private int enthusiastic;
        private int afraid;

        public int Enthusiastic { get => enthusiastic; set => enthusiastic = value; }
        public int Afraid { get => afraid; set => afraid = value; }
    }
}
