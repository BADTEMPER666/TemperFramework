using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temper_Framework.Character;

namespace Temper_Framework.Handler
{
    public static class InventoryManager
    {
        public static void addSyringe(int num)
        {
            Player.Syringes += num;
        }

        public static void removeSyringe(int num)
        {
            Player.Syringes -= num;
        }

        public static void useSyringe()
        {
            if (Player.Syringes <= 0 || ((Player.Helath + 10) > Player.maxHealth)) return;
            removeSyringe(1);
            PlayerManager.Heal(10);
        }
    }
}
