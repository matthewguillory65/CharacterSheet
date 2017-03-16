using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace CharacterSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SetUp()
        {
            AssessmentSerialization<List<Players>>.Serialize("ListofPlayersDefualt", Singleton.Instance.mHeros);
        }
        
        private void comboBox(object sender, EventArgs e)
        {
            //This lets you select a Player from a drop down box
            foreach (Players player in Singleton.Instance.mHeros)
            {
                if (PlayerSelection.SelectedItem.Equals(player.Name))
                {
                    Singleton.Instance.currentHero = player;
                    break;
                }
            }
            //Makes the attack and defense able to be seen
            PlayerAttack.Text = Singleton.Instance.currentHero.Attack.ToString();
            PlayerDefense.Text = Singleton.Instance.currentHero.Defense.ToString();
        }

        private void ItemSelections(object sender, EventArgs e)
        {
            int NewAttack;
            //When you click an Item in the comboBox, it becomes the currentItem and it's values
            foreach (Items item in Singleton.Instance.mItems)
            {
                if (ItemSelection.SelectedItem.Equals(item.m_Name))
                {
                    Singleton.Instance.currentItem = item;
                    break;
                }
            }
            if (PlayerSelection.SelectedValue != null)
            {
                //This adds the Players attack and item's value together to get a new attack
                NewAttack = Singleton.Instance.currentHero.Attack + Singleton.Instance.currentItem.Attack;
                ItemCombo.Text = NewAttack.ToString();
            }
        }

        private void ArmorSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NewDefense;
            //When you click an Armor in the comboBox, it becomes the currentArmor and it's values
            foreach (Armor armor in Singleton.Instance.mArmor)
            {
                if (ArmorSelection.SelectedItem.Equals(armor.Name))
                {
                    Singleton.Instance.currentArmor = armor;
                    break;
                }
            }
            if (PlayerSelection.SelectedValue != null)
            {
                //This adds the Players defense and item's value together to get a new defense
                NewDefense = Singleton.Instance.currentHero.Defense + Singleton.Instance.currentArmor.Defense;
                ArmorCombo.Text = NewDefense.ToString();
            }
        }

        //private void ItemCombo_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Adding each Player to the comboBox
            foreach (Players player in Singleton.Instance.mHeros)
                PlayerSelection.Items.Add(player.Name);

            //Adding each Item to the comboBox
            foreach (Items item in Singleton.Instance.mItems)
                ItemSelection.Items.Add(item.Name);

            //Adding each Armor to the comboBox
            foreach (Armor armor in Singleton.Instance.mArmor)
                ArmorSelection.Items.Add(armor.Name);
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            //Saves the current information for currentHero, currentItem, and currentArmor
            if (PlayerSelection != null)
            {
                AssessmentSerialization<Players>.Serialize("CurrentPlayer", Singleton.Instance.currentHero);//If there is no Player chosen, the program will not break
            }
            if (ItemSelection != null)
            {
                AssessmentSerialization<Items>.Serialize("CurrentItem", Singleton.Instance.currentItem);//If there is no Item chosen, the program will not break
            }
            if (ArmorSelection != null)
            {
                AssessmentSerialization<Armor>.Serialize("CurrentArmor", Singleton.Instance.currentArmor);//If there is no Armor chosen, the program will not break
            }
            SaveLoad.AppendText("                      Saved");
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            //Loads the saved information for currentHero, currentItem, and currentArmor
            if (Singleton.Instance.currentHero != null)
            {
                Singleton.Instance.currentHero = AssessmentSerialization<Players>.Deserialize("CurrentPlayer");//If there is no Player chosen, the program will not break
                PlayerSelection.SelectedItem = Singleton.Instance.currentHero.Name;//Makes the comboBox currentHero equal the saved currentHero
            }
            if (Singleton.Instance.currentItem != null)
            {
                Singleton.Instance.currentItem = AssessmentSerialization<Items>.Deserialize("CurrentItem");//If there is no Item chosen, the program will not break
                ItemSelection.SelectedItem = Singleton.Instance.currentItem.Name;//Makes the comboBox currentItem equal the saved currentItem
            }
            if (Singleton.Instance.currentArmor != null)
            {
                Singleton.Instance.currentArmor = AssessmentSerialization<Armor>.Deserialize("CurrentArmor");//If there is no Armor chosen, the program will not break
                ArmorSelection.SelectedItem = Singleton.Instance.currentArmor.Name;//Makes the comboBox currentArmor equal the saved currentArmor
            }
            SaveLoad.AppendText("                    Loaded");
        }

        //private void updateData()
        //{
            
        //}

        //private void SaveLoad_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void ArmorCombo_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Characterchoice_Click(object sender, EventArgs e)
        //{

        //}

        private void UpdateD_Click(object sender, EventArgs e)
        {
            //This was made to update the data whenever you choose a new Player, it updates the attack and defense after clicking the new Player
            int NewAttack;
            int NewDefense;
            if (Singleton.Instance.currentHero != null)//If there is no Player chosen, the program will not break
            {
                PlayerAttack.Text = Singleton.Instance.currentHero.Attack.ToString();
                PlayerDefense.Text = Singleton.Instance.currentHero.Defense.ToString();
            }
            if (Singleton.Instance.currentItem != null)//If there is no Item chosen, the program will not break
            {
                NewAttack = Singleton.Instance.currentHero.Attack + Singleton.Instance.currentItem.Attack;
                ItemCombo.Text = NewAttack.ToString();
            }
            if (Singleton.Instance.currentArmor != null)//If there is no Armor chosen, the program will not break
            {
                NewDefense = Singleton.Instance.currentHero.Defense + Singleton.Instance.currentArmor.Defense;
                ArmorCombo.Text = NewDefense.ToString();
            }
        }
    }
}
