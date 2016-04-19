﻿using System;

namespace FlyweightPattern
{
    public class ConcreteFlyweight:Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"具体Flyweight:{extrinsicstate}");
        }
    }
}