using Godot;
using System;

public partial class Player : CharacterBody2D
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		//input
		Vector2 direction = Input.GetVector("left", "right", "up", "down");
		Velocity = new Vector2( (float)(direction.X*500), (float)(direction.Y*500) );
		MoveAndSlide();

		//laser shooting input
		if (Input.IsActionPressed("primary action")) {
			GD.Print("shoot laser");
		}

		//grenade shooting input
		if (Input.IsActionPressed("secondary action")) {
			GD.Print("shoot grenade");
		}


	}
}
