using Godot;
using System;

public partial class Level : Node2D
{


	String[] _testArray = {"Test", "Hello", "stuff"};

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		foreach (string str in _testArray) {
			GD.Print(str);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	private void OnGatePlayerEnteredGate(Node2D body){
		GD.Print("Player has entered gate - from Level" + body);
	}

	private void OnPlayerPlayerInputLaser(){
		GD.Print("player input laser - from Level");
	}

	private void OnPlayerPlayerInputGrenade(){
		GD.Print("player input grenade - from Level");
	}

	//private void OnArea2DEntranceBodyEntered(Node2D body){
	//	GD.Print("Body Entered");
	//	GD.Print(body.Name);
	//}
//
	//private void OnArea2DEntranceBodyExited(Node2D body){
	//	GD.Print("Body Exited");
	//	GD.Print(body.Name);
	//}

}
