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
            Players Noone = new Players(0, 0, "None");
            Players Matthew = new Players(100, 100, "Matthew");
            Players Nick = new Players(200, 200, "Nick");
            Players Zyron = new Players(300, 300, "Zyron");
            Players Chris = new Players(400, 400, "Chris");

            Singleton.Instance.mHeros = new List<Players>();

            Singleton.Instance.mHeros.Add(Noone);
            Singleton.Instance.mHeros.Add(Matthew);
            Singleton.Instance.mHeros.Add(Nick);
            Singleton.Instance.mHeros.Add(Zyron);
            Singleton.Instance.mHeros.Add(Chris);

//#########################################################################################

            Items None = new Items(0, "None");
            Items Sword = new Items(100, "Sword");
            Items Gun = new Items(200, "Gun");
            Items Rocket = new Items(300, "Rocket");

            Singleton.Instance.mItems = new List<Items>();

            Singleton.Instance.mItems.Add(None);
            Singleton.Instance.mItems.Add(Sword);
            Singleton.Instance.mItems.Add(Gun);
            Singleton.Instance.mItems.Add(Rocket);

//#########################################################################################

            Armor Nothing = new Armor("None", 0);
            Armor LightArmor = new Armor("LightArmor", 100);
            Armor SimpleArmor = new Armor("SimpleArmor", 200);
            Armor HeavyArmor = new Armor("HeavyArmor", 300);

            Singleton.Instance.mArmor = new List<Armor>();

            Singleton.Instance.mArmor.Add(Nothing);
            Singleton.Instance.mArmor.Add(LightArmor);
            Singleton.Instance.mArmor.Add(SimpleArmor);
            Singleton.Instance.mArmor.Add(HeavyArmor);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
