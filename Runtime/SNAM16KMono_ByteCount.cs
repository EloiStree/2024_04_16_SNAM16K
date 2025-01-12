using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class SNAM16KMono_ByteCount : MonoBehaviour
{

    public SNAM16K_ObjectUlong m_bytePerPlayer;

    public NativeArray<ulong> m_arrayRef;

    public void Start()
    {
        m_arrayRef = m_bytePerPlayer.GetNativeArrayHolder().GetNativeArray();
    }

    public void AddByteCount(int index,  ulong byteCount)
    {
        if(index< SNAM16K.ARRAY_MAX_SIZE)
        m_arrayRef[index] += byteCount;
    }
    public void AddByte(int index)
    {
        if (index < SNAM16K.ARRAY_MAX_SIZE)
            m_arrayRef[index]++;
    }

    public void AddIndexValueFourBytes(int indexSnam, int value)
    {
        if (indexSnam < SNAM16K.ARRAY_MAX_SIZE)
            m_arrayRef[indexSnam] += 4;
    }
    public void AddIndexValueFourBytes(int indexSnam)
    {
        if (indexSnam < SNAM16K.ARRAY_MAX_SIZE)
            m_arrayRef[indexSnam] += 4;
    }

}
