 extends RigidBody2D

const SPEEDUP = 10
const MAXSPEED = 500

func _ready():
	set_physics_process(true);

func _physics_process(delta):
	var bodies = get_colliding_bodies()
	
	for body in bodies:
		if body.is_in_group("bricks"):
			get_node("/root/world").gold +=1
			body.queue_free()
		
		if body.get_name() == "paddle":
			var speed = get_linear_velocity().length()
			var direction = position - body.get_node("ancor").global_position
			var velocity = direction.normalized()*min(speed+SPEEDUP, MAXSPEED)
			set_linear_velocity(velocity)
			print(str(speed+SPEEDUP))
	
	if position.y > get_viewport_rect().end.y:
		print("Ball Died.")
		queue_free()
