extends Node2D

var score = 0 setget set_score

func set_score(value):
	score = value
	get_node("Score").set_text("Score: "+str(score))
	
var coins = 0 setget set_coins

func set_coins(value):
	coins = value
	get_node("Coins").set_text("Coins: "+str(coins))
