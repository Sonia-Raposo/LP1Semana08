namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Eek!";
        }

        public int NumberOfNipples { get; }
        public int NumberOfWings { get; }

        public Bat()
        {
            NumberOfNipples = 2;

            NumberOfWings = 2;
        }
    }
}
