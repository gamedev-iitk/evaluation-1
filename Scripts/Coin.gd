extends Area2D

func _on_Coin_body_entered(_body) :
	get_node("/root/World").score += 5
	queue_free()

