using Godot;
using System;

public partial class Main : Node
{
	static int score = 0;
	static bool gameStarted = false;
	// Number of cells in each row and column of the grid
	static int gridSize = 20;
	// Size of each cell in pixels
	static int cellSize = 50;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
