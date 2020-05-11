extends Node2D

var score = 0 setget set_score
var coin = 0 setget set_coin

func set_score(value):
	score = value
	get_node("Score").set_text("Score: "+str(score))
	
func set_coin(num):
	coin = num
	get_node("Collected").set_text("Coins: "+str(coin))
	
	
	
