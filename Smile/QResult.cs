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
        private int totalPositive;
        private int totalNegative;
        private int emot;

        public static QResult result;

        public string Id { get => id; set => id = value; }
        public string Userid { get => userid; set => userid = value; }
        public DateTime Date { get => date; set => date = value; }
        public MoodOverall Overall { get => overall; set => overall = value; }
        public MoodFrequency Frequency { get => frequency; set => frequency = value; }
        public MoodIntensity Intensity { get => intensity; set => intensity = value; }
        public MoodPersistence Persistence { get => persistence; set => persistence = value; }
        public string Suggest { get => suggest; set => suggest = value; }
        public int TotalPositive { get => totalPositive; set => totalPositive = value; }
        public int TotalNegative { get => totalNegative; set => totalNegative = value; }
        public int Emot { get => emot; set => emot = value; }

        public static string getSuggest()
        {
            int temp = 0;
            string suggestion = "test";
            string add = "";
            if (QResult.result.totalNegative > QResult.result.totalPositive)
            {
                suggestion = "Kondisi moodmu hari ini cukup buruk, ";
                temp = QResult.result.overall.Depressed;
                add = "kamu sepertinya cukup tertekan oleh beberapa hal";
                if (temp < QResult.result.frequency.Sad)
                {
                    temp = QResult.result.frequency.Sad;
                    add = "ada beberapa hal yang membuat kepikiran hingga membuatmu sedih";
                    if (temp < QResult.result.intensity.Afraid)
                    {
                        temp = QResult.result.intensity.Afraid;
                        add = "apakah ada beberapa hal yang membuatmu cemas atau takut?";
                        if (temp < QResult.result.persistence.Angry)
                        {
                            temp = QResult.result.persistence.Angry;
                            add = "emosimu hari ini kurang stabil, mungkin kamu perlu sedikit rileks";
                        }
                    }
                }
            }
            else
            {
                suggestion = "Kondisi moodmu hari ini cukup baik, ";
                temp = QResult.result.overall.Happy;
                add = "kamu telah menjalani harimu dengan ceria";
                if (temp < QResult.result.frequency.Excited)
                {
                    temp = QResult.result.frequency.Excited;
                    add = "hari ini sepertinya banyak yang membuatmu begitu terkesan dengan keseharian atau sekelilingmu, atau mungkin terkesan dengan dirimu sendiri";
                    if (temp < QResult.result.intensity.Enthusiastic)
                    {
                        temp = QResult.result.intensity.Enthusiastic;
                        add = "kamu hari ini cukup berenergi dan sepertinya berhasil menjalani hari dengan baik dan berani!";
                        if (temp < QResult.result.persistence.Proud)
                        {
                            temp = QResult.result.persistence.Proud;
                            add = "kamu telah menjalani harimu dengan tenang dan santai, kau menikmati harimu dengan baik";
                        }
                    }
                }
            }
            return suggestion+add;
        }
    }
}
