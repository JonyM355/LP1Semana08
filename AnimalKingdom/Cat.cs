﻿using System;

namespace AnimalKingdom
{
    public class Cat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
        public int NumberOfNipples { get; } = 6;
    }
}
