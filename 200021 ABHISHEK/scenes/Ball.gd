extends RigidBody2D

const SPEEDUP = 400
const MAXSPEED = 30000

func _physics_process(delta):
	
	for body in get_colliding_bodies():
		#get_node("/root/world/").score += 5
		if body.has_method("destroy"):
			get_node("/root/world/").score += 5
			body.destroy()
		
		if body.get_name() == "paddle":
			var speed = linear_velocity.length()
			var direction = get_position() -body.get_node("Ancor").get_global_position()
			var velocity = direction.normalized()*min(speed+SPEEDUP,MAXSPEED*delta)
			set_linear_velocity(velocity)
	
	
	
	if get_position().y > get_viewport_rect().end.y:
		queue_free()
