using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day1
    {
        public int InverseCaptchaA(string puzzle)
        {
            int output = 0;

            for(int i = 0; i < puzzle.Length; i++)
            {
                if (i == puzzle.Length - 1)
                {
                    if (puzzle[i] == puzzle[0])
                        output += int.Parse(puzzle[i].ToString());

                    break;
                }

                if (puzzle[i] == puzzle[i + 1])
                    output += int.Parse(puzzle[i].ToString());
            } 

            return output;
        }

        public int InverseCaptchaB(string puzzle)
        {
            int output = 0;
            int index = puzzle.Length / 2;

            for(int i = 0; i < puzzle.Length; i++)
            {
                if(i + index >= puzzle.Length)
                {
                    int newindex = (i + index) - puzzle.Length;

                    if (puzzle[i] == puzzle[newindex])
                        output += int.Parse(puzzle[i].ToString());

                    continue;
                }

                if(puzzle[i] == puzzle[index + i])
                    output += int.Parse(puzzle[i].ToString());
            }

            return output;
        }
    }
}
