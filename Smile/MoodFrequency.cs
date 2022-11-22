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
    }
}
