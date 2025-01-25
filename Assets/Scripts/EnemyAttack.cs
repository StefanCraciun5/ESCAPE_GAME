using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    TimerController timer;
    [SerializeField] float damage = 40f;


    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        timer = FindObjectOfType<TimerController>();
    }

    // Ceci permet de mettre du degat au joueur au moment ou le loup mord
    public void AttackHitEvent()
    {
        if (target == null) return;
        //timer.LoseTime();
        target.PlayerTakeDamage(damage);
        Debug.Log("bang bang");
    }
}