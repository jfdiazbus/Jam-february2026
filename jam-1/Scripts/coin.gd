extends Area2D


@onready var game_manager = %Game_Manager
@onready var animate_pu = $AnimationPlayer

func _on_body_entered(_body: Node2D) -> void:
	game_manager.add_point()
	animate_pu.play("pickup")
