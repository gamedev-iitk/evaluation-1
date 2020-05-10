extends RigidBody2D




# Called when the node enters the scene tree for the first time.
func _ready():
	

func body_enter(body):
	if(body.get_name()) == "ground":
	set_bounce(0)
