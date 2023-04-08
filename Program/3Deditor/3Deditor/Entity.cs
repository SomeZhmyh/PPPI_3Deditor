using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Deditor
{
    public class Entity
    {
        public float x;
        public float y;
        public float z;
        public string color;
        public string shape;

        Entity(float x, float y, float z, string color, string shape)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.color = color;
            this.shape = shape;
        }

        Entity()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
            this.color = "white";
            this.shape = "cube";
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetShape(string shape)
        {
            this.shape = shape;
        }
    }
}
