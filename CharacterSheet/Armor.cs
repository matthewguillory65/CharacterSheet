﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Armor
    {
        //Class for armor that allows modification to the Players defense stat
        Armor() { }
        //Default Constructor
        private string m_Name;
        private int m_Defense;

        public string Name//Getter and Setter values for Armor Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        public int Defense//Getter and Setter values for Armor Defense
        {
            get { return m_Defense; }
            set { m_Defense = value; }
        }

        public Armor(string name, int defense)
        {
            m_Name = name;//Making the public Name equal the private m_Name
            m_Defense = defense;//Making the public Defense equal the private m_Defense
        }
    }
}
