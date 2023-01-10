using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Animal
{
    public abstract class Animal
    {
        private string name;
        private int weight;
        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int Weight
        {
            get { return this.Weight; }
            set { this.Weight = value; }
        }
        public Animal() { }
        public abstract void SetMe(string name, int weight);
        public abstract void Show();
    }
}
