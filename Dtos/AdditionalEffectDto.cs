﻿using System;

namespace Dtos
{
    public class AdditionalEffectDto
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? PrimaryValue { get; set; }

        public int? SecondaryValue { get; set; }

        public bool IsOnSelf { get; set; }
    }
}
