using UnityEngine;
using UnityEditor;
using System.Collections;

public class MazeGenerator : EditorWindow {

	public Maze mazePrefab;

	public Player playerPrefab;

	private Maze mazeInstance;

	private Player playerInstance;

	[MenuItem("Tools/Maze Generator")]
	public static void ShowWindow()
    {
		GetWindow(typeof(MazeGenerator));
    }
	
	private void OnGUI () 
	{
		GUILayout.Label("Maze Generator",EditorStyles.boldLabel);

		mazePrefab = EditorGUILayout.ObjectField("Maze Prefeb", mazePrefab, typeof(Maze), false) as Maze;
		playerPrefab = EditorGUILayout.ObjectField("Player Prefeb", playerPrefab, typeof(Player), false) as Player;

        if (GUILayout.Button("Create"))
        {
			BeginGame();

		}
	}

	private void BeginGame () {
		Camera.main.clearFlags = CameraClearFlags.Skybox;
		Camera.main.rect = new Rect(0f, 0f, 1f, 1f);
		mazeInstance = Instantiate(mazePrefab) as Maze;
		mazeInstance.QuickGenerate();
		playerInstance = Instantiate(playerPrefab) as Player;
		playerInstance.SetLocation(mazeInstance.GetCell(mazeInstance.RandomCoordinates));
		Camera.main.clearFlags = CameraClearFlags.Depth;
		Camera.main.rect = new Rect(0f, 0f, 0.5f, 0.5f);
	}


}