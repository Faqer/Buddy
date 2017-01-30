using System;
using System.Collections.Generic;
using EloBuddy;
using EloBuddy.SDK.Events;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fbuddy
{
    class Program
    {
        private static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        private static void OnLoadingComplete(EventArgs args)
        {
            switch (Player.Instance.Hero)
            {
                case Champion.Blitzcrank:
                    Plugins.Blitzcrank.Make.Load(args);
                    break;
            }

        }

    }
}
