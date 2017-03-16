using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Players
            //All the players that will be added to the list mHeros
            Players Noone = new Players(0, 0, "None");
            Players Matthew = new Players(100, 100, "Matthew");
            Players Nick = new Players(200, 200, "Nick");
            Players Zyron = new Players(300, 300, "Zyron");
            Players Chris = new Players(400, 400, "Chris");

            //Creating the List for the Heros
            Singleton.Instance.mHeros = new List<Players>();

            //Adding each Player to the list
            Singleton.Instance.mHeros.Add(Noone);
            Singleton.Instance.mHeros.Add(Matthew);
            Singleton.Instance.mHeros.Add(Nick);
            Singleton.Instance.mHeros.Add(Zyron);
            Singleton.Instance.mHeros.Add(Chris);
            #endregion

            #region Items
            //All the items that will be added to the List mItems
            Items None = new Items(0, "None");
            Items Sword = new Items(100, "Sword");
            Items Gun = new Items(200, "Gun");
            Items Rocket = new Items(300, "Rocket");
            Items Excalibur = new Items(5000, "Excalibur");

            //Creating the List for the Items
            Singleton.Instance.mItems = new List<Items>();
            
            //Adding each Item to the List
            Singleton.Instance.mItems.Add(None);
            Singleton.Instance.mItems.Add(Sword);
            Singleton.Instance.mItems.Add(Gun);
            Singleton.Instance.mItems.Add(Rocket);
            Singleton.Instance.mItems.Add(Excalibur);
            #endregion

            #region Armor
            //All the Armors that will be added to the List mArmor
            Armor Nothing = new Armor("None", 0);
            Armor LightArmor = new Armor("LightArmor", 100);
            Armor SimpleArmor = new Armor("SimpleArmor", 200);
            Armor HeavyArmor = new Armor("HeavyArmor", 300);
            Armor Zero = new Armor("Zero's Armor", 5000);

            //Creating the List for the Armor
            Singleton.Instance.mArmor = new List<Armor>();

            //Adding each Armor to the List
            Singleton.Instance.mArmor.Add(Nothing);
            Singleton.Instance.mArmor.Add(LightArmor);
            Singleton.Instance.mArmor.Add(SimpleArmor);
            Singleton.Instance.mArmor.Add(HeavyArmor);
            Singleton.Instance.mArmor.Add(Zero);
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
