using UnityEngine;

namespace DroneIMMO
{
    public class SNAM16KSet_ObjectInteger : SNAM_SetDebugGeneric16K<int>
    {
        public override int GenerateRandomValue()
        {
            return UnityEngine.Random.Range(int.MinValue, int.MaxValue);
        }
    }


}