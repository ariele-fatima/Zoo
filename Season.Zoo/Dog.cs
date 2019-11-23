using System;
using Season.Zoo.Exceptions;

namespace Season.Zoo
{
    sealed class Dog : Animal
    {
        protected override string DoSpeak() => "Au, Au";
    }
}