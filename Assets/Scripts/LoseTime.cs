using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class LoseTime : MonoBehaviour
{
    TimerController timer;

    /**  
     * Cette m�thode permet de commencer la classe
     **/
    void Start()
    {
        timer = FindObjectOfType<TimerController>();
    }
    /**  
     * Cette m�thode permet la perte de temps
     **/
    public void LoseTimee()
    {
        timer.LoseTime();
    }
}
