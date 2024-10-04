
using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;



public class SNAM16K {

    public static int ARRAY_MAX_SIZE = 128 * 128;


}

public class NativeArrayRefHolder <T> where T :struct {
    public NativeArray<T> m_nativeArray;

    public T this[int index]
    {
        get { return m_nativeArray[index]; }
        set { m_nativeArray[index] = value; }
    }

    public void Dispose()
    {
        if (m_nativeArray.IsCreated)
            m_nativeArray.Dispose();
    }

    public NativeArray<T> GetNativeArray()
    {
        return m_nativeArray;
    }
}

public  class SNAM_Generic16KMono<T>: 
        MonoBehaviour where T : struct
    {
        public static Dictionary<string, NativeArrayRefHolder<T>> m_globalNativeArray = new Dictionary<string, NativeArrayRefHolder<T>>();
        public static int ARRAY_MAX_SIZE = 128 * 128;
        public static SNAM_Generic16KMono<T> m_instanceInScene;

        public static SNAM_Generic16KMono<T> I()
        {
           return m_instanceInScene;
            
        }

        public string GetStringId() {
            return m_guid;
        }
        public NativeArrayRefHolder<T> GetNativeArrayHolder()
        {
            if (!m_globalNativeArray.ContainsKey(GetStringId()))
                Create();
            return m_globalNativeArray[GetStringId()];
        }

  
       

        [Tooltip("Represent what is store")]
        public T m_sample;
        public string m_guid;
         public void Reset()
        {
            Guid guid = Guid.NewGuid();
            m_guid = guid.ToString();
        }
        public virtual void Awake()
        {
            m_guid = Guid.NewGuid().ToString();
            m_instanceInScene = this;
            // Debug.Log("Created SNAM " + this.GetType(), this.gameObject);
            Destroy();
            Create();
        }
        public virtual void OnDestroy()
        {
           // Debug.Log("Destroy SNAM " + this.GetType(), this.gameObject);
            Destroy();
        }


        public  void Create()
        {
        //           Debug.Log("Create SNAM >>>" + GetStringId(), this.gameObject);


            if (m_globalNativeArray.ContainsKey(GetStringId())) { 
                        m_guid= Guid.NewGuid().ToString();
            }
            if (!m_globalNativeArray.ContainsKey(GetStringId()))
                m_globalNativeArray.Add(GetStringId(),new NativeArrayRefHolder<T> {
               m_nativeArray= new NativeArray<T>(ARRAY_MAX_SIZE, Allocator.Persistent)
                } );

            
        }

        public  void Get(int index, out T valueInArray)
        {
            valueInArray = GetNativeArrayHolder()[index];
        }
        public  T Get(int index)
        {
            return GetNativeArrayHolder()[index];
        }
        public  void Set(int index, T valueInArray)
        {
            var array = GetNativeArrayHolder();
            array[index] = valueInArray;
        }
        public   void Destroy()
        {

            if (m_globalNativeArray.ContainsKey(GetStringId()))
            {
                m_globalNativeArray[GetStringId()].Dispose();
                m_globalNativeArray.Remove(GetStringId());
            }

            NativeArrayRefHolder<T> nativeArray = GetNativeArrayHolder();
            if (nativeArray != null)
                nativeArray.Dispose();
        }
    public int GetLength()
        {
            return SNAM16K.ARRAY_MAX_SIZE;
        }

    public T this[int index]
    {
        get { return Get(index); }
        set { Set(index, value); }
    }
}
