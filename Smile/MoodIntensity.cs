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

        public MoodIntensity()
        {
            Category = "MoodIntensity";
            Enthusiastic = 0;
            Afraid = 0;
        }

        public void addPoint(int point, string trait)
        {
            if (trait == "Positive")
            {
                if (point == 1)
                {
                    enthusiastic += 20;
                }
                else if (point == 2)
                {
                    enthusiastic += 15;
                    afraid += 5;
                }
                else if (point == 3)
                {
                    enthusiastic += 10;
                    afraid += 10;
                }
                else if (point == 4)
                {
                    enthusiastic += 5;
                    afraid += 15;
                }
                else if (point == 5)
                {
                    afraid += 20;
                }
            }

            if (trait == "Negative")
            {
                if (point == 1)
                {
                    afraid += 20;
                }
                else if (point == 2)
                {
                    afraid += 15;
                    enthusiastic += 5;
                }
                else if (point == 3)
                {
                    afraid += 10;
                    enthusiastic += 10;
                }
                else if (point == 4)
                {
                    afraid += 5;
                    enthusiastic += 15;
                }
                else if (point == 5)
                {
                    enthusiastic += 20;
                }
            }
        }
    }
}
