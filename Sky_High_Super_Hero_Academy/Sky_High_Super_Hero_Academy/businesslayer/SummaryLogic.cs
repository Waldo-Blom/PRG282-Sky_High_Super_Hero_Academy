using System;
using System.Collections.Generic;
using System.Linq;

namespace Sky_High_Super_Hero_Academy.BusinessLayer
{
    public class Hero
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double ExamScore { get; set; }
        public string Rank { get; set; }
        public string ThreatLevel { get; set; }
    }

    public class SummaryLogic
    {
        public string GenerateReport(List<Hero> heroes)
        {
            int total = heroes.Count;
            double avgAge = heroes.Any() ? heroes.Average(h => h.Age) : 0;
            double avgScore = heroes.Any() ? heroes.Average(h => h.ExamScore) : 0;

            int sRank = heroes.Count(h => h.Rank == "S");
            int aRank = heroes.Count(h => h.Rank == "A");
            int bRank = heroes.Count(h => h.Rank == "B");
            int cRank = heroes.Count(h => h.Rank == "C");

            return
$@"=== HERO SUMMARY REPORT ===
Total Number of Heroes: {total}
Average Age: {avgAge:F1}
Average Exam Score: {avgScore:F1}

Number of Heroes per Rank:
S-Rank: {sRank}
A-Rank: {aRank}
B-Rank: {bRank}
C-Rank: {cRank}

Generated On: {DateTime.Now}
================================
";
        }
    }
}
