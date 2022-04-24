namespace PVZGDFrame
{
    public partial class Register
    {
        //注册格子类型
        public void DoRegistGridTypeVanilla()
        {
            RegistRegistType("GridType");
            GridType.Normal = RegistGridType("Normal");
            GridType.Water = RegistGridType("Water");
            GridType.Lava = RegistGridType("Lava");
        }
    }
}