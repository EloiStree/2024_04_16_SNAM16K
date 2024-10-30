namespace Eloi.SNAM
{
    public class SNAM16KSet_ObjectUInt : SNAM_SetDebugGeneric16K<uint>
    {
        public override uint GenerateRandomValue()
        {
            return (uint)UnityEngine.Random.Range(uint.MinValue, uint.MaxValue);
        }
    }


}