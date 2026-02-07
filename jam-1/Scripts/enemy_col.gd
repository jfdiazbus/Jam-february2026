extends Node2D


const SPEED = 80

var direction = 1

@onready var ray_cast_right = $ColRight
@onready var ray_cast_left = $ColLeft
@onready var an_sprite = $AnimatedSprite2D

func _process(delta: float) -> void:
	if ray_cast_right.is_colliding():
		direction = -1
		an_sprite.flip_h = true
	if ray_cast_left.is_colliding():
		direction = 1
		an_sprite.flip_h = false
		
	position.x += direction * SPEED * delta
