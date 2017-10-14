using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightPlanner
{
    class Licht : Objecten
    {
        Vector3 Location;       //relative to Connector
        Vector3 Direction;      //relative to Zaal
        int Intensity;          //Candela
        Color Color;            //related to intesity???

        public Licht()
        {

        }
    }
}
