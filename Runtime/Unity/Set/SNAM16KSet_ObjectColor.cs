using UnityEngine;

public class SNAM16KSet_ObjectColor : SNAM_SetDebugGeneric16K<Color>
{
    public override Color GenerateRandomValue()
    {
        return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value,1f);
    }
}


