
extends RigidBody2D
const SPEEDUP=6
const MAXSPEED=400
func _ready():
	set_fixed_process(true)
func _fixed_process(delta):
	var bodies = get_colliding_bodies()
	for body in bodies:
		if body.is_in_group("Bricks"):
			get_node("/root/World").score+=5
			body.queue_free()

		if body.get_name()=="Paddle":
			var speed=get_linear_velocity().length()
			var direction=get_pos()-body.get_node("Anchor").get_global_pos()
			var velocity=direction.normalized()*min(speed+SPEEDUP,MAXSPEED)
			set_linear_velocity(velocity)
			
		if body.is_in_group("Arrow"):
			queue_free()
			get_node("/root/World").score=0
	if get_pos().y>get_viewport_rect().end.y:
		queue_free()
		get_node("/root/World").score=0


