using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Y4S2Week5___Reading_Person_Data
{
    class DataReading2 : IReading
    {
        public string Text => "Name = <Name>; Height = <Height>; Age = <Age>;";

        public List<object[]> GetData(StreamReader sr)
        {
            List<object[]> lst = new List<object[]>();
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                line = Regex.Replace(line, @"Name=", "");
                line = Regex.Replace(line, @"Age=", "");
                line = Regex.Replace(line, @"Height=", "");
                lst.Add(line.Split(';'));
            }
            return lst;
        }
    }
}
