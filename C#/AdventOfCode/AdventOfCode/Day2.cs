using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day2
    {
        private string spreadsheet;

        public Day2(string spreadsheet)
        {
            this.spreadsheet = spreadsheet;
        }

        public int CalculateChecksumA()
        {
            string[] rows = spreadsheet.Split('\n');
            int output = 0;

            for(int i = 0; i < rows.Length; i++)
            {
                string row = rows[i];
                string[] numbers = row.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int largest = int.MinValue;
                int smallest = int.MaxValue;

                for(int o = 0; o < numbers.Length; o++)
                {
                    int number = int.Parse(numbers[o]);

                    if (number < smallest)
                        smallest = number;

                    if (number > largest)
                        largest = number;
                }

                output += largest - smallest;
            }

            return output;
        }

        public int CalculateChecksumB()
        {
            string[] rows = spreadsheet.Split('\n');
            int output = 0;

            for (int i = 0; i < rows.Length; i++)
            {
                string row = rows[i];
                string[] numbers = row.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                for (int o = 0; o < numbers.Length; o++)
                {
                    int number = int.Parse(numbers[o]);

                    for(int u = 0; u < numbers.Length; u++)
                    {
                        if (o == u)
                            continue;

                        int nextnumber = int.Parse(numbers[u]);
                        double remainder;

                        if (number > nextnumber)
                        {
                            remainder = number % nextnumber;

                            if (remainder > 0)
                                continue;

                            output += number / nextnumber;

                            break;
                        }

                        remainder = nextnumber % number;

                        if (remainder > 0)
                            continue;

                        output += number / nextnumber;
                        break;
                    }
                }
            }

            return output;
        }
    }
}
