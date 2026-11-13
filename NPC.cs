using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TEXT_GAME_DAN
{
    private class NPC
    {
        private float health = 100.0f;
        private string name = "DEFAULT";
        private bool sword = false;
        private float damage = 15;

        private NPC(float newHealth, string newName)
        {
            health = newHealth;
            name = newName;
        }
    }
}
