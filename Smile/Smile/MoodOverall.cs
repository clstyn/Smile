using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class MoodOverall: Mood
    {
        private int happy;
        private int depressed;

        public int Happy { get => happy; set => happy = value; }
        public int Depressed { get => depressed; set => depressed = value; }
    }
}
