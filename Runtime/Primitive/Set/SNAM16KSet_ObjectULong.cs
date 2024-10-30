namespace Eloi.SNAM
{
    public class SNAM16KSet_ObjectULong : SNAM_SetDebugGeneric16K<ulong>
    {
        public override ulong GenerateRandomValue()
        {
            return (ulong)UnityEngine.Random.Range(ulong.MinValue, ulong.MaxValue);
        }
    }


}