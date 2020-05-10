extends Node2D

var coins = -2
var kills = 0 setget set_kills
var score = 0 setget set_score

onready var coin_label = get_node("CanvasLayer/Coins Collected")
onready var kill_label = get_node("CanvasLayer/Kills")
onready var score_label = get_node("CanvasLayer/Score")

func _on_coin_coin_collected():
	coins += 1
	coin_label.clear()
	coin_label.add_text('Coins: '+ str(coins))

func set_score(value):
	score = value
	score_label.clear()
	score_label.add_text('Score: '+ str(score))

func set_kills(value):
	kills = value
	kill_label.clear()
	kill_label.add_text('Kills: '+ str(kills))
