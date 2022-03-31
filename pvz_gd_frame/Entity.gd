#一般的实体
#包括钱币,僵尸,植物,障碍物等
extends Node2D

#重力源
#一个属于mBoard的Object中的gravity_source

var gravity :Vector2;
func _ready() -> void:
	print(get_parent() is mBoard);


	pass
