
using UnityEngine;

namespace Eloi.SNAM
{
    public class SNAM16KGet_ObjectFloat : SNAM_GetDebugGeneric16K<float> {

        public void SetAllToValue(float value) { 
        
        
            for (int i = 0; i < SNAM16K.ARRAY_MAX_SIZE; i++)
            {
                this[i] = value;
            }
        }


        [ContextMenu("Set All 1")]
        public void SetAllToOne() { 
        
        
            for (int i = 0; i < SNAM16K.ARRAY_MAX_SIZE; i++)
            {
                this[i] = 1;
            }
        }
        [ContextMenu("Set All 0")]
        public void SetAllToZero() { 
        
        
            for (int i = 0; i < SNAM16K.ARRAY_MAX_SIZE; i++)
            {
                this[i] = 0;
            }
        }
    }


    //[System.Serializable]
    //public struct IndexToIndexInteger
    //{
    //    public int m_index;
    //    public int m_value;
    //}
    //[System.Serializable]
    //public struct IndexToUlong
    //{
    //    public int m_index;
    //    public ulong m_value;
    //}
}