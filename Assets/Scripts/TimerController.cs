using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    AudioSource m_sound;
    
    public static TimerController instance;

    public Text timeCounter;

    public TimeSpan timeplaying;
    private bool timerGoing;

    public float elapsedTime;

    DeathHandler target;


    /**  
     * Cette m�thode permet d'initialiser le compteur
     **/
    private void Awake()
    {
        instance = this;
    }

    /**  
     * Cette m�thode permet d'afficher le compteur
     **/
    void Start()
    {
        timeCounter.text = "Temps Restant: 00:00";
        timerGoing = false;
        BeginTimer();
        target = FindObjectOfType<DeathHandler>();
    }

    /**  
     * Cette m�thode permet de commcencer le compteur
     **/
    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 20f;

        StartCoroutine(UpdateTimer());
    }

    /**  
     * Cette m�thode permet la fin du compteur
     **/
    public void EndTimer()
    {
        timerGoing = false;
    }
    /**  
     * Cette m�thode permet de perdre du temps en cas de mauvaises r�ponses
     **/
    public void LoseTime()
    {
        elapsedTime -= 1;
    }
    /**  
     * Cette m�thode permet d'actualiser le compteur
     **/
    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            if (elapsedTime<= 0)
            {
                target.HandleLost();
            }
            elapsedTime -= (Time.deltaTime/60);
            timeplaying = TimeSpan.FromMinutes(elapsedTime);
            string timePlayingStr = "Temps Restant: " + timeplaying.ToString("mm':'ss");
            timeCounter.text = timePlayingStr;
            yield return null;
        }
    }
}
