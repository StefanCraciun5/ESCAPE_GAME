using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    bool isOn = true;
    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    private void Update()
    {
        //Ceci permet au joueur d'avoir une lumière qui s'ouvre et qui se ferme 
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isOn == false)
            {
                myLight.range = 10;
                isOn = true;
            } else
            {
                myLight.range = 0;
                isOn = false;
            }
        }
    }
}
