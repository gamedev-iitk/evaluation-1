extends KinematicBody2D
const ball_scene = preload("res://ball.tscn")
func _ready():
	set_process(true)
	set_process_input(true)
	
func _process(_delta):
	var y = get_position().y
	var mouse_x = get_viewport().get_mouse_position().x - 435
	set_position(Vector2(mouse_x,y))
	
func _input(event):
	if event is InputEventMouseButton and event.is_pressed() :
		var ball = ball_scene.instance()
		ball.set_position(get_position()+Vector2((400),170))
		get_tree().get_root().add_child(ball)
