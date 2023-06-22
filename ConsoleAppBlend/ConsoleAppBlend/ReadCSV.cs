using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBlend
{
    public static class ReadCSV
    {
        public static void ReadFormula(string path)
        {
            // V = Variety
            // R = Ratio
            List<string> V = new List<string>();
            List<double> R = new List<double>();

            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    R.Add(double.Parse(fields[0]));
                    V.Add(fields[1]);
                }

                if (R.Sum() != 1)
                {
                    throw new Exception("Sum of ratios must be 1");
                }
            }

            WineBlending.SetFormula(V.ToArray(), R.ToArray());
        }

        public static void ReadTanks(string path)
        {
            List<string> V = new List<string>();
            List<double> R = new List<double>();

            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    WineBlending.SetTanks(1, int.Parse(fields[0]), fields[1]);
                }
            }
        }
    }
}
