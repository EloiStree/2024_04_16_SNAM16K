namespace Eloi.SNAM
{
    public class SNAM16KSet_ObjectLong : SNAM_SetDebugGeneric16K<long>
    {
        public override long GenerateRandomValue()
        {
            return (long)UnityEngine.Random.Range(long.MinValue, long.MaxValue);
        }
    }


}