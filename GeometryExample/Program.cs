
using GeometryExample.Animal;
using GeometryExample.Cylinder;
using System;
Cylinder c = new Cylinder();
c.Radius = 38.64;
c.Height = 22.48;
c.Process();
c.Result();
Lion l = new Lion();
l.SetMe("Lion", 200);
Tiger t = new Tiger();
l.SetMe("Tiger", 100);
l.Show();
t.Show();


