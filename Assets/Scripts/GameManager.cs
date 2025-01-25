using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    TimerController timer;

    // Commence le timer 
    void Start()
    {

        timer.BeginTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
