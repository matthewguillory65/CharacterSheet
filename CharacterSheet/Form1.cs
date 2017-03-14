using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Players player in Singleton.Instance.mHeros)
                PlayerSelection.Items.Add(player.Name);

            foreach (Items item in Singleton.Instance.mItems)
                ItemSelection.Items.Add(item.Name);
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
        }

        private void currentPlayerDefense(object sender, EventArgs e)
        {
            Singleton.Instance.currentHero.m_Defense.ToString();
        }

        private void currentPlayerAttack(object sender, EventArgs e)
        {
            Singleton.Instance.currentHero.m_Attack.ToString();
        }

        private void ItemSelections(object sender, EventArgs e)
        {
            foreach (Items item in Singleton.Instance.mItems)
            {
                if (ItemSelection.SelectedItem.Equals(item.m_Name))
                {
                    Singleton.Instance.currentItem = item;
                    break;
                }
            }
        }

        public void ItemEnhancement()
        {
            int NewAttack;
            NewAttack = Singleton.Instance.currentItem.Attack + Singleton.Instance.currentItem.Attack;
        }

        private void ItemCombo_TextChanged(object sender, EventArgs e)
        {
            ItemEnhancement();
        }
    }
}
