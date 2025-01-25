using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactor : MonoBehaviour
{
    UnityEvent onInteract;
    public LayerMask interacableLayerMask = 8;
    public Interactable interactable;
    public Image interactImage;
    public Sprite defaultIcon;
    public Sprite defaultInteractIcon;


    /**  
     * Cette méthode permet d'intéragir entre les personnages et les objets
     **/
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2, interacableLayerMask))
        {
            if (hit.collider.GetComponent<Interactable>() != false)
            {
                if (interactable == null || interactable.ID != hit.collider.GetComponent<Interactable>().ID)
                {
                    interactable = hit.collider.GetComponent<Interactable>();
                   
                } 
                if(interactable.interactIcon!= null)
                {
                    interactImage.sprite = interactable.interactIcon;
                }
                else
                {
                    interactImage.sprite = defaultInteractIcon;
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.onInteract.Invoke();
                }
            }
        }
        else
        {
            if(interactImage.sprite != defaultIcon)
            {
                interactImage.sprite = defaultIcon;
                Debug.Log("default");
            }
        }
    }
}
