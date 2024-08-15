using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SNAM16K_UpdateRandomSeedUInt : SNAM_Generic16KMono<uint> {


    public bool m_updateOnAwake = true;
    
    public bool m_refreshSeedWithUpdate=true;
    private new void Awake()
    {
        base.Awake();
        if(m_updateOnAwake)
            ChangeSeeds();
    }
    private void Update()
    {
        if(m_refreshSeedWithUpdate)
        {
            m_refreshSeedWithUpdate = false;
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


