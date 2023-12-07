using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Signal] public delegate void PlayerInputLaserEventHandler(Node2D body);
	[Signal] public delegate void PlayerInputGrenadeEventHandler(Node2D body);

	bool _canLaser = true;
	bool _canGrenade = true;

	Timer _laserTimer;
	Timer _grenadeTimer;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_laserTimer = GetNode<Timer>("LaserTimer");
		_grenadeTimer = GetNode<Timer>("GrenadeTimer");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		//input
		Vector2 direction = Input.GetVector("left", "right", "up", "down");
		Velocity = new Vector2( (float)(direction.X*500), (float)(direction.Y*500) );
		MoveAndSlide();

		//laser shooting input
		if (Input.IsActionPressed("primary action") && _canLaser) {
			_canLaser = false;
			_laserTimer.Start();
			EmitSignal(SignalName.PlayerInputLaser);
		}

		//grenade shooting input
		if (Input.IsActionPressed("secondary action") && _canGrenade) {
			_canGrenade = false;
			_grenadeTimer.Start();
			EmitSignal(SignalName.PlayerInputGrenade);
		}
	}

	//connected to WeaponTimer
	private void OnLaserTimerTimeout(){
		_canLaser = true;
	}

	private void OnGrenadeTimerTimeout(){
		_canGrenade = true;
	}
}
