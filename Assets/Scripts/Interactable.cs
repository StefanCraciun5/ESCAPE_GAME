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
     * Cette m�thode permet � la classe d'�tre appel�e par le syst�me
     **/
    void Start()
    {
        ID = Random.Range(0, 99999);
    }

    
}
