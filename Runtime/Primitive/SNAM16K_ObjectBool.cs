
using System;
using UnityEngine;

public class SNAM16K_ObjectBool : SNAM_Generic16KMono<bool>
{
   

    public void SetAllTo(bool value)
    {
        for (int i = 0; i < GetLength(); i++)
        {
            this[i] = value;
        }
    }
    [ContextMenu("Set all false")]
    public void SetAllToFalse()
    {
        SetAllTo(false);    
    }
    [ContextMenu("Set all true")]
    public void SetAllToTrue()
    {
        SetAllTo(true);
    }
}
