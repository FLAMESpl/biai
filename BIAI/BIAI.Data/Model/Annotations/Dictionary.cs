using System;

namespace BIAI.Data.Model.Annotations
{
    public class Dictionary : Attribute
    {
        public string TableName { get; private set; }
        public Type Type { get; private set; }

        public Dictionary(string tableName, Type type)
        {
            TableName = tableName;
            Type = type;
        }
    }
}
