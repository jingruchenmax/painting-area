using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Leguar.TotalJSON;
using System.IO;
[Serializable]
public class PlaythroughData
{
    public int level; // start from 1
    public int number; // start from 1
    public float timeSpent = 0f;
    public float areaCovered = 0f;
    public bool isWin;

}

public class PlayerData
{
    public List<PlaythroughData> playerDatas;
}


public class DataCollecting: MonoBehaviour
{
   // public string playerName;
    public int level = 1;
    int gameCount = 1;
    float gameStartTime = 0;
    PlayerData playerData;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        NewPlayer();
    }

    public void NewPlayer()
    {
        playerData = new PlayerData();
        playerData.playerDatas = new List<PlaythroughData>();
        level = 1;
        gameCount = 1;
        gameStartTime =0;

    }
    public void AddNewGame(int level, int number, float timeSpend, float areaCovered, bool isWin)
    {
        PlaythroughData data = new PlaythroughData();
        data.level = level;
        data.number = number;
        data.timeSpent = timeSpend;
        data.areaCovered = areaCovered;
        data.isWin = isWin;
        playerData.playerDatas.Add(data);
    }

    public void AddNewGame(float areaCovered,bool isWin)
    {
        PlaythroughData data = new PlaythroughData();
        data.level = level;
        data.number = gameCount;
        data.timeSpent = Time.time-gameStartTime;
        data.areaCovered = areaCovered;
        data.isWin = isWin;
        playerData.playerDatas.Add(data);
        print(data.timeSpent);
    }


    public void NextLevel()
    {
        level++;
        gameCount = 1;
        NewGame();
    }

    public void ReplayLevel()
    {
        gameCount++;
        NewGame();
    }

    void NewGame()
    {
        gameStartTime = Time.time;
    }

    public void WriteToDoc()
    {
        JSON json = JSON.Serialize(playerData);
        string jsonString = json.CreateString();
        FileStream fs = new FileStream(Application.dataPath + "/Resources/" + DateTime.Now.Hour +"_"+ DateTime.Now.Minute + ".json", FileMode.OpenOrCreate);
        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.Write(jsonString);
        }
    }
}
