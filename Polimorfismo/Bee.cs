using System

namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzbzz";
        }

        public int NumberOfWings { set; } = 4;
    }
}