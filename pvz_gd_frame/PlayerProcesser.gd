#PlayerProcesser控制玩家输入
#每当一个关卡物体抛出一个process_rejected(操作被拒绝)信号时
#^ 注 : 想加入按键缓冲区的可接收玩家输入的物体会自己连接这个节点
extends Node

#按键缓冲区
#TODO
var process_buffer = [];

func _ready() -> void:


	pass
func _process(delta: float) -> void:
	var _a = delta;
	handle_buffer();

#进行缓冲区处理
#TODO
func handle_buffer():
	pass