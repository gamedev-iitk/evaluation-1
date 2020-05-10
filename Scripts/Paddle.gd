extends KinematicBody2D

const ball_scene = preload("res://Mini Scenes/Ball.tscn")
var checkball = 0
#checks if ball is present on screen
var countcoins = 10
# currnt no. of coins on screen

func _ready():
	set_physics_process(true)
	set_process_input(true)

func _physics_process(delta):
	var y = get_position().y
# current y position of paddle
	var x = get_viewport().get_mouse_position().x
# gets current x pos of mouse
	set_position(Vector2(x,y))

func _input(event):
	if event is InputEventMouseButton && event.is_pressed() && checkball == 0:
		var ball = ball_scene.instance()
		ball.set_position(get_position()-Vector2(0,16))
		get_tree().get_root().add_child(ball)
		checkball = 1
