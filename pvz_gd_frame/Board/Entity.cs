using Godot;
using System.Linq;
using Godot.Collections;
using PVZGDFrame;
//一般的实体
//包括钱币,僵尸,植物,障碍物等

namespace PVZGDFrame
{
	public class Entity : Node2D
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
		//^ 隐藏基层Node2D的成员Position以此实现2.5d的视效
		//关于一个Entity的坐标:
		//此处更替的Position作为一个三维坐标,z为上下坐标
		//Node2D的Position仅用于引擎自带碰撞等行为
		//即视觉位置
		new public Vector3 Position
		{
			set
			{
				base.Position = new Vector2(value.x,value.y+zPos);
				Position = new Vector3(base.Position.x,base.Position.y,value.z);
				
			}
			private get
			{
				return new Vector3(base.Position.x,base.Position.y-zPos,zPos);
			}
		}
		private float zPos = 0.0f;
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