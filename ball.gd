extends RigidBody2D
const maxspeed=80000
const boost=3000

func _ready():
	set_physics_process(true) # Replace with function body.
	

func _physics_process(delta):
	var bodies= get_colliding_bodies()
	
	for body in bodies:
		if body.is_in_group("coinss"):
			get_node("/root/world").score+=5
			body.queue_free() 
		if body.get_name() == "paddle" :
			var speed = get_linear_velocity().length()
			var direction = get_position()- body.get_node("anchor").get_global_position()
			var velocity= direction.normalized()*min(speed+boost*delta,maxspeed*delta)
			set_linear_velocity(velocity)
		
	if get_position().y > get_viewport_rect().end.y:
		queue_free()
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
