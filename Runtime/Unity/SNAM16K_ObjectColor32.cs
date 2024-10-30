using UnityEngine;

public class SNAM16K_ObjectColor32 : SNAM_Generic16KMono<Color32>
{


    [ContextMenu("Random Color")]
    public void RandomColor()
    {
        int lenght = SNAM16K.ARRAY_MAX_SIZE;
        for (int i = 0; i < lenght; i++)
        {
            Set(i, new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255));
        }
    }
}



