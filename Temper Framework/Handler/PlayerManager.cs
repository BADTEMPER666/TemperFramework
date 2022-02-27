using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temper_Framework.Character;

namespace Temper_Framework.Handler
{
    public static class PlayerManager
    {
        public static void changeHealth(int num)
        {
            Player.Helath = num;
        }

    }
}
