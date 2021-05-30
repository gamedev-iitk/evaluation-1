extends MarginContainer

const first_scene = preload("res://scenes/world.tscn")


onready var selector_one =$CenterContainer/VBoxContainer/CenterContainer2/VBoxContainer/CenterContainer/HBoxContainer/Selector
onready var selector_two = $CenterContainer/VBoxContainer/CenterContainer2/VBoxContainer/CenterContainer2/HBoxContainer/Selector
onready var selector_three = $CenterContainer/VBoxContainer/CenterContainer2/VBoxContainer/CenterContainer3/HBoxContainer/Selector


var current_selection = 0

func _ready():
	current_selection(0)
	
func _process(delta):
	if Input.is_action_pressed("ui_down") and current_selection < 2: 
		current_selection += 1
		current_selection(current_selection)
	elif Input.is_action_pressed("ui_up") and current_selection > 0: 
		current_selection -= 1
		current_selection(current_selection)
	elif Input.is_action_pressed("ui_accept"):
		handle_selection(current_selection)

func handle_selection(current_selection):
	if current_selection == 0:
		get_parent().add_child(first_scene.instance())
		queue_free()
		
	elif current_selection == 2:
		get_tree().quit()

func current_selection(current_selection):
	selector_one.text = ""
	selector_two.text = ""
	selector_three.text = ""
	
	if current_selection == 0:
		selector_one.text = ">"
		
	elif current_selection == 1:
		selector_two.text = ">"
	elif current_selection == 2:
		selector_three.text = ">"


