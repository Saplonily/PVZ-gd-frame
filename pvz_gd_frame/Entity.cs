using Godot;
//一般的实体
//包括钱币,僵尸,植物,障碍物等

namespace PVZGDFrame
{
	class Entity : Node2D
	{

		//重力源
		//一个属于mBoard的Object中的gravity_source
		public Vector2 Gravity
		{
			get;set;
		}
		public override void _Ready()
		{
			GD.Print(GetParent() is mBoard);
		}
	}
}