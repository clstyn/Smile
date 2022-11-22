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

        public MoodOverall()
        {
            Category = "MoodOverall";
            Happy = 0;
            Depressed = 0;
        }

        public void addPoint(int point, string trait)
        {
            if(trait == "Positive")
            {
                if(point==1)
                {
                    happy += 20;
                }
                else if(point==2)
                {
                    happy += 15;
                    depressed += 5;
                }
                else if(point == 3)
                {
                    happy += 10;
                    depressed += 10;
                }
                else if(point == 4)
                {
                    happy += 5;
                    depressed += 15;
                }
                else if(point == 5)
                {
                    depressed += 20;
                }
            }

            if (trait == "Negative")
            {
                if (point == 1)
                {
                    depressed += 20;
                }
                else if (point == 2)
                {
                    depressed += 15;
                    happy += 5;
                }
                else if (point == 3)
                {
                    depressed += 10;
                    happy += 10;
                }
                else if (point == 4)
                {
                    depressed += 5;
                    happy += 15;
                }
                else if (point == 5)
                {
                    happy += 20;
                }
            }
        }
    }
}
