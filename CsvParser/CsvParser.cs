using System;
using System.Linq;

namespace CsvParser
{
    public static class Parser
    {
        /// <summary>
        /// Method which check all data and delete wrong strings.
        /// </summary>
        /// <param name="data">Origin data.</param>
        /// <returns></returns>
        public static string[][] CsvParser(string[][] data)
        {
            string[] header = data[0];
            var datalist = data.ToList<string[]>();
            int j = 1;
            int i;
            for (i = 1; i < datalist.Count; ++i)
            {
                try
                {
                    for (j = 1; j < header.Length; ++j)
                    {
                        if (datalist[i][j] == "")
                        {
                            datalist[i][j] = "0";
                        }
                        else
                        {
                            int.Parse(datalist[i][j]);
                        }
                    }
                }
                catch (FormatException)
                {
                    if (!(header[j] == "Reload" && datalist[i][j] == "infinity"))
                    {
                        datalist.RemoveAt(i);
                        i--;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    datalist.RemoveAt(i);
                    i--;
                }
                if (datalist[i].Length != header.Length)
                {
                    datalist.RemoveAt(i);
                    i--;
                }
            }
            return datalist.ToArray();
        }
    }
}
