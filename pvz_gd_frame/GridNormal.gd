#普通的非特殊形式的方正格子
#挂载在格子场景中
#此借口要求:
#存在
#	SprPlaceable -> 可放置时显示的Spr
#	SprUnplaceable -> 不可放置显示的Spr
#	Area2D -> 碰撞箱,即自己的范围
#信号:
#
extends Node2D;
signal on_ready_place;
signal off_ready_place;

#可用状态
var available_type = true;
onready var area := $Area2D as Area2D;
onready var spr_placeable := $SprPlaceable as Sprite;
onready var spr_unplaceable := $SprUnplaceable as Sprite;

func _ready() -> void:
	spr_placeable.visible = false;
	spr_unplaceable.visible = false;
	#绑定进入事件
	var _a = area.connect("mouse_entered",self,"mouse_entered");
	_a = area.connect("mouse_exited",self,"mouse_exited");
	

	pass
func mouse_entered():
	emit_signal("on_ready_place");
	spr_placeable.visible = true;

func mouse_exited():
	emit_signal("off_ready_place");
	spr_placeable.visible = false;