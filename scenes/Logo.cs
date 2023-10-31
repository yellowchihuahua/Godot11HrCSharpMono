using Godot;
using System;


public partial class Logo : Sprite2D //extends Sprite2D
{
	public Vector2 pos = new Vector2(0, 0);
	const int speed = 400;

	int testScale = 1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		pos = new Vector2(100, 200);
		Position = pos;

		//float testRotation = 45f;
		//RotationDegrees = testRotation;

		testScale = 2;
		Scale = new Vector2(testScale, testScale);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		pos.X += (float)(speed*delta);
		Position = pos;

		//testScale += 1;
		//Scale = new Vector2(testScale, testScale);
	}
}
