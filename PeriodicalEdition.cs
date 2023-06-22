using System;
using System.Text;

namespace Homework12
{
    public class PeriodicalEdition : Edition
    {
        
        public int Issue { get; set; }
        public string Publisher { get; set; } 
        public readonly int ISSN;
        public int Price = 0;

        public PeriodicalEdition(string name, int year, int issue)
        {
            Name = name;
            Year = year;
            Issue = issue;
        }

        public override string GetInfo()
        {
            var result = new StringBuilder();
            result.Append($"Название: {Name}. Год: {Year}. Выпуск: {Issue}. Цена: {Price}. " +
                          $"Тип: {GetEditionTypeName()}.");
            if (Publisher != default)
                result.Append($" Издатель: {Publisher}.");
            if (ISSN != 0)
                result.Append($" ISSN: {ISSN}.");
            return result.ToString();
        }
    }
}