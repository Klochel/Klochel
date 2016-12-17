namespace CIS209_PolymorphismDemo1
{
    // Pet is the parent class and
    // is declared abstract so it can not be instantiated
    abstract class Pet
    {
        // These properties are set by the constructor
        // and are read-only thereafter
        public string Name { get; }
        public string Container { get; }

        public Pet(string name, string container)
        {
            Name = name;
            Container = container;
        }

        // This method is virtual to all it be overridden
        // by the child classes
        public virtual string locomation()
        {
            return "?";
        }
    }

    // Fish is a child class of Pet
    class Fish : Pet
    {
        // Class the constructor in the parent class
        public Fish(string name) : base(name, "tank")
        {
        }

        // Note the override of the parent class method
        public override string locomation()
        {
            return "swimmer";
        }
    }

    // Bird is a child class of Pet
    class Bird : Pet
    {
        // Class the constructor in the parent class
        public Bird(string name) : base(name, "cage")
        {
        }

        // Note the override of the parent class method
        public override string locomation()
        {
            return "flier";
        }
    }
}
