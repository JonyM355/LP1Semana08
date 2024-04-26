using System

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Riii";
        }

        public int NumberOfNipples { get; } = 2;
        public int NumberOfWings { set; } = 2;
    }
}