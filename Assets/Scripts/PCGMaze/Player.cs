using UnityEngine;

public class Player : MonoBehaviour {

	private MazeCell currentCell;

	private Maze maze;

	public void Start()
	{
		maze = GameObject.Find("MazePlain(Clone)").GetComponent<Maze>();

		currentCell = maze.cells[(Mathf.FloorToInt(transform.position.x) + (int)(1 / 2f * maze.size.x)), (Mathf.FloorToInt(transform.position.z) + (int)(1 / 2f * maze.size.z))];
	}
	public void SetLocation(MazeCell cell) {
		if (currentCell != null) {
			currentCell.OnPlayerExited();
		}
		currentCell = cell;
		currentCell.OnPlayerEntered();
	}



	public void Update() {
		
		if (true) {
			MazeCell cell = maze.cells[(Mathf.FloorToInt(transform.position.x) + (int)(1/2f * maze.size.x)), (Mathf.FloorToInt(transform.position.z) + (int)(1/2f * maze.size.z))];

			if (currentCell.coordinates.x != cell.coordinates.x || currentCell.coordinates.z != cell.coordinates.z)
			{
				currentCell.OnPlayerExited();
				currentCell = cell;
				currentCell.OnPlayerEntered();
			}

		}
		//Debug.Log((transform.position.x+1/2 * maze.size.x) + "  " + (transform.position.z + 1 / 2 * maze.size.z));
		//Debug.Log(maze.cells.Length);
	}
}