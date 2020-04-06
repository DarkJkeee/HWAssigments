using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CsvParser
{
    public class CsvReader
    {
        // field for delimiter in csv file.
        private char delimiter;
        // Checker for new line symbols.
        private char[] newLine = new char[] { '\r', '\n' };
        public CsvReader(char delimiter)
        {
            this.delimiter = delimiter;
        }
        public CsvReader()
        {
            delimiter = ';';
        }
        /// <summary>
        /// Method which creates stream and read csv file.
        /// </summary>
        /// <param name="path">Path which consist csv.</param>
        /// <returns></returns>
        public string[][] ReadLines(string path)
        {
            using (StreamReader stream = new StreamReader(path))
            {
                return ReadLines(stream);
            }
        }
        /// <summary>
        /// Method which creates array of units.
        /// </summary>
        /// <param name="sr">Stream with csv file.</param>
        /// <returns></returns>
        private string[][] ReadLines(StreamReader sr)
        {
            var lines = new List<string[]>();

            while (!sr.EndOfStream)
            {
                lines.Add(ReadLine(sr));
            }
            return lines.ToArray();
        }
        /// <summary>
        /// Method which creates array with one unit.
        /// </summary>
        /// <param name="sr"></param>
        /// <returns></returns>
        private string[] ReadLine(StreamReader sr)
        {
            List<string> line = new List<string>();

            while (!sr.EndOfStream)
            {
                (var field, var lastInLine) = ReadField(sr);

                line.Add(field);

                if (lastInLine)
                {
                    break;
                }
            }
            return line.ToArray();
        }
        /// <summary>
        /// Method which check one field in csv file.
        /// </summary>
        /// <param name="sr"></param>
        /// <returns></returns>
        private (string, bool) ReadField(StreamReader sr)
        {
            bool shielding = false;
            string field = "";

            while (!sr.EndOfStream)
            {
                char current = (char)sr.Read();
                char next = (char)sr.Peek();

                if (current == '"' && field.Length == 0)
                {
                    shielding = true;
                    continue;
                }

                if (shielding == true)
                {
                    if (current == '"' && next == '"')
                    {
                        sr.Read();
                    }
                    else if (current == '"')
                    {
                        shielding = false;
                        continue;
                    }
                    field += current;
                }
                else
                {
                    if (newLine.Contains(current) || current == delimiter || sr.EndOfStream)
                    {
                        if (newLine.Contains(current))
                        {
                            sr.Read();
                        }
                        if (sr.EndOfStream)
                        {
                            field += current;
                        }
                        return (field, newLine.Contains(current) || sr.EndOfStream);
                    }
                    else
                    {
                        field += current;
                    }
                }
            }
            return (string.Empty, true);
        }
    }
}
