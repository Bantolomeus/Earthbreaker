using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonSaving : MonoBehaviour
{
    public Hero hero;

    private PlayerData playerData;
    private string persistentPath;

    public void saveData(){
        string savePath = persistentPath;

        Debug.Log("Saving Data at " + savePath);
        string json = JsonUtility.ToJson(playerData);
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(json);
    }

    public PlayerData loadData(){
        using StreamReader reader = new StreamReader(persistentPath);
        string json = reader.ReadToEnd();

        PlayerData data = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log(data.ToString());
        return data;
    }

    // Start is called before the first frame update
    void Start()
    {   
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "PlayerDataSaveFile.json";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            playerData = hero.getHeroData();
            saveData();
        }

        if(Input.GetKeyDown(KeyCode.L)){
            loadData();
        }
    }

}
