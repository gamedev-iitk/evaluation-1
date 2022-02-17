extends Node2D

var gold = 0 setget set_gold

func set_gold(value):
	gold = value
	get_node("gold").set_text("gold: "+str(gold))
