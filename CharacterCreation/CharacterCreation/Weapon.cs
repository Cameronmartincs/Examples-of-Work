using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    //I dont want this to be the object. Thats why it is abstract. This class has stat types because i planned to include them
    //Adding them would be easy and i planned to show then in the program and description the same way as char
    abstract class Weapon 
    {
        private string type;
        private double damage;
        private double speed;

        public Weapon()
        {

        }
        public Weapon(string _type, double _damage, double _speed)
        {
            type = _type;
            damage = _damage;
            speed = _speed;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }


    }
}
