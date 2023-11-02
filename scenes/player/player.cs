using Godot;
using System;

public partial class player : Node2D
{
	Node2D level;
	Level levelScript;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		levelScript = GetNode<Node2D>("..") as Level;
		//levelScript = level as Level;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		levelScript.TestFunction();
		//input
		Vector2 direction = Input.GetVector("left", "right", "up", "down");
		Position += new Vector2( (float)(direction.X*200*delta), (float)(direction.Y*200*delta) );

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
