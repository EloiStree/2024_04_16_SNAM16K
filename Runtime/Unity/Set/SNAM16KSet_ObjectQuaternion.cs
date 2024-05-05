using UnityEngine;

namespace DroneIMMO
{
    public class SNAM16KSet_ObjectQuaternion : SNAM_SetDebugGeneric16K<Quaternion>
    {
        public override Quaternion GenerateRandomValue()
        {
            return Quaternion.Euler(UnityEngine.Random.value * 360f, UnityEngine.Random.value * 360f, UnityEngine.Random.value * 360f);
        }
    }


}