extends KinematicBody2D

const ball_scene = preload("res://Mini Scenes/Ball.xml")

func _ready():
	set_fixed_process(true)
	set_process_input(true)

func _fixed_process(delta):
	var y = get_pos().y
	var mouse_x = get_viewport().get_mouse_pos().x
	set_pos(Vector2(mouse_x, y))




