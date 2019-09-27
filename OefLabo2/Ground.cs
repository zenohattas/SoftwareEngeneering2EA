using System;
using System.Collections.Generic;
using System.Text;

namespace OefLabo2
{
    class Ground
    {
        public void drawGround()
        {
            for(int i = 0; i < Console.WindowWidth; i++)
            {
                Draw.draw(i, 30, '_');
            }
        }
    }
}
