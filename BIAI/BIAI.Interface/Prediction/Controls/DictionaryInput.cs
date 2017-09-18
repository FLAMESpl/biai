using BIAI.Data;
using BIAI.Data.Model;
using BIAI.Data.Model.Annotations;
using System.Collections.Generic;
using System.Linq;
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
                var query = db.Set(dictionaryData.Type).SqlQuery($"SELECT * FROM {dictionaryData.TableName}");
                foreach (var entry in query.Cast<ISystemDictionary>())
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
    }
}
