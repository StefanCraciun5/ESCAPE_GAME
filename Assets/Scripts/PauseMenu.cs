using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = true;

    public GameObject pauseMenuUI;

    /**  
     * Cette méthode permet de commencer la classe
     **/
    private void Start()
    {
        Pause();
    }

    /**  
     * Cette méthode permet d'actualiser la classe
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
     * Cette méthode permet de revenir au jeu
     **/
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    /**  
     * Cette méthode permet au jeu de s'arrêter
     **/
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

