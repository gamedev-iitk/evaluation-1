extends RigidBody2D

export var speedup = 4
const MAXSPEED = 300

func _ready():
	set_fixed_process(true)

func _fixed_process(delta):
	var bodies = get_colliding_bodies()
	
	for body in bodies:
		if body.is_in_group("Bricks"):
			get_node("/root/World").score += 5
			body.queue_free()
			
			if body.get_name() == "Paddle":
				var speed = get_linear_velocity().length()
				var direction = get_pos() - body.get_node("Anchor").get_global_pos()
				var velocity = direction.normalized()*min(speed + speedup, MAXSPEED)
				set_linear_velocity(velocity)
		
		if body.is_in_group("2x"):
			get_node("/root/World").score += 20
			body.queue_free()
			
			if body.get_name() == "Paddle":
				var speed = get_linear_velocity().length()
				var direction = get_pos() - body.get_node("Anchor").get_global_pos()
				var velocity = direction.normalized()*min(speed + speedup, MAXSPEED)
				set_linear_velocity(velocity)

	if get_pos().y > get_viewport_rect().end.y :
		print("Ball died.")
		queue_free()
		