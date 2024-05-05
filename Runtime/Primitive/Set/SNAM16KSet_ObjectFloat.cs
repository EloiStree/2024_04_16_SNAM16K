namespace DroneIMMO
{
    public class SNAM16KSet_ObjectFloat : SNAM_SetDebugGeneric16K<float>
    {
        public override float GenerateRandomValue()
        {
            return UnityEngine.Random.Range(float.MinValue, float.MaxValue);
        }
    }


}