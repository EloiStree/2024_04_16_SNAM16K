
using UnityEngine;

public class SNAM_GetDebugGeneric16K<T> :
    MonoBehaviour
     where T : struct
{

    public SNAM_Generic16KMono<T> m_targetSNAM;

    public T[] m_arrayFetched= new T[10];
    public bool m_useUpdateFetch=true;

    private void Update()
    {
        if(m_useUpdateFetch)
            Fetch();
    }

    [ContextMenu("Fetch")]
    public void Fetch()
    {

        if (m_targetSNAM != null)
        {
            for (int i = 0; i < m_arrayFetched.Length; i++)
            {
                m_arrayFetched[i]= m_targetSNAM.Get(i);
            }
        }

    }

    public T this[int index]
    {
        get { return m_targetSNAM[index]; }
        set { m_targetSNAM[index] = value; }
    }


    //private void Reset()
    //{
    //    m_targetSNAM = (StaticNativeArrayMono_Generic16K<T>)GetComponent(typeof(StaticNativeArrayMono_Generic16K<T>));
    //}

}