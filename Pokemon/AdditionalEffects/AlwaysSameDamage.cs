﻿using Pokemon.Models;

namespace Pokemon.AdditionalEffects
{
    public class AlwaysSameDamage : IAdditionalEffect
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? PrimaryParameter { get; set; }

        public int? SecondaryParameter { get; set; }

        public bool IsOnSelf { get; set; }

        public bool IsBasedOnLevel() => PrimaryParameter == 0;
    }
}
