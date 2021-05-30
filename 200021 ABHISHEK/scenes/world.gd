extends YSort

var score = 0 setget set_score 

func set_score(value):
	score = value
	get_node("score").set_text("score: "+str(score))
