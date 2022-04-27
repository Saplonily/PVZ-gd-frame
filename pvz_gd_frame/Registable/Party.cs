using System;
namespace PVZGDFrame
{
    public partial class Register
    {
        public class Party
        {
            public int type = Plant;
            static public int Plant;
            static public int Zombie;
        }
        public int RegistPartyType(String name)
        {
            int length = RegistedDictionary["Parties"].Count;
            RegistedDictionary["Parties"].Add(name);
            return length;
        }
    }
}
