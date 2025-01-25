using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{

//cette m�thode sert a modifier les �tats des animations
    public Animator animator;

    public void ToggleBool(string boolname)
    {
        animator.SetBool(boolname, !animator.GetBool(boolname));
    }
}
