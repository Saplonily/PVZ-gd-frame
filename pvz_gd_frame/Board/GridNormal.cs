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
		bool availableType = true;
		public bool AvilableType
		{
			get;
			private set;
		}
		int type;
		public int Type
		{
			get{return type;}
			private set
			{
				//TODO HERE
				type = value;
			}
		}
		private Area2D Area;
		private Sprite SprPlaceable;
		private Sprite SprUnplaceable;

		public override void _Ready()
		{
			Type = Register.GridType.Normal;
			Area = GetNode<Area2D>("Area2D");
			SprPlaceable = GetNode<Sprite>("SprPlaceable");
			SprUnplaceable = GetNode<Sprite>("SprUnplaceable");
			SprPlaceable.Visible = false;
			SprUnplaceable.Visible = false;
			//绑定进入事件
			_ = Area.Connect("mouse_entered",this,"MouseEntered");
			_ = Area.Connect("mouse_exited",this,"MouseExited");

		}
		private void MouseEntered()
		{
			if (Type==Register.GridType.Normal)
			{
				EmitSignal("OnReadyPlace");
				SprPlaceable.Visible = true;
			}
		}
		private void MouseExited()
		{
			EmitSignal("OffReadyPlace");
			SprPlaceable.Visible = false;
		}
	}
}