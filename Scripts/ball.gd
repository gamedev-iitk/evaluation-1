extends RigidBody2D

var count = 0
const SPEEDUP = 40
const MAXSPEED = 4000


func _physics_process(delta):
	var bodies = get_colliding_bodies()
	for body in bodies:
		if body.is_in_group("brick"):
			get_node("/root/world").score += 1
			body.queue_free()
		
		if body.get_name() == "Paddle":
			var speed = get_linear_velocity().length()
			var direction = get_position() - body.get_node("Ancor").get_global_position()
			var velocity = direction.normalized()*min(speed+ SPEEDUP , MAXSPEED)
			set_linear_velocity(velocity)
	
	if get_position().y >  get_viewport_rect().end.y:
		queue_free()
		get_node("/root/world").score = 0
		print("Ball died")

var score = 0 setget set_score

func set_score(value):
	if get_position().y >  get_viewport_rect().end.y:
		score = 0
	else:
		score = value
	get_node("Label").set_text("Robots : "+str(score))
