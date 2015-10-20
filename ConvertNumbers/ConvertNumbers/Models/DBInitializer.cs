using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ConvertNumbers.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<NumbersContext>
    {
        protected override void Seed(NumbersContext db)
        {
            db.BasicNumbers.Add(new BasicNumbers() { Number = 0, Word = "zero" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 1, Word = "one" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 2, Word = "two" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 3, Word = "three" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 4, Word = "four" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 5, Word = "five" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 6, Word = "six" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 7, Word = "seven" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 8, Word = "eight" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 9, Word = "nine" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 10, Word = "ten" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 11, Word = "eleven" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 12, Word = "twelve" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 13, Word = "thirteen" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 14, Word = "fourteen" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 15, Word = "fifteen" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 16, Word = "sixteen" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 17, Word = "seventeen" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 18, Word = "eighteen" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 19, Word = "nineteen" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 20, Word = "twenty" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 30, Word = "thirty" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 40, Word = "forty" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 50, Word = "fifty" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 60, Word = "sixty" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 70, Word = "seventy" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 80, Word = "eighty" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 90, Word = "ninety" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 100, Word = "hundred" });
            db.BasicNumbers.Add(new BasicNumbers() { Number = 1000, Word = "thousand" });
            base.Seed(db);
        }
    }
}