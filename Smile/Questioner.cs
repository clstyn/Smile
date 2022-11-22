using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class Questioner
    {
        private int id;
        private string question;
        private string category;
        private int[] point;

        public int ID { get => id; set => id = value; }
        public string Question { get => question; set => question = value; }
        public string Category { get => category; set => category = value; }
        public int[] Point { get => point; set => point = value; }
    }
}
