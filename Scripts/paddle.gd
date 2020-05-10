extends KinematicBody2D

var paddleSpeed  = 200

var velocity = Vector2()

func _physics_process(delta):
	if Input.is_action_pressed("ui_left"):
		velocity.x = -paddleSpeed
	elif Input.is_action_pressed("ui_right"):
		velocity.x = paddleSpeed
	else:
		velocity.x = 0
	
	move_and_slide(velocity , Vector2(0,-1))
	
