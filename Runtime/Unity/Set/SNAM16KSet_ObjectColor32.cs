using UnityEngine;

public class SNAM16KSet_ObjectColor32 : SNAM_SetDebugGeneric16K<Color32>
{
    public override Color32 GenerateRandomValue()
    {
        return new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255),255);
    }
}


