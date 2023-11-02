using Godot;
using System;

public partial class Level : Node2D
{


	String[] testArray = {"Test", "Hello", "stuff"};

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		foreach (string str in testArray) {
			GD.Print(str);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

}
