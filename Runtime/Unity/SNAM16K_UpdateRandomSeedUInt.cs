using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SNAM16K_UpdateRandomSeedUInt : StaticNativeArrayMono_Generic16K<uint> {


    public bool m_updateOnAwake = true;
    
    private bool m_test=true;
    private void Update()
    {
        if(m_test)
        {
            m_test = false;
            ChangeSeeds();
        }
        
    }
    [ContextMenu("Change Seeds")]
    public void ChangeSeeds() {

        var array = SNAM16K_UpdateRandomSeedUInt.I().GetNativeArray();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (uint)Random.Range(0, uint.MaxValue);
        }
    }

}
//TO D


