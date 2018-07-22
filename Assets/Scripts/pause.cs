using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour {
    static GameObject pausePanel;

    // Set gameObject as pausePanel
    void Start () {
        pausePanel = gameObject;
        pausePanel.SetActive(false);
    }
	
	// set "P" keyListener
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ContinueGame();
        }
    }

    public static void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    private void ContinueGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
}
