using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Playground.Code_Katas.Function
{
    public static class CSVTab
    {
        public static IEnumerable<string> Run(List<string> input)
        {
            var numberOfHeadings = input[0].Split(';');

            var maxColumnWidth = new int[input.Count];
            var lines = new List<string[]>();
            //for each input line
            for (int i = 0; i < input.Count(); i++)
            {
                //for each column get the width and find max width
                var columns = input[i].Split(';');
                lines.Add(columns);

                for (int j = 0; j < columns.Length; j++)
                {
                    maxColumnWidth[j] = Math.Max(maxColumnWidth[j], columns[j].Length);
                }
            }

            //generate output
            var result = new List<string>();
            /*
           *Name         |Strasse         |Ort          |Alter|
            -------------+----------------+-------------+-----+
            Peter Pan    |Am Hang 5       |12345 Einsam |42   |
            Maria Schmitz|Kölner Straße 45|50123 Köln   |43   |
            Paul Meier   |Münchener Weg 1 |87654 München|65   |
             */
            //genrate header
            result.Add(string.Join('|', lines[0].Select((l, i) => l.PadRight(maxColumnWidth[i], ' ')))+'|');
            //generate divider line
            result.Add(string.Join('+', maxColumnWidth.Select(i => "".PadRight(i, '-'))) + '+');

            for (int i = 1; i < lines.Count; i++)
            {
                result.Add(string.Join('|', lines[i].Select((l, j) => l.PadRight(maxColumnWidth[j], ' '))) + '|');
            }

            return result;
        }
    }
}