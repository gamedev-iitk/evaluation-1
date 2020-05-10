extends RigidBody2D

export var SPEEDUP = 10
const MAXSPEED = 1000

const coin_scene = preload ("res://Childe Scenes/Coin.tscn")

func _ready():
	set_physics_process(true)
	
# warning-ignore:unused_argument
func _physics_process(delta):
	var bodies = get_colliding_bodies()
	
	for body in bodies:
		if body.is_in_group("Bricks"):
			get_node("/root/World").score += 1
			var pos = body.position
			body.queue_free()
			
			var coin = coin_scene.instance()
			coin.set_position(pos)
			get_tree().get_root().add_child(coin)
		
		if body.get_name() == "Paddle":
			var speed = get_linear_velocity().length()
			var direction = get_position() - body.get_node("Ancor").get_global_position()
			var velocity = direction.normalized() * min (speed + SPEEDUP, MAXSPEED)
			set_linear_velocity(velocity)
	
	if get_position().y > get_viewport_rect().end.y:
		queue_free()
