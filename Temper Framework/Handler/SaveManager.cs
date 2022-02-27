using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temper_Framework.Character;

namespace Temper_Framework.Handler
{
    public static class SaveManager
    {
        //  You cant directly access the Save.config if you use this as a Reference in a project, so you will have to use these values //

        public static int saveHealth;

        public static int saveSyringes;

        public static void SaveConfig()
        {
            ConfigurationManager.AppSettings.Set("Health", Player.Helath.ToString());
        }

        public static void ReadConfig()
        {
            // config values arent an int or a string so you have to make them whatever they are meant to be //

            saveHealth = Int32.Parse(ConfigurationManager.AppSettings.Get("Health"));
            saveSyringes = Int32.Parse(ConfigurationManager.AppSettings.Get("Syringes"));
        }
    }
}