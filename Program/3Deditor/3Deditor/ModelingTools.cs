using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Deditor
{
    internal class ModelingTools
    {
        
        public void Move(Entity obj, float x, float y, float z)
        {
            obj.x += x;
            obj.y += y;
            obj.z += z;
        }

        public void Rotate(Entity obj, float x, float y)
        {
            obj.x += x;
            obj.y -= y;
        }

        public void Scale(Entity obj)
        {
            // scaling
        }

        public void Bevel(Entity obj)
        {
            // beveling
        }

        public void Extrude(Entity obj)
        {
            // extruding
        }

        public void Cut(Entity obj)
        {
            // cutting
        }
    }
}
