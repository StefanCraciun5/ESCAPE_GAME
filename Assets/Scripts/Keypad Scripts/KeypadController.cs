using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadController : MonoBehaviour
{

    [SerializeField] Animator animator;
    public string password;
    public int passwordLimit;
    public Text passwordText;

    
    /**  
     * Cette méthode permet d'initialiser le mot de passe
     **/
    private void Start()
    {
        passwordText.text = "";
    }

    /**  
     * Cette méthode permet de rentrer le mot de passe
     **/
    public void PasswordEntry(string number)
    {
        if (number == "Clear")
        {
            Clear();
            return;
        }
        else if (number == "Enter")
        {
            Enter();
            return;
        }

        int length = passwordText.text.ToString().Length;
        if (length < passwordLimit)
        {
            passwordText.text = passwordText.text + number;
        }
    }

    /**  
     * Cette méthode permet d'effacer le mot de passe
     **/
    public void Clear()
    {
        passwordText.text = "";
        passwordText.color = Color.white;
    }

    /**  
     * Cette méthode permet d'entrer le mot de passe
     **/
    private void Enter()
    {
        if (passwordText.text == password)
        {
            ToggleBool("open");
            passwordText.color = Color.green;
            StartCoroutine(waitAndClear());
        }
        else
        {
        
            passwordText.color = Color.red;
            StartCoroutine(waitAndClear());
        }
    }

    /**  
     * Cette méthode permet d'attendre
     **/
    IEnumerator waitAndClear()
    {
        yield return new WaitForSeconds(0.75f);
        Clear();
    }

    /**  
     * Cette méthode permet d'activer si le code est vrai ou faux
     **/
    public void ToggleBool(string boolname)
    {
        animator.SetBool(boolname, !animator.GetBool(boolname));
    }


}
