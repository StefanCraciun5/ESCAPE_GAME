using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
  
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas gameWonCanvas;
    [SerializeField] Canvas gameLostCanvas;

    private void Start()
    {
        gameOverCanvas.enabled = false;
        gameWonCanvas.enabled = false;
        gameLostCanvas.enabled = false;
    }

    //Cette méthode sert a gérer l'évenement de mort et de montrer le canvas de mort 
    public void HandleDeath()
    { 
        
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    //Cette méthode sert a gérer l'évenement de mort par temps et de montrer le canvas de mort par temps
    public void HandleLost()
    {
        gameLostCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    //Cette méthode sert a gérer l'évenement de victoire et de montrer le canvas de victoire 
    public void HandleWin()
    {
        gameWonCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
