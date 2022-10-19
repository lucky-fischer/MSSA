using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrotVisualizer
{
    internal interface ISortEngine
    {
        void DoWork(int[] TheArray, Graphics g, int MaxVal);
    }
}
