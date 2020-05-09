extends RigidBody2D

const SPEEDUP = 4
const MAXSPEED = 300

func _ready():
	set_physics_process(true)

func _physics_process(delta):
	var bodies = get_colliding_bodies()
	
	for body in bodies:
		if body.is_in_group("Bricks"):
			get_node("/root/world").score +=5
			body.queue_free()
		
		if body.is_in_group("Bomb"):
			get_node("/root/world").score -=1
			body.queue_free()
		
		if body.get_name() == "Paddle":
			var speed = get_linear_velocity().length()
			var direction = get_position() - body.get_node("Anchor").get_global_position()
			var velocity = direction.normalized()*min(speed+SPEEDUP, MAXSPEED)
			set_linear_velocity(velocity)
	
	if get_position().y > get_viewport_rect().end.y:
		queue_free()
