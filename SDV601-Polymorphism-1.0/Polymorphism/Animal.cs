namespace Polymorphism
{
    public abstract class Animal : IAnimal
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public abstract string GetSound();

        public override string ToString()
        {
            return string.Format("Pet - Name: {0}", _name);
        }

        public virtual string About()
        {
            return string.Format("{0} the {1} can {2}", Name, GetType().Name.ToLower(), GetSound().ToLower());
        }
    }
}
