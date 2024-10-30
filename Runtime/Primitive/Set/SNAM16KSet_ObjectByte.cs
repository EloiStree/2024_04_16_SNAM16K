namespace Eloi.SNAM
{
    public class SNAM16KSet_ObjectByte : SNAM_SetDebugGeneric16K<byte>
    {
        public override byte GenerateRandomValue()
        {
            return (byte)UnityEngine.Random.Range(byte.MinValue, byte.MaxValue);
        }
    }


}