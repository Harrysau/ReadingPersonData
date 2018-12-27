using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y4S2Week5___Reading_Person_Data
{
    public class Person
    {
        private string name;
        private int age;
        private double height;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public double Height { get { return height; } set { height = value; } }

        public Person(object[] obj)
        {
            Name = (string) obj[0];
            Age = int.Parse(obj[1].ToString());
            Height = double.Parse(obj[2].ToString());

        }
    }
}
