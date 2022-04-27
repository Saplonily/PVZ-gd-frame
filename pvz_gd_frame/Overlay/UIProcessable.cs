using Godot;
using System;
namespace PVZGDFrame
{
	//UIProcessable要求必须有一个Button作为子节点
	public class UIProcessable : Node2D
	{
		[Signal]
		public delegate void Processed();
		public bool processable = true;
		public bool Processable
		{
			get;
			set;
		}
		public override void _Ready()
		{
			
		}
		public virtual void OnClick()
		{
			if (Processable)
			{
				EmitSignal(nameof(Processed));
			}
		}
	}
}