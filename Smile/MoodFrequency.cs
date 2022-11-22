using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class MoodFrequency: Mood
    {
        private int excited;
        private int sad;

        public int Excited { get => excited; set => excited = value; }
        public int Sad { get => sad; set => sad = value; }

        public MoodFrequency()
        {
            Category = "MoodFrequency";
            Excited = 0;
            Sad = 0;
        }

        public void addPoint(int point, string trait)
        {
            if (trait == "Positive")
            {
                if (point == 1)
                {
                    excited += 20;
                }
                else if (point == 2)
                {
                    excited += 15;
                    sad += 5;
                }
                else if (point == 3)
                {
                    excited += 10;
                    sad += 10;
                }
                else if (point == 4)
                {
                    excited += 5;
                    sad += 15;
                }
                else if (point == 5)
                {
                    sad += 20;
                }
            }

            if (trait == "Negative")
            {
                if (point == 1)
                {
                    sad += 20;
                }
                else if (point == 2)
                {
                    sad += 15;
                    excited += 5;
                }
                else if (point == 3)
                {
                    sad += 10;
                    excited += 10;
                }
                else if (point == 4)
                {
                    sad += 5;
                    excited += 15;
                }
                else if (point == 5)
                {
                    excited += 20;
                }
            }
        }
    }
}
