using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace hcrrank
{
    public class Result
    {
        public static List<string> bitPattern(List<int> num)
        {
            List<string> results = new List<string>();
            List<string> results1 = new List<string>();
            List<string> results3 = new List<string>();

            for (int i = 0; i < num.Count; i++)
            {
                List<int> beforeNumbers = num.GetRange(0, i);
                List<int> afterNumbers = num.GetRange(i + 1, num.Count - 1 - i);

                bool beforeFlag = beforeNumbers.Contains( num[i]);
                bool afterFlag = afterNumbers.Contains( num[i]);
                if (beforeNumbers.Count!=0)
                {
                    results.Add((beforeFlag ? '1' : '0').ToString());
                    results1.Add((afterFlag ? '1' : '0').ToString());
                }
                 



            }
                results3.Add(string.Join("", results) + "\n" + string.Join("", results1));
            return results3;
        }


    }
}
