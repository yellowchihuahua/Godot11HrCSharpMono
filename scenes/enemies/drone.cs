using Godot;
using System;

public partial class Drone : CharacterBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 direction = Vector2.Right;
		Velocity = new Vector2( (float)(direction.X*300), (float)(direction.Y*300) );
		MoveAndSlide();
	}
}
