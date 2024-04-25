namespace AnimalKingdom
{
    public class Bee: Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzz!";
        }

        public int NumberOfWings { get; }

        public Bee()
        {
            NumberOfWings = 4;
        }
    }
}
