using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y4S2Week5___Reading_Person_Data
{
    interface IReading
    {
        string Text { get; }
        List<object[]> GetData(StreamReader sr);
    }
}