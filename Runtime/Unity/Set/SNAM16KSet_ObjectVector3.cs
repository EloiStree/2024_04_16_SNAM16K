using UnityEngine;

namespace Eloi.SNAM
{
    public class SNAM16KSet_ObjectVector3 : SNAM_SetDebugGeneric16K<Vector3>
    {
        public override Vector3 GenerateRandomValue()
        {
            return new Vector3(UnityEngine.Random.value * float.MaxValue, UnityEngine.Random.value * float.MaxValue, UnityEngine.Random.value * float.MaxValue);
        }
    }


}