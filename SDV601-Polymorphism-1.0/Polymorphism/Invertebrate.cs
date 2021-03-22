using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Invertebrate : IAnimal
    {

        private string _name;

        public string Name { get => _name; set => _name = value; }
        public abstract string GetAction();
        public virtual string About()
        {
            return string.Format("{0} the {1} can {2}", Name, GetType().Name.ToLower(), GetAction());
        }
    }
}
