using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    public GameObject HUDCanvas;
    private bool isPaused;
    public int kill;
    public Text noKill;

    public void Start()
    {
        kill = 0;
        
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (!isPaused)
            {
                Time.timeScale = 0;
                isPaused = true;
                HUDCanvas.SetActive(true);
                noKill.text = "Kills: "+kill.ToString();
            }
            else
            {

                isPaused = false;
                Time.timeScale = 1;
                HUDCanvas.SetActive(false);
            }
        }
    }

    
}
