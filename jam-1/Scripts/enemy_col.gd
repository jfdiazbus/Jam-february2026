extends Node2D


const SPEED = 40

var direction = 1

@onready var ray_cast_right = $ColRight
@onready var ray_cast_left = $ColLeft

func _process(delta: float) -> void:
	if ray_cast_right.is_colliding():
		direction = -1
	if ray_cast_left.is_colliding():
		direction = 1
		
	position.x += direction * SPEED * delta
