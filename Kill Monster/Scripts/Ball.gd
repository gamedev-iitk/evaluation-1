extends RigidBody2D

export var speedup = 5
const MAXSPEED = 500

func _ready():
	set_physics_process(true)
	
func _physics_process(delta):
	var bodies = get_colliding_bodies()

	for body in bodies:
		if body.is_in_group("Monsters"):
			get_node('/root/World').kills += 1
			get_node('/root/World').score += 10
			body.queue_free()
		elif body.is_in_group("Gods"):
			get_node('/root/World').kills += 1
			get_node('/root/World').score += 5
			body.queue_free()
		
		if body.get_name() == 'Paddle':
			var speed = linear_velocity.length()
			var direction = get_position() - body.get_node('Ancor').get_global_position()
			var velocity = direction.normalized()*min(speed+speedup, MAXSPEED)
			set_linear_velocity(velocity)
	
	if get_position().y > get_viewport_rect().end.y:
		queue_free()
		get_node('/root/World').score -= 5
