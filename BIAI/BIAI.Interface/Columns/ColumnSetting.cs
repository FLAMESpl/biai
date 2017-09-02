using System.Reflection;

namespace BIAI.Interface.Columns
{
    public class ColumnSetting
    {
        public string Name { get; private set; }
        public bool Selected { get; set; }
        public PropertyInfo PropertyInfo { get; private set; }

        public ColumnSetting(PropertyInfo propertyInfo, bool selected)
        {
            Name = propertyInfo.Name;
            Selected = selected;
            PropertyInfo = propertyInfo;
        }
    }
}
