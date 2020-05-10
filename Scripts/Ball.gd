extends RigidBody2D

const speedup = 10
const maxspeed = 400

func _ready():
	set_physics_process(true)

func _physics_process(delta):
	var bodies = get_colliding_bodies()
	for body in bodies:
		if body.is_in_group("Coins"):
			get_node("/root/World").score +=10
			body.queue_free()
			get_node("/root/World/Paddle").countcoins -= 1
		if get_node("/root/World/Paddle").countcoins == 0:
			queue_free()
			get_node("/root/World/status").set_text("GAME OVER")
		if body.get_name() == "Paddle":
			var speed = get_linear_velocity().length()
			var direction = get_position() - body.get_node("Ancor").get_global_position()
			var velocity = direction.normalized()*min(speed+speedup, maxspeed)
			set_linear_velocity(velocity)
	if get_position().y > get_viewport_rect().end.y :
		queue_free()
		get_node("/root/World/Paddle").checkball = 0
		get_node("/root/World").score = 0
