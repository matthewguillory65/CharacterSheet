using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Items
    {
        //class Items that allows modification to the Players attack
        Items() { }
        //Default Constructor
        private string m_Name;
        private int m_Attack;

        public string Name//Getter and Setter values for Items Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        public int Attack//Getter and Setter values for Items Attack
        {
            get { return m_Attack; }
            set { m_Attack = value; }
        }

        public Items(int attack, string name)
        {
            m_Name = name;//Making the public Name equal the private m_Name
            m_Attack = attack;//Making the public Attack equal the private m_Attack
        }
    }
}
