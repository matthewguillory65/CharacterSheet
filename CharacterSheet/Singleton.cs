using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Singleton//Used to make variables global
    {
        private static Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public Players currentHero;//Used to hold the values of the Player selected in the comboBox for Players, also made global
        public Items currentItem;//Used to hold values of the Item selected in the comboBox for Items, also made global
        public Armor currentArmor;//Used to hold values of the Armor selected in the comboBox for Armors, also made global
        public List<Players> mHeros;//List of all the Players made global
        public List<Items> mItems;//List of all the Items made global
        public List<Armor> mArmor;//List of all the Armors made global
    }
}
