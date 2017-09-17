using System;

namespace BIAI.Data.Model.Annotations
{
    public class Dictionary : Attribute
    {
        public string TableName { get; private set; }

        public Dictionary(string tableName)
        {
            TableName = tableName;
        }
    }
}
