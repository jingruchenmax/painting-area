using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MapModelEditor : EditorWindow
{
    public int width = 1;
    public int height = 1;
    public bool isTrue = false;
    public bool[,] map = new bool[0,0];
    private bool[] mapIndex = new bool[0];
    private bool[] mapStartIndex = new bool[0];
    private bool[] mapExitIndex = new bool[0];
    [MenuItem("Tool/LevelEditor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(MapModelEditor));
    }
    public void OnGUI()
    {
        width = EditorGUILayout.IntField("Width",width);
        height = EditorGUILayout.IntField("Height",height);
        isTrue = EditorGUILayout.Toggle("is wall default",isTrue);
        
        if (width != map.GetLength(0) || height != map.GetLength(1))
        {
            map = new bool[width, height];
            mapIndex = new bool[height * width];
            mapExitIndex = new bool[height * width];
            mapStartIndex = new bool[height * width];
            if (isTrue)
            {
                for (int i = 0; i < height * width; i++)
                {
                    mapIndex[i] = true;
                }
            }

        }



        ChangeArrayWidthAndHeight();
        if (GUILayout.Button("Create"))
        {
            PrintMap();
            PrintStart();
            PrintExit();
        }
    }

    void ChangeArrayWidthAndHeight()
    {
        EditorGUILayout.LabelField("Map");
        for (int j = 0; j < height; j++)
        {
            
            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < width; i++)
            {
                //  map[i, j] = mapIndex[i + j * width] ;
                mapIndex[i + j * width] = EditorGUILayout.Toggle(mapIndex[i + j * width]);
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.LabelField("Start");
        for (int j = 0; j < height; j++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < width; i++)
            {
                
                //  map[i, j] = mapIndex[i + j * width] ;
                mapStartIndex[i + j * width] = EditorGUILayout.Toggle(mapStartIndex[i + j * width]);
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.LabelField("Exit");
        for (int j = 0; j < height; j++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < width; i++)
            {
                
                //  map[i, j] = mapIndex[i + j * width] ;
                mapExitIndex[i + j * width] = EditorGUILayout.Toggle(mapExitIndex[i + j * width]);
            }
            EditorGUILayout.EndHorizontal();
        }
    }

    void PrintMap()
    {
        string output = "";
        for (int j = 0; j < height; j++)
        {
            output += "{";
            for (int i = 0; i < width; i++)
            {
                if (i != width - 1)
                {
                    if (mapIndex[i + j * width])
                        output += "1,";
                    else
                        output += "0,";
                }
                else
                {
                    if (mapIndex[i + j * width])
                        output += "1";
                    else
                        output += "0";
                }
            }
            if (j != height - 1)
            {
                output += "}," + "\n";
            }
            else
            {
                output += "}" + "\n";
            }


        }
        Debug.Log(output);
    }

    void PrintStart()
    {
        string output = "";

        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                {
                    if (mapStartIndex[i + j * width])
                    {
                        output = "{" + (i-6) + ",0," + (10-j) + "}";
                        break;
                    }
                }
            }
        }
        Debug.Log("START: " + output);
    }


    void PrintExit()
    {
        string output = "";

        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                {
                    if (mapExitIndex[i + j * width])
                    {
                        output = "{" + (i-6) + ",0," + (10-j) + "}";
                        break;
                    }
                }
            }
        }
        Debug.Log("EXIT: " + output);
    }
       
    
}
