using System.ComponentModel.DataAnnotations.Schema;

namespace BIAI.Data.Model
{
    public class Country : ISystemDictionary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; private set; }
        public string Name { get; private set; }
    }
}
