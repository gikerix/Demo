using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertNumbers.Models
{
    public class DBFunctions
    {
        private NumbersContext database;

        public DBFunctions(NumbersContext database)
        {
            this.database = database;
        }

        public string GetWordByNumber(double number)
        {
            var query = from Numbers in this.database.BasicNumbers
                        where Numbers.Number == number
                        select Numbers.Word;

            foreach (var res in query)
                return res.ToString();
            return string.Empty;
        }
    }
}