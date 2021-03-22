using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Zoo
    {
        private readonly List<IAnimal> _animals;

        public Zoo()
        {
            _animals = new List<IAnimal>();
        }

        public List<IAnimal> Animals { get => _animals; }

        public string About()
        {
            StringBuilder result = new StringBuilder();
            foreach (IAnimal animal in _animals)
            {
                result.AppendLine(animal.About());
            }
            return result.ToString();
        }

        public void Add(IAnimal animal)
        {
            _animals.Add(animal);
        }
    }
}
