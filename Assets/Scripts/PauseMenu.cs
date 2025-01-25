using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = true;

    public GameObject pauseMenuUI;

    /**  
     * Cette m�thode permet de commencer la classe
     **/
    private void Start()
    {
        Pause();
    }

    /**  
     * Cette m�thode permet d'actualiser la classe
     **/
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Pause();
            }
        }
    }

    /**  
     * Cette m�thode permet de revenir au jeu
     **/
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    /**  
     * Cette m�thode permet au jeu de s'arr�ter
     **/
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

