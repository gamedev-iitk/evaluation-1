extends KinematicBody2D

var current_position = Vector2(0,16)
const ball_scene = preload("res://mini_scene/ball.tscn")

func _ready():
	set_physics_process(true)
	set_process_input(true)

func _physics_process(delta):
	var y = get_position().y
	var mouse_x = get_viewport().get_mouse_position().x
	set_position(Vector2(mouse_x, y))


func _input(event):
	if event is InputEventMouseButton:
		if event.button_index == BUTTON_LEFT and event.pressed:
			print("ball found")
			var ball = ball_scene.instance()
			ball.set_position(ball.get_position() - Vector2(0,16))
			get_tree().get_root().add_child(ball)
