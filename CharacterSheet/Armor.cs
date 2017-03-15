using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Armor
    {
        Armor() { }
        string m_Name;
        int m_Defense;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        public int Defense
        {
            get { return m_Defense; }
            set { m_Defense = value; }
        }

        public Armor(string name, int defense)
        {
            m_Name = name;
            m_Defense = defense;
        }
    }
}
