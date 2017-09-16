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

        public InputInitializer(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
            Max = double.MinValue;
            Min = double.MaxValue;
        }

        public void UpdateLimits(AttackRecord attackRecord)
        {
            var value = PropertyInfo.GetValue(attackRecord)?.Convert<double>();
            if (value == null)
                return;

            if (value > Max)
                Max = value.Value;
            else if (value < Min)
                Min = value.Value;
        }

        public double? TryGetValue(AttackRecord attackRecord) => TryGetValue(PropertyInfo.GetValue(attackRecord));

        public double? TryGetValue(object obj) => obj == null ? (double?)null : Normalize(obj.Convert<double>());

        public double Normalize(double value) => value.Normalize(value < Min ? value : Min, value > Max ? value : Max);
    }
}
