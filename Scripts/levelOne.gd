extends Node2D

var score = 0 setget set_score

func set_score(value):
	if get_position().y >  get_viewport_rect().end.y:
		score = 0
	else:
		score = value
	get_node("Label").set_text("Robots : "+str(score))
