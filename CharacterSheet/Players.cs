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
        private string m_Name;
        private int m_Attack;
        private int m_Defense;

        public string Name//Getter and Setter values for Players Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        public int Attack//Getter and Setter values for Players Attack
        {
            get { return m_Attack; }
            set { m_Attack = value; }
        }
        public int Defense//Getter and Setter values for Players Defense
        {
            get { return m_Defense; }
            set { m_Defense = value; }
        }

        public Players(int attack, int defense, string name)
        {
            m_Name = name;//Making the public Name equal the private m_Name
            m_Attack = attack;//Making the public Attack equal the private m_Attack
            m_Defense = defense;//Making the public Defense equal the private m_Defense
        }
    }
}
