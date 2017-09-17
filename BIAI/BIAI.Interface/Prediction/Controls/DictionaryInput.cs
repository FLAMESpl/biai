using BIAI.Data;
using BIAI.Data.Model;
using BIAI.Data.Model.Annotations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BIAI.Interface.Prediction.Controls
{
    public partial class DictionaryInput : ComboBox, IInputProvider
    {
        public string InputName { get; private set; }
        public string DictionaryName { get; private set; }
        private Dictionary<int, long> dictionaryMapping = new Dictionary<int, long>();

        public DictionaryInput(string name, Dictionary dictionaryData)
        {
            InitializeComponent();

            DropDownStyle = ComboBoxStyle.DropDownList;
            InputName = name;
            DictionaryName = name.Substring(0, name.Length - 2);

            using (var db = new GlobalTerrorismContext())
            {
                var type = typeof(ISystemDictionary).Assembly.GetType($"BIAI.Data.Model.{DictionaryName}");
                var tableName = typeof(GlobalTerrorismContext).GetProperties().Single(x => CheckForDbSet(x, type)).Name;

                foreach (var entry in db.Set(type).SqlQuery($"SELECT * FROM {tableName}").Cast<ISystemDictionary>())
                {
                    var ind = Items.Add(entry.Name);
                    dictionaryMapping.Add(ind, entry.Id);
                }
            }
        }

        public object GetInputValue()
        {
            return dictionaryMapping[SelectedIndex];
        }

        private bool CheckForDbSet(PropertyInfo propertyInfo, Type type)
        {
            var generic = propertyInfo.PropertyType.GetGenericArguments().SingleOrDefault();
            return generic == null ? false : generic == type;
        }
    }
}
