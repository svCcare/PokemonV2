﻿namespace Pokemon
{
    public static class AttackEffectivenessHelper
    {
        private static float[,] multiplier = new float[15,15] {
                                {1,     1,     1,     1,     1,     1,     1,     1,     1,     1,     1,     1,     0.5f,  0,     1},
                                {1,     0.5f,  0.5f,  1,     2,     2,     1,     1,     1,     1,     1,     2,     0.5f,  1,     0.5f},
                                {1,     2,     0.5f,  1,     0.5f,  1,     1,     1,     2,     1,     1,     1,     2,     1,     0.5f},
                                {1,     1,     2,     0.5f,  0.5f,  1,     1,     1,     0,     2,     1,     1,     1,     1,     0.5f},
                                {1,     0.5f,  2,     1,     0.5f,  1,     1,     0.5f,  2,     0.5f,  1,     0.5f,  2,     1,     0.5f},
                                {1,     0.5f,  0.5f,  1,     2,     0.5f,  1,     1,     2,     2,     1,     1,     1,     1,     2},
                                {2,     1,     1,     1,     1,     2,     1,     0.5f,  1,     0.5f,  0.5f,  0.5f,  2,     0,     1},
                                {1,     1,     1,     1,     2,     1,     1,     0.5f,  0.5f,  1,     1,     1,     0.5f,  0.5f,  1},
                                {1,     2,     1,     2,     0.5f,  1,     1,     2,     1,     0,     1,     0.5f,  2,     1,     1},
                                {1,     1,     1,     0.5f,  2,     1,     2,     1,     1,     1,     1,     2,     0.5f,  1,     1},
                                {1,     1,     1,     1,     1,     1,     2,     2,     1,     1,     0.5f,  1,     1,     1,     1},
                                {1,     0.5f,  1,     1,     2,     1,     0.5f,  0.5f,  1,     0.5f,  2,     1,     1,     0.5f,  1},
                                {1,     2,     1,     1,     1,     2,     0.5f,  1,     0.5f,  2,     1,     2,     1,     1,     1},
                                {0,     1,     1,     1,     1,     1,     1,     1,     1,     1,     2,     1,     1,     2,     1},
                                {1,     1,     1,     1,     1,     1,     1,     1,     1,     1,     1,     1,     1,     1,     2} };

        public static float GetMultipler(int attackType, int targetType)
        {
            return multiplier[attackType, targetType];
        }
    }
}
