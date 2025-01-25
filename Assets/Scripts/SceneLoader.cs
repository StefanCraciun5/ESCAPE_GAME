using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas gameWonCanvas;
    [SerializeField] Canvas gameLostCanvas;

    /**  
     * Cette méthode permet de commencer la classe
     **/
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
       
    }
    /**  
     * Cette méthode permet de réapparaître
     **/
    public void RespawnGame()
    {
        gameOverCanvas.enabled = false;
        target.PlayerReset();
        Time.timeScale = 1;
    }
    /**  
     * Cette méthode permet de quitter
     **/
    public void QuitGame()
    {
        Application.Quit();
    }
    /**  
     * Cette méthode permet de rejouer
     **/
    public void ReloadGame()
    {
        gameWonCanvas.enabled = false;
        SceneManager.LoadScene(0);
    }
    /**  
     * Cette méthode permet de recommcencer le temps
     **/
    public void ReloadGameTime()
    {
        gameLostCanvas.enabled = false;
        SceneManager.LoadScene(0);
    }
}
