using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    //Char takes weapons fields and properties, The constructor with arguments is not needed but included anyway,
    //this is the object that gets created
     class Char : Weapon 
    {
        private string name;
        private string gender;
        private string race;
        private string role;

        public Char()
        {

        }

        public Char(string _name, string _gender, string _race, string _role, string _type, double _damage, double _speed)
            : base (_type, _damage, _speed)
        {
            role = _role;
            name = _name;
            gender = _gender;
            race = _race;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
