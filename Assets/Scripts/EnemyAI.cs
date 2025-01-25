using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] float chaseRange = 5f;
    [SerializeField] Transform target;
    [SerializeField] float turnSpeed = 5f;

    NavMeshAgent navMeshAgent;

    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;
    private Vector3 posInitiale;
    private Transform tPosInitiale;

    EnemyAttack attack;

    void Start()
    {
        attack = FindObjectOfType<EnemyAttack>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        posInitiale = transform.position;
        tPosInitiale = transform;
    }

    void Update()
    {
        // prend la distance entre le loup et le joueur 
        distanceToTarget = Vector3.Distance(target.position, transform.position);

         if (distanceToTarget <= chaseRange)
        {
           
            EngageTarget();
        } 
        else
        {
           // isProvoked = false;

            // ceci permet au loup de retourner à sa position initiale 
            navMeshAgent.SetDestination(posInitiale);
            FaceTarget(tPosInitiale, transform);
            if (transform == tPosInitiale)
            {
                GetComponent<Animator>().SetBool("Idle", true);
                GetComponent<Animator>().SetBool("move", false);
                GetComponent<Animator>().SetBool("attack", false);
            }
            
        }
    }
    public void OnDamageTaken()
    {
        isProvoked = true;
    }

    //Ceci colorie les gizmos des loups
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    // Ceci enclanche les animations d'attaque du loup
    private void EngageTarget()
    {
        FaceTarget(target,transform);
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            GetComponent<Animator>().SetBool("attack", false);
            ChaseTarget();
        }


        else if (distanceToTarget <= navMeshAgent.stoppingDistance) 
        {
          AttackTarget();
        }
    }
    // Ceci permet au loup d'attaquer le joueur 
    private void AttackTarget()
    {
        GetComponent<Animator>().SetBool("attack", true);
    }

    //Ceci permet au loup de suivre le joueur 
    private void ChaseTarget()
    {
        if (distanceToTarget <= chaseRange)
        {
            GetComponent<Animator>().SetTrigger("move");
            navMeshAgent.SetDestination(target.position);
        }
        else {
            navMeshAgent.SetDestination(posInitiale);
        }
    }

    // Ceci permet au loup de regarder le joueur 
    private void FaceTarget(Transform cible, Transform obj)
    {
        Vector3 direction = (cible.position - obj.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        obj.rotation = Quaternion.Slerp(obj.rotation, lookRotation, Time.deltaTime * turnSpeed);
       
    }
}
