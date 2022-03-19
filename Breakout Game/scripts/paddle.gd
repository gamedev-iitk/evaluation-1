
extends KinematicBody2D
const ball_scene=preload("res://mini scenes/ball.xml")

func _ready():
	set_fixed_process(true)
	set_process_input(true)
func _fixed_process(delta):
	var mouse_x = get_viewport().get_mouse_pos().x
	var mouse_y = get_viewport().get_mouse_pos().y
	set_pos(Vector2(mouse_x,mouse_y))
	
func _input(event):
	if event.type==InputEvent.MOUSE_BUTTON && event.is_pressed():
		var ball=ball_scene.instance()
		ball.set_pos(get_pos()-Vector2(0,16))
		get_tree().get_root().add_child(ball)