using Godot;
using System;

public partial class Main : Node
{
	[Export]
	public PackedScene SnakeSegment;
	
	// Game variables
	private int _score = 0;
	private bool _gameStarted = false;
	
	// Grid variables
	// Number of cells in each row and column of the grid
	private readonly int _gridSize = 20;
	// Size of each cell in pixels
	private readonly int _cellSize = 50;
	
	// Snake variables
	Vector2[] oldData;
	Vector2[] newData;
	Vector2[] snake; 
	
	// Movement variables
	Vector2 startPos = new Vector2(9, 9);
	Vector2 up = new Vector2(0, -1);
	Vector2 down = new Vector2(0, 1);
	Vector2 left = new Vector2(-1, 0);
	Vector2 right = new Vector2(1, 0);
	Vector2 direction;
	bool canMove;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		NewGame();
	}

	private void NewGame() {
		_score = 10;
		GetNode("HUD").GetNode<Label>("Score").Text = "Score: " + _score;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
