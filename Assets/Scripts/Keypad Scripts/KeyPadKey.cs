using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadKey : MonoBehaviour
{
    public string key;

    /**  
     * Cette m�thode permet d'entrer le bon mot de passe
     **/
    public void SendKey()
    {
        this.transform.GetComponentInParent<KeypadController>().PasswordEntry(key);
    }

}
