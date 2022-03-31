#关卡控制
#控制关卡核心部分
#需要有的子节点:
#~ PlayerProcesser - 控制玩家输入
extends Node2D
class_name mBoard,"res://icon.png"

#关卡全局的重力源
onready var player_processer = $PlayerProcesser as Node;
onready var debug_label = $Label as Label;
var gravity_source:Vector2 = Vector2(0,4000) setget ,get_gravity_source;

func _ready():
	


	pass

func _process(delta: float) -> void:
	var str0 = "";
	str0 += "delta : " + str(delta) + char(10)
	str0 += "fps : " + str(Engine.get_frames_per_second()) + char(10);
	debug_label.text = str0;

func get_gravity_source() -> Vector2:
	return gravity_source;
