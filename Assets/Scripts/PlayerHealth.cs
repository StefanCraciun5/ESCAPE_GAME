using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float pHitpoints = 100f;
    private Transform tPosInitiale;
    private Vector3 posInitiale;

    /**  
     * Cette méthode permet de commencer la classe
     **/
    private void Start()
    {
        tPosInitiale = gameObject.transform;
        posInitiale = gameObject.transform.position;
    }
    /**  
     * Cette méthode permet au joueur de prendre du dommage
     **/
    public void PlayerTakeDamage(float damage)
    {
        pHitpoints -= damage;
        if (pHitpoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }

    }
    /**  
     * Cette méthode permet de réinitialiser la vie du joueur 
     **/
    public void PlayerReset()
    {
        pHitpoints = 100;
        gameObject.transform.position = posInitiale;
    }
}
