using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leguar.TotalJSON;
using System.Linq;
using System.IO;
public class PlayerScore : MonoBehaviour
{
    List<PlayerData> data;
    ParseStringSettings parseSetting;
    // Start is called before the first frame update
    void Start()
    {
        data = new List<PlayerData>();
        parseSetting = new ParseStringSettings();
        parseSetting.AllowNonWhiteCharactersAfterObject = true;
        LoopDirectory();
       // LoopPlayerData();

    }

    void LoopDirectory()
    {
        // string path = Application.dataPath + "/" + "Resources/";
        string path = "D:/Myfiles_Dell/IMGD/Github/data";
        Debug.Log(path);
        foreach (string dirFile in Directory.GetFiles(path))
        {
            // string lastFolderName = Path.GetFileName(dirFile);
            // Debug.Log(dirFile);

            JSON jsonFromFile;
            if (File.Exists(dirFile))
            {
                using (StreamReader reader = new StreamReader(dirFile))
                {
                    string json = reader.ReadToEnd();
                    jsonFromFile = JSON.ParseString(json,parseSetting);
                    PlayerData participantData = new PlayerData();
                    participantData.playerDatas = new List<PlaythroughData>();
                    participantData = jsonFromFile.Deserialize<PlayerData>();
                    data.Add(participantData);
                }
            }
            else
                Debug.LogWarning("file not found");

        }
    }
    void LoopPlayerData()
    {
        foreach (PlayerData player in data)
        {
            int highestLevel;
            highestLevel = player.playerDatas[player.playerDatas.Count - 1].level;
            print(highestLevel);
        }
    }
    // Update is called once per frame

}
