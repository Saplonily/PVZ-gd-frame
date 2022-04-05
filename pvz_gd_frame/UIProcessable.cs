using Godot;
using System;
namespace PVZGDFrame
{
	public class UIProcessable : Node2D
	{
		public bool processable = true;
		public bool Processable
		{
			get;
			set;
		}
		public override void _Ready()
		{
			
		}
	}
}