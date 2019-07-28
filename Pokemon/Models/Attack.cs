﻿using System.Collections.Generic;

namespace Pokemon.Models
{
    public class Attack : IAttack
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }

        public int? Power { get; set; }

        public int? Accuracy { get; set; }

        public string BoostStats { get; set; }

        public ElementalType TypeID { get; set; }

        public bool IsSpecial { get; set; }

        public ICollection<IAdditionalEffect> AdditionalEffects { get; set; }
    }
}
