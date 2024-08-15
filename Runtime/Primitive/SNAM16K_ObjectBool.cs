
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
    public void SetAllToFalse()
    {
        SetAllTo(false);
    }
    public void SetAllToTrue()
    {
        SetAllTo(true);
    }
}
