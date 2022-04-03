using Godot;
using PVZGDFrame;
//普通的非特殊形式的方正格子
//挂载在格子场景中
//此借口要求:
//存在
//	SprPlaceable -> 可放置时显示的Spr
//	SprUnplaceable -> 不可放置显示的Spr
//	Area2D -> 碰撞箱,即自己的范围

namespace PVZGDFrame
{
	class GridNormal : Node2D
	{
		[Signal]
		delegate void OnReadyPlace();
		[Signal]
		delegate void OffReadyPlace();
		//可用状态
		bool AvailableType = true;
		public int Type;
		public Area2D Area;
		public Sprite SprPlaceable;
		public Sprite SprUnplaceable;

		public override void _Ready()
		{
			Type = Register.GridType.Normal;
			Area = GetNode<Area2D>("Area2D");
			SprPlaceable = GetNode<Sprite>("SprPlaceable");
			SprUnplaceable = GetNode<Sprite>("SprUnplaceable");
			SprPlaceable.Visible = false;
			SprUnplaceable.Visible = false;
			//绑定进入事件
			var _a = Area.Connect("mouse_entered",this,"MouseEntered");
			_a = Area.Connect("mouse_exited",this,"MouseExited");

		}
		public void MouseEntered()
		{
			if (Type==Register.GridType.Normal)
			{
				EmitSignal("OnReadyPlace");
				SprPlaceable.Visible = true;
			}
		}

		public void MouseExited()
		{
			EmitSignal("OffReadyPlace");
			SprPlaceable.Visible = false;
		}
	}
}