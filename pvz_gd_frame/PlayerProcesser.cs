using Godot;
//PlayerProcesser控制玩家输入
//每当一个关卡物体抛出一个process_rejected(操作被拒绝)信号时
//^ 注 : 想加入按键缓冲区的可接收玩家输入的物体会自己连接这个节点
namespace PVZGDFrame
{

	class PlayerProcesser : Node
	{
		//按键缓冲区
		//TODO
		object[] process_buffer = null;
		public override void _Ready()
		{
			
		}
		public override void _Process(float delta)
		{
			var _a = delta;
			handle_buffer();
		}
		//进行缓冲区处理
		//TODO
		public void handle_buffer()
		{
		
		}
	}
}