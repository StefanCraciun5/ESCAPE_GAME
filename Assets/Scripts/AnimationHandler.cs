using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{

//cette méthode sert a modifier les états des animations
    public Animator animator;

    public void ToggleBool(string boolname)
    {
        animator.SetBool(boolname, !animator.GetBool(boolname));
    }
}
