extends KinematicBody2D

const ball_scene = preload ("res://Childe Scenes/Ball.tscn")

func _ready():
	set_physics_process(true)
	set_process_input(true)

# warning-ignore:unused_argument
func _physics_process(delta):
	
	var y = position.y
	var mouse_x = get_viewport().get_mouse_position().x
	set_position(Vector2(mouse_x,y))

func _input(event):
	if event is InputEventMouseButton && event.is_pressed():
		var ball = ball_scene.instance()
		ball.set_position(position - Vector2(0,16))
		get_tree().get_root().add_child(ball)
