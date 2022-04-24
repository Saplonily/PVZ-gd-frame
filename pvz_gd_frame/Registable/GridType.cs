using System;
namespace PVZGDFrame
{
    class Register
    {
        public class GridType
        {
            public int type = Normal;
            static public int Normal;
            static public int Water;
            static public int Lava;
        }

        public int RegistGridType(String name)
        {
            int length = RegistedDictionary["GridType"].Count;
            RegistedDictionary["GridType"].Add(name);
            return length;
        }
    }

}