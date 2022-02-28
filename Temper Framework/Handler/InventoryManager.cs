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
            Player.Syringes = num;
        }

        public static void removeSyringe(int num)
        {
            Player.Syringes = num;
        }

        public static void useSyringe()
        {
            if (Player.Syringes > 0)
            {
                if (Player.Helath == 100)
                {

                }
                else
                {
                    Player.Syringes--;
                    PlayerManager.Heal(10);
                }
            }
            else if (Player.Syringes < 0)
            {

            }
        }
    }
}
