using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Grade

    {
        public static char CalculateGrade(int score)
        {
            if (score >= 70 && score <= 100)
            {
                return 'a';
            }
            else if (score >= 60)
            {
                return 'b';
            }
            else if (score >= 50)
            {
                return 'c';
            }
            else if (score >= 40)
            {
                return 'd';

            }
            else
            {
                return 'f';
            }
        }
    }
}

