using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System;

namespace fbuddy.Plugins.Blitzcrank.Assembly
{
    public static class EventHandler
    {
        public static AIHeroClient Blitzcrank => Player.Instance;
        private static void Load()
        {
            Drawing.OnDraw += Drawing_OnDraw;
            Game.OnTick += Game_OnTick;
        }
        private static void Game_OnTick(EventArgs args)
        {

        }
        private static void Drawing_OnDraw(EventArgs args)
        {

        }
        
        
    }
}
