using BIAI.Data.Model;
using BIAI.Network;
using System.Reflection;

namespace BIAI.Interface.Network
{
    public class InputInitializer
    {
        public double Max { get; private set; }
        public double Min { get; private set; }
        public PropertyInfo PropertyInfo { get; private set; }

        public InputInitializer(PropertyInfo propertyInfo, AttackRecord sampleRecord)
        {
            PropertyInfo = propertyInfo;
            Max = PropertyInfo.GetValue(sampleRecord).Convert<double>();
            Min = PropertyInfo.GetValue(sampleRecord).Convert<double>();
        }

        public void UpdateLimits(AttackRecord attackRecord)
        {
            var value = PropertyInfo.GetValue(attackRecord).Convert<double>();
            if (value > Max)
                Max = value;
            else if (value < Min)
                Min = value;
        }

        public double GetValue(AttackRecord attackRecord) => PropertyInfo.GetValue(attackRecord).Convert<double>().Normalize(Min, Max);
    }
}
