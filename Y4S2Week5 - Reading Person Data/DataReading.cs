using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y4S2Week5___Reading_Person_Data
{
    class DataReading : IReading
    {
        public string Text => "<Name>;<Age>;<Height>";
        public List<object[]> GetData(StreamReader sr)
        {
            List<object[]> lst = new List<object[]>();
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                lst.Add(line.Split(';'));
            }
            return lst;
        }
    }
}
