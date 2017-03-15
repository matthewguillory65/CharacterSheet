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
        public string m_Name;
        public int m_Attack;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        public int Attack
        {
            get { return m_Attack; }
            set { m_Attack = value; }
        }

        public Items(int attack, string name)
        {
            m_Name = name;
            m_Attack = attack;
        }
    }
}
