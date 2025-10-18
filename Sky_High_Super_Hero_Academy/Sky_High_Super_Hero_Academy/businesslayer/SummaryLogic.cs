using System;
using System.Collections.Generic;
using System.Linq;

namespace Sky_High_Super_Hero_Academy.BusinessLayer
{
    internal class SummaryData
    {
        public int TotalHeroes { get; set; }
        public double AverageAge { get; set; }
        public double AverageExamScore { get; set; }
        public int SRankCount { get; set; }
        public int ARankCount { get; set; }
        public int BRankCount { get; set; }
        public int CRankCount { get; set; }
    }

    internal class SummaryLogic
    {
        internal SummaryData CalculateSummary(List<Superhero> heroes)
        {
            SummaryData data = new SummaryData();

            if (heroes == null || heroes.Count == 0)
            {
                data.TotalHeroes = 0;
                data.AverageAge = 0;
                data.AverageExamScore = 0;
                data.SRankCount = 0;
                data.ARankCount = 0;
                data.BRankCount = 0;
                data.CRankCount = 0;
                return data;
            }

            data.TotalHeroes = heroes.Count;
            data.AverageAge = heroes.Average(h => h.Age);
            data.AverageExamScore = heroes.Average(h => h.ExamScore);

            // Rank values are set by Superhero.CalculateRank as "S-Rank", "A-Rank"
            data.SRankCount = heroes.Count(h => h.Rank == "S-Rank");
            data.ARankCount = heroes.Count(h => h.Rank == "A-Rank");
            data.BRankCount = heroes.Count(h => h.Rank == "B-Rank");
            data.CRankCount = heroes.Count(h => h.Rank == "C-Rank");

            return data;
        }

        internal string GenerateReport(List<Superhero> heroes)
        {
            var data = CalculateSummary(heroes ?? new List<Superhero>());

            return
                $@"=== HERO SUMMARY REPORT ===
                Total Number of Heroes: {data.TotalHeroes}
                Average Age: {data.AverageAge:F1}
                Average Exam Score: {data.AverageExamScore:F1}

                Number of Heroes per Rank:
                S-Rank: {data.SRankCount}
                A-Rank: {data.ARankCount}
                B-Rank: {data.BRankCount}
                C-Rank: {data.CRankCount}

                Generated On: {DateTime.Now}
                ================================
                ";
        }
    }
}
