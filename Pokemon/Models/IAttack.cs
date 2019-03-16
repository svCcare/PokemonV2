﻿using System.Collections.Generic;

namespace Pokemon.Models
{
    public interface IAttack
    {
        int? Accuracy { get; set; }
        ICollection<IAdditionalEffect> AdditionalEffects { get; set; }
        string BoostStats { get; set; }
        ElementalType ElementalType { get; set; }
        int ID { get; set; }
        bool IsSpecial { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        int? Power { get; set; }
    }
}