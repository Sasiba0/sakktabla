using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sakktabla
{
    internal class tile : PictureBox
    {
        public int i {  get; set; }
        public int j { get; set; }
        public bool feher {  get; set; }

        public tile(int x, int y)
        {
            i = x;
            j = y;
        }
    }
    
}
