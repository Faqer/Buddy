using System;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace fbuddy.Plugins.Blitzcrank.Assembly
{
    public static class MenuHandler
    {
        public static Menu menu, combo, ks, draw, misc;

        public static void Load()
        {
            menu = MainMenu.AddMenu("fAIO [Blitzcrank]", "faıobc");

            combo.AddSubMenu("Combo");
            combo.Add("UQ", new CheckBox("Use Q?"));
            combo.Add("UW", new CheckBox("Use W"));
            combo.Add("UE", new CheckBox("Use E"));
            combo.Add("UR", new CheckBox("Use R"));

            ks.AddSubMenu("KillSteal");
            ks.Add("KQ", new CheckBox("Steal Q"));
            ks.Add("KR", new CheckBox("Steal R"));

            draw.AddSubMenu("Drawings");
            draw.Add("DQ", new CheckBox("Draw Q"));
            draw.Add("DW", new CheckBox("Draw W"));
            draw.Add("DE", new CheckBox("Draw E"));
            draw.Add("DR", new CheckBox("Draw R"));

            misc.AddSubMenu("Misc");

        }

    }
}
