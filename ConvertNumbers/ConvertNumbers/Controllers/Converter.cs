using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConvertNumbers.Models;

namespace ConvertNumbers.Controllers
{
    public class Converter
    {
        private DBFunctions dbFunctions;

        public Converter(NumbersContext database)
        {
            this.dbFunctions = new DBFunctions(database);
        }       

        private string getHundredString(double number)
        {
            String result = String.Empty;

            if (number > 0)
            {
                double hundreds = number / 100;
                double truncatedHundreds = Math.Truncate(hundreds);
                if (truncatedHundreds > 0)
                {
                    result += this.dbFunctions.GetWordByNumber(truncatedHundreds);
                    result += " " + this.dbFunctions.GetWordByNumber(100) + (truncatedHundreds > 1 ? "s" : "");
                }
                double afterPoint2 = Math.Round((hundreds - truncatedHundreds) * 100);
                if (afterPoint2 <= 19)
                {
                    result += " " + this.dbFunctions.GetWordByNumber(afterPoint2);
                }
                else
                {
                    double tens = afterPoint2 / 10;
                    result += " " + this.dbFunctions.GetWordByNumber(Math.Truncate(tens) * 10);
                    double afterPoint3 = (tens - Math.Truncate(tens)) * 10;
                    if (afterPoint3 > 0)
                    {
                        result += " " + this.dbFunctions.GetWordByNumber(Math.Round(afterPoint3));
                    }
                }
            }
            return result;
        }

        public string ConvertValue(double value)
        {
            List<String> words = new List<String>();
            int rankStep = 0;
            double mainPower;
            do
            {
                rankStep += 3;
                mainPower = Math.Pow(10, rankStep);
                double devidedByMainPower = value / mainPower;
                double truncated = Math.Truncate(devidedByMainPower);
                double hundreds = (devidedByMainPower - truncated) * 1000;
                if (hundreds != 0)
                    words.Insert(0, getHundredString(hundreds));

                if (truncated >= 1)
                    words.Insert(0, this.dbFunctions.GetWordByNumber(mainPower) + (truncated > 1 ? "s" : ""));
                value = truncated * mainPower;
            }
            while (value > 1);

            String result = String.Empty;
            for (int i = 0; i < words.Count; ++i)
            {
                result += words[i] + " ";
            }
            return result.Trim();
        }
    }
}