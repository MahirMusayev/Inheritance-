using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_task
{
    internal class Laptop :Device
    {
        public int PortCount;
        public Laptop(double width, double height, double weight,int portcount):base(width,height,weight)
        {
            PortCount = portcount;  
        }
    }
}
