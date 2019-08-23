using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quaver_Music_Code_Test.Models
{
    public class Preamble
    {
        public static string preamble = "We the People of the United States, in Order to form a more perfect Union, establish Justice, insure domestic Tranquility, provide for the common defence, promote the general Welfare, and secure the Blessings of Liberty to ourselves and our Posterity, do ordain and establish this Constitution for the United States of America.";

        /*  returns counts of how many words begin with 't' */
        public static int StartsWithT()
        {

            string[] preambleArr = preamble.ToLower().Split(' ');

            var queryResults =
                from w in preambleArr
                /* filter through the preamble array for words that start with t*/
                where w.StartsWith("t")
                select w;

            var numberOfTs = 0;

            /* count the words selected by the filter  */
            foreach (var item in queryResults)
            {
                numberOfTs ++;
            }

            return numberOfTs;
        }


        /* returns counts of how many words end with 'e' */
        public static int EndsWithE()
        {
            string[] preambleArr = preamble.ToLower().Split(' ');

            var queryResults =
                from w in preambleArr
                /* filter through the preamble array for words that end with e*/
                where w.EndsWith("e")
                select w;

            var numberOfEs = 0;

            /* count the words selected by the filter */
            foreach (var item in queryResults)
            {
                numberOfEs++;
            }

            return numberOfEs;
        }

        /* returns counts of how many words begin with 't' and end with 'e' */
        public static int StartsWithTEndsWithE()
        {
            string[] preambleArr = preamble.ToLower().Split(' ');

            var queryResults =
                from w in preambleArr
                /* filter through the preamble array for words that end with 'e' and start with 't'*/
                where w.EndsWith("e") &&
                      w.StartsWith("t")
                select w;

            var numberOfTEs = 0;
            /* count the words selected by the filter */
            foreach (var item in queryResults)
            {
                numberOfTEs++;
            }

            return numberOfTEs;
        }
    }
}
