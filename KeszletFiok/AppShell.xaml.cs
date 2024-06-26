﻿using KeszletFiok.views;

namespace KeszletFiok
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Settings),typeof(Settings));
            Routing.RegisterRoute(nameof(Account), typeof(Account));
            Routing.RegisterRoute(nameof(Print), typeof(Print));
            Routing.RegisterRoute(nameof(KeszletFiok.views.Contact), typeof(KeszletFiok.views.Contact));
        }
    }
}
