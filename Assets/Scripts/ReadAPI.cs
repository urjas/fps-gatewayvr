using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using UnityEngine.SceneManagement;
public class ReadAPI : MonoBehaviour {
    string url;
    public void Awake()
    {
        url = "https://api.myjson.com/bins/wzde8";

    }

    public void ReadFromAPI() {
        StartCoroutine("LoadData");

    }

    IEnumerator LoadData()
    {
        // Start a download of the given URL
        using (WWW www = new WWW(url))
        {
            // Wait for download to complete
            yield return www;
            string json = www.text;
            JsonData data = JsonMapper.ToObject(json);
            PlaneData.PlaneLength = (float)data["GVR"]["arenaLength"].GetNatural();
            PlaneData.PlaneWidth = (float)data["GVR"]["arenaWidth"].GetNatural();
            PlaneData.ZombieSpeed = (float)data["GVR"]["zombieSpeed"].GetReal();
            PlaneData.PlayerHP = (float)data["GVR"]["playerHP"].GetNatural();
            PlaneData.ZombieHP = (float)data["GVR"]["zombieHP"].GetNatural();
            LoadNewScene();


        }
    }

    void LoadNewScene() {
        SceneManager.LoadSceneAsync("Main");
    }
}
