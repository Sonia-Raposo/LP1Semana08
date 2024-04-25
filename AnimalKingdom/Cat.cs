namespace AnimalKingdom
{
    public class Cat: Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }

        public int NumberOfNipples { get; }

        public Cat()
        {
            NumberOfNipples = 6;
        }
    }
}
