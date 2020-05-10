extends RigidBody2D

func _ready():
	set_physics_process(true)
	
func _physics_process(delta):
	var bodies = get_colliding_bodies()
	for body in bodies:
		if body.get_name() == "Paddle":
			get_node("/root/World").coins += 1
			queue_free()
