using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightPlanner
{
    public class Zaal
    {
        Vector3 Size;

        public Zaal(float length, float width, float height)
        {
            Size = new Vector3(length, width, height);

            Objecten Podium = new Objecten();
        }
    }
}
