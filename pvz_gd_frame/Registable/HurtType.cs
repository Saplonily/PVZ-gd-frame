using System;
namespace PVZGDFrame
{
    public partial class Register
    {
        public class HurtType
        {
            public int type = Normal;
            static public int Normal;
            static public int Fire;
            static public int Watering;
            static public int Cold;
            static public int Poison;

        }
        public int RegistHurtType(String name)
        {
            int length = RegistedDictionary["HurtType"].Count;
            RegistedDictionary["HurtType"].Add(name);
            return length;
        }
    }
}