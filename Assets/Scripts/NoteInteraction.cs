using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInteraction : MonoBehaviour
{
    public GameObject text;
    [SerializeField] Transform target;

    
    /**  
     * Cette méthode permet d'actualiser la classe
     **/
    private void Update()
    {
        float distanceToTarget = Mathf.Infinity;
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (distanceToTarget > 2)
        {
            text.gameObject.SetActive(false);
        }
    }

    /**  
     * Cette méthode permet de vérifier si l'intéraction à lieu ou pas
     **/
    public void ToggleBool()
    {

        if (text.gameObject.activeInHierarchy )
        {
            text.gameObject.SetActive(false);
        }
        else
        {
            text.gameObject.SetActive(true);
        }
    }
}
