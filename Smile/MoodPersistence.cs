using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class MoodPersistence:Mood
    {
        private int proud;
        private int angry;

        public int Proud { get => proud; set => proud = value; }
        public int Angry { get => angry; set => angry = value; }
    }
}
