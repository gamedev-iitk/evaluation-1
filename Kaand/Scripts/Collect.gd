extends Area2D


func _on_coin_body_entered(body):
	get_node("/root/World").coin += 1
	queue_free()


