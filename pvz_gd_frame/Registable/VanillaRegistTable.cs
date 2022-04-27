using System;
using System.Collections;
using System.Collections.Generic;

namespace PVZGDFrame
{
    using StringDictionary = Dictionary<string, int>;
    public partial class Register
    {
        void DoRegistVanilla()
        {
            DoRegistGridTypeVanilla();
            DoRegistPartyVanilla();
        }
        //注册格子类型
        void DoRegistGridTypeVanilla()
        {
            RegistRegistType("GridType");
            GridType.Normal = RegistGridType("Normal");
            GridType.Water = RegistGridType("Water");
            GridType.Lava = RegistGridType("Lava");
        }
        //注册party
        void DoRegistPartyVanilla()
        {
            RegistRegistType("Parties");
            Party.Plant = RegistPartyType("Plant");
            Party.Zombie = RegistPartyType("Zombie");
        }
    }
}