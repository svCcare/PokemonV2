﻿using System;

namespace Pokemon.Validators
{
    public static class LevelValidator
    {
        public static LevelValidatorResult IsLevelValid(string levelText)
        {
            if (Int32.TryParse(levelText, out int level))
            {
                if (level > 100 || level <= 0)
                {
                    return LevelValidatorResult.NotInRange;
                }
            }
            else
            {
                return LevelValidatorResult.InvalidFormat;
            }
            return LevelValidatorResult.OK;
        }
    }
}
