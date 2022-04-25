using Godot;
//关卡控制
//控制关卡核心部分
//需要有的子节点:
//~ PlayerProcesser - 控制玩家输入

namespace PVZGDFrame
{
	class mBoard : Node2D
	{
		//关卡全局的重力源
		public Node PlayerProcesser;
		public Label DebugLabel;
		public Vector2 GravitySource
		{
			get;
			set;
		}
		public override void _Ready()
		{
			PlayerProcesser = GetNode<Node>("PlayerProcesser");
			DebugLabel = GetNode<Label>("Label") as Label;
		}
		public override void _Process(float delta)
		{
			DebugLabel.Text = $"fps: {Engine.GetFramesPerSecond()} \ndelta: {delta}";
		}
	}
}