﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BIAI.Data.Model
{
    public class TargetSubtype : ISystemDictionary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; private set; }
        public string Name { get; private set; }
    }
}
