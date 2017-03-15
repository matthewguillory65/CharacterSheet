using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Players
    {
        //class that gives a player "What it is".
        Players() { }
        //Default Constructor
        public string m_Name;
        public int m_Attack;
        public int m_Defense;

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
        public int Defense
        {
            get { return m_Defense; }
            set { m_Defense = value; }
        }

        public Players(int attack, int defense, string name)
        {
            m_Name = name;
            m_Attack = attack;
            m_Defense = defense;
        }
    }
}
