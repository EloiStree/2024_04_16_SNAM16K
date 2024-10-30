using System;
using System.Numerics;

namespace Eloi.SNAM
{
    public class SNAM16K_ObjectInt : SNAM_Generic16KMono<int>
    {

        [UnityEngine.ContextMenu("Random Int Big Number")]
        public void RandomIntBigNumber()
        {
            Random random = new Random((int) DateTime.Now.Ticks*10000);

            int lenght = SNAM16K.ARRAY_MAX_SIZE;
            
            for (int i = 0; i < lenght; i++)
            {
                Set(i, random.Next(int.MaxValue/20, int.MaxValue));
            }
        }
    }
}


