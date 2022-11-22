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

        public MoodPersistence()
        {
            Category = "MoodPersistence";
            Proud = 0;
            Angry = 0;
        }

        public void addPoint(int point, string trait)
        {
            if (trait == "Positive")
            {
                if (point == 1)
                {
                    proud += 20;
                }
                else if (point == 2)
                {
                    proud += 15;
                    angry += 5;
                }
                else if (point == 3)
                {
                    proud += 10;
                    angry += 10;
                }
                else if (point == 4)
                {
                    proud += 5;
                    angry += 15;
                }
                else if (point == 5)
                {
                    angry += 20;
                }
            }

            if (trait == "Negative")
            {
                if (point == 1)
                {
                    angry += 20;
                }
                else if (point == 2)
                {
                    angry += 15;
                    proud += 5;
                }
                else if (point == 3)
                {
                    angry += 10;
                    proud += 10;
                }
                else if (point == 4)
                {
                    angry += 5;
                    proud += 15;
                }
                else if (point == 5)
                {
                    proud += 20;
                }
            }
        }
    }
}
