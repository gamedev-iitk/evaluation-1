extends KinematicBody2D


const ball_scene = preload("res://scenes/Ball.tscn")

func _ready():
	
	set_process(true)
	set_process_input(true)
	
	
func _process(delta):
	var x = get_position().x
	var y = get_position().y
	
	var mouse_pos_x = get_viewport().get_mouse_position().x
	set_position(Vector2(mouse_pos_x,y))

func input(event):

		if event is InputEventMouseButton:
			if event.pressed:
				var ball = ball_scene.instance()
				ball.set_position(get_position()-Vector2(0,0.449))
				get_tree().get_root().add_child(ball)
