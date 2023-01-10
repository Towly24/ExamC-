using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Animal
{
    internal class Lion : Animal
    {
        public Lion() { }
        public override void SetMe(string name, int weight)
        {
            this.Name= name;
            this.Weight= weight;
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + Name + ", Weight: " + Weight);
        }
    }
}
