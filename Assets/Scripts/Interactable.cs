using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteract;
    public int ID;
    public Sprite interactIcon;

    /**  
     * Cette méthode permet à la classe d'être appelée par le système
     **/
    void Start()
    {
        ID = Random.Range(0, 99999);
    }

    
}
