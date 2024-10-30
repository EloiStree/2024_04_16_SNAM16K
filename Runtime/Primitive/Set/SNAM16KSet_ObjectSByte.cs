namespace Eloi.SNAM
{
    public class SNAM16KSet_ObjectSByte : SNAM_SetDebugGeneric16K<sbyte>
    {
        public override sbyte GenerateRandomValue()
        {
            return (sbyte)UnityEngine.Random.Range(sbyte.MinValue, sbyte.MaxValue);
        }
    }


}