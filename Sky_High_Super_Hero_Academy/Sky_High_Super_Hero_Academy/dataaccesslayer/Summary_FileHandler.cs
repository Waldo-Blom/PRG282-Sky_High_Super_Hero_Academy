using System;
using System.Collections.Generic;
using System.IO;
using Sky_High_Super_Hero_Academy.BusinessLayer;

namespace Sky_High_Super_Hero_Academy.DataAccessLayer
{
    public class Summary_FileHandler
    {
        private readonly string summaryFile = "summary.txt";

        private string GetSummaryFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, summaryFile);
        }

        public void SaveSummary(string summaryReport)
        {
            var path = GetSummaryFilePath();
            Directory.CreateDirectory(Path.GetDirectoryName(path) ?? AppDomain.CurrentDomain.BaseDirectory);
            File.AppendAllText(path, summaryReport);
        }
    }
}
