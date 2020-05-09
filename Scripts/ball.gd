extends RigidBody2D

const SPEEDUP = 400
const MAXSPEED = 30000

func _ready():
	set_process(true)

func _process(delta) :
	var bodies = get_colliding_bodies()
	for body in bodies:
#		if body.is_in_group("Coins") :
#			get_node("/root/World").Score += 5
#			body.queue_free()
			
		if body.get_name() == 'Paddle' :
			var speed = get_linear_velocity().length()
			var direction = get_position() - body.get_node('Ancor').get_global_position()
			var velocity = direction.normalized() * min(speed + SPEEDUP * delta, MAXSPEED * delta)
			set_linear_velocity(velocity)
	
	if get_position().y > get_viewport_rect().end.y :
		queue_free()
