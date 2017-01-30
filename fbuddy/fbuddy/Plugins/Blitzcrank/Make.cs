using System;
using EloBuddy;
using EventHandler = fbuddy.Plugins.Blitzcrank.Assembly.EventHandler;
using fbuddy.Plugins.Blitzcrank.Assembly;

namespace fbuddy.Plugins.Blitzcrank
{
    public static class Make
    {
        public static void Load(EventArgs args)
        {
            if (Player.Instance.Hero != Champion.Blitzcrank) return;

            SpellHandler.Load();
            MenuHandler.Load();
            EventHandler.Load();
        }


    }
}
