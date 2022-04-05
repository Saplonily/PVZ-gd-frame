using Godot;
using System.Linq;
using Godot.Collections;
//一般的实体
//包括钱币,僵尸,植物,障碍物等

namespace PVZGDFrame
{
	class Entity : Node2D
	{

		//重力源
		//一个属于mBoard的Object中的gravity_source
		public Area2D collisionRange = null;
		private Vector2 gravity = new Vector2(0,0);
		public Vector2 Gravity
		{
			get;
			private set;
		}
		private Vector2 gravityVelocity = new Vector2(0,700);
		public Vector2 GravityVelocity
		{
			get;
			private set;
		}
		public override void _Ready()
		{
			GD.Print(Owner is mBoard);
			gravity = GetNode<Game>("/root/Game").mBoard.GravitySource;
			
			foreach (var item in GetChildren())
			{
				if(item is Area2D)
				{
					collisionRange = item as Area2D;
					break;
				}
			}
			if (collisionRange == null)
			{
				GD.PrintErr("Do not find Area2D.");
			}
		}
		public override void _Process(float delta)
		{
			GravityVelocity += Gravity;
			
		}
	}
}