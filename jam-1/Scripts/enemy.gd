extends enemy

const SPEED = 40

var direction = 1

func _process(delta: float) -> void:
	position.x += SPEED * delta
