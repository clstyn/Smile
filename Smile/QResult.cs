using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class QResult
    {
        private string id;
        private string userid;
        private DateTime date;
        private MoodOverall overall;
        private MoodFrequency frequency;
        private MoodIntensity intensity;
        private MoodPersistence persistence;
        private string suggest;

        public static QResult result;

        public string Id { get => id; set => id = value; }
        public string Userid { get => userid; set => userid = value; }
        public DateTime Date { get => date; set => date = value; }
        public MoodOverall Overall { get => overall; set => overall = value; }
        public MoodFrequency Frequency { get => frequency; set => frequency = value; }
        public MoodIntensity Intensity { get => intensity; set => intensity = value; }
        public MoodPersistence Persistence { get => persistence; set => persistence = value; }
        public string Suggest { get => suggest; set => suggest = value; }

        public static string getSuggest()
        {
            string suggestion = "test";

            return suggestion;
        }
    }
}
