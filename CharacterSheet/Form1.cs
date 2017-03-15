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
            foreach (Players player in Singleton.Instance.mHeros)
            {
                if (PlayerSelection.SelectedItem.Equals(player.Name))
                {
                    Singleton.Instance.currentHero = player;
                    break;
                }
            }
            PlayerAttack.Text = Singleton.Instance.currentHero.m_Attack.ToString();
            PlayerDefense.Text = Singleton.Instance.currentHero.Defense.ToString();
        }

        private void ItemSelections(object sender, EventArgs e)
        {
            int NewAttack;
            foreach (Items item in Singleton.Instance.mItems)
            {
                if (ItemSelection.SelectedItem.Equals(item.m_Name))
                {
                    Singleton.Instance.currentItem = item;
                    break;
                }
            }
            NewAttack = Singleton.Instance.currentHero.Attack + Singleton.Instance.currentItem.Attack;
            ItemCombo.Text = NewAttack.ToString();
        }

        private void ArmorSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NewDefense;
            foreach (Armor armor in Singleton.Instance.mArmor)
            {
                if (ArmorSelection.SelectedItem.Equals(armor.Name))
                {
                    Singleton.Instance.currentArmor = armor;
                    break;
                }
            }
            NewDefense = Singleton.Instance.currentHero.Defense + Singleton.Instance.currentArmor.Defense;
            ArmorCombo.Text = NewDefense.ToString();
        }

        private void ItemCombo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (Players player in Singleton.Instance.mHeros)
                PlayerSelection.Items.Add(player.Name);

            foreach (Items item in Singleton.Instance.mItems)
                ItemSelection.Items.Add(item.Name);

            foreach (Armor armor in Singleton.Instance.mArmor)
                ArmorSelection.Items.Add(armor.Name);
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            AssessmentSerialization<Players>.Serialize("CurrentPlayer", Singleton.Instance.currentHero);
            AssessmentSerialization<Items>.Serialize("CurrentItem", Singleton.Instance.currentItem);
            AssessmentSerialization<Armor>.Serialize("CurrentArmor", Singleton.Instance.currentArmor);
            PlayerSelection.SelectionStart = PlayerSelection.SelectedIndex;
            ItemSelection.SelectionStart = ItemSelection.SelectedIndex;
            ArmorSelection.SelectionStart = ArmorSelection.SelectedIndex;
            SaveLoad.AppendText("                      Saved");
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            Singleton.Instance.currentHero = AssessmentSerialization<Players>.Deserialize("CurrentPlayer");
            Singleton.Instance.currentItem = AssessmentSerialization<Items>.Deserialize("CurrentItem");
            Singleton.Instance.currentArmor = AssessmentSerialization<Armor>.Deserialize("CurrentArmor");
            PlayerSelection.SelectedItem = Singleton.Instance.currentHero.Name;
            ItemSelection.SelectedItem = Singleton.Instance.currentItem.Name;
            ArmorSelection.SelectedItem = Singleton.Instance.currentArmor.Name;
            SaveLoad.AppendText("                    Loaded");
        }

        private void SaveLoad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArmorCombo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Characterchoice_Click(object sender, EventArgs e)
        {

        }
    }
}
