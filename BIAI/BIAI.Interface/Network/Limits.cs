namespace BIAI.Interface.Network
{
    public class Limits
    {
        public long? Low { get; set; }
        public long? High { get; set; }

        public Limits(long? low, long? high)
        {
            Low = low;
            High = high;
        }
    }
}
