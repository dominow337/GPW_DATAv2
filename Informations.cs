using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Informations : MonoBehaviour
{
    public static bool VisualizationPaused = false;

    public GameObject PauseUI;


    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Z))
        {
            if (VisualizationPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        VisualizationPaused = false;
    }

    void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        VisualizationPaused = true;

    }
}
