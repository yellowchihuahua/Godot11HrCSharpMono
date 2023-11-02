using Godot;
using System;

public partial class Level : Node2D
{
	Node2D logo;
	Logo logoScript;

	String[] testArray = {"Test", "Hello", "stuff"};

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		logo = GetNode<Node2D>("Logo");
		logoScript = logo as Logo;

		logo.RotationDegrees = 90;

		foreach (string str in testArray) {
			GD.Print(str);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		logo.RotationDegrees += (float)(90*delta);
		
		if (logo.Position.X > 500) {
			logoScript.pos.X = 0;
		}

		GD.Print(Input.IsActionPressed("left"));
	}
}
