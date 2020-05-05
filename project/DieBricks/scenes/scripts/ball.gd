extends RigidBody2D

const SPEEDUP=10
const MAXSPEED=400

func _ready():
	set_physics_process(true)
func _physics_process(delta):
	var bodies = get_colliding_bodies()
	for body in bodies:
		if body.is_in_group("bricks"):
			get_node("/root/world").score+=1
			body.queue_free()
			
		if body.get_name() == "paddle":
			var speed = linear_velocity.length()
			var direction = position - body.get_node("anchor").get_global_position()
			var velocity = direction.normalized()*min(speed+SPEEDUP,MAXSPEED)
			set_linear_velocity(velocity)

	if position.y > get_viewport_rect().end.y:
		queue_free()
		get_node("/root/world").score=0
		
	var group=get_tree().get_nodes_in_group("bricks").size()
	if group<1:
		queue_free()
