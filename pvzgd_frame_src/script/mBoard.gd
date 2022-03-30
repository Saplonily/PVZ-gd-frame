extends Node
#mBoard，关卡的根节点

var camera_target:Vector2;
var camera_pos:Vector2;
onready var camera:Camera = $level_camera;
onready var ui:CanvasLayer = $ui;
var in_pause:bool = false;

func _ready():

	pass

func _process(delta):
	var _a = delta;
	process_camera()

	pass;
	
func process_camera():

	pass
	

#* 以下是可被外部访问的函数

#通过输入字符串，尝试进入对应关卡
#关卡对应一个文件
func enter_level(level_path:String):
	var _a = level_path;

	pass

#暂停游戏
func pause_level():
	self.in_pause = true;
	ui.show_pause_ui();
	
	pass

#* vscode可以用#region的方法规定一个可折叠区域
#region camera设置等函数

#设置Camera2D的位置
func set_camera_pos(pos:Vector2):
	camera.position = pos
	
func get_camera_pos():
	return camera.position
#以某种趋势移动相机
func camera_add_motion(type:int,start:float,change:float,duration:float,delay:float):
	var _t = type;
	var _s = start;
	var _c = change;
	var _d = duration;
	var _d0 = delay;

	pass

#camera的运动类型,当然你也可以使用缓动脚本
enum camera_motion{
	sine_out = 0,
	sine_in = 1,
	sine_inout = 2
}
	
#endregion
