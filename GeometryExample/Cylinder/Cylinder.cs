using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Cylinder
{
    public class Cylinder
    {
        private Double radius;
        private Double height;
        private Double BaseArea;
        private Double LateralArea;
        private Double TotalArea;
        private Double Volume;
        public Double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }
        public Double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public Cylinder() { }

        public Cylinder(float radius, float height) { }
        public void Process()
        {
            BaseArea = radius * radius * Math.PI  ;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (radius + height);
            Volume = Math.PI *radius *radius * height;
        }
        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + radius + ",Height: " + height);
            Console.WriteLine("Base: " + BaseArea + "- Lateral: " + LateralArea + "- Total: " + TotalArea + "- Volume: " + Volume);
        }
    }
}
