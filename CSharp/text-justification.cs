using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    public class Solution
    {

        string ProcessLine(List<string> line, int counter, int maxWidth, bool isLast)
        {
            var sb = new StringBuilder();
            var extra = maxWidth - counter;

            if (line.Count == 0)
                return "";

            if (isLast || line.Count() == 1)
            {
                for (var i = 0; i < line.Count(); i++)
                {
                    sb.Append(line[i]);
                    if (i != line.Count() - 1)
                    {
                        sb.Append(" ");
                        extra--;
                    }
                }
                for (var i = 0; i < extra; i++)
                {
                    sb.Append(" ");
                }
            }
            else
            {
                var gaps = line.Count - 1;
                var filler = extra / gaps;
                var remainer = extra % gaps;

                for (var i = 0; i < line.Count; i++)
                {
                    sb.Append(line[i]);
                    if (i != line.Count() - 1)
                    {
                        for (var j = 0; j < filler; j++)
                        {
                            sb.Append(" ");
                        }

                        if (remainer > 0)
                        {
                            sb.Append(" ");
                            remainer--;
                        }
                    }
                }
            }
            return sb.ToString();
        }

        public IList<string> FullJustify(string[] words, int maxWidth)
        {

            var res = new List<string>();
            var line = new List<string>();
            var counter = 0;
            var spaceCounter = 0;

            for (var i = 0; i < words.Length; i++)
            {
                if (counter + spaceCounter + words[i].Length > maxWidth)
                {
                    var str = ProcessLine(line, counter, maxWidth, false);
                    res.Add(str);
                    line = new List<string>();
                    counter = 0;
                    spaceCounter = 0;
                }

                line.Add(words[i]);
                counter += words[i].Length;
                spaceCounter++;

                if (i == words.Length - 1)
                {
                    var str = ProcessLine(line, counter, maxWidth, i == words.Length - 1);
                    res.Add(str);
                }
            }

            return res;
        }
    }
}
