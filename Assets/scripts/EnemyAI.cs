using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject target;
    private NavMeshAgent ai;
    bool isPlayerInRange;
    public Transform patrolPoint;
    public enum EnemyState { Idle, Potrol, Chase, Attack }
    public EnemyState enemyState;
    private Animator anim;
    private float distanceToTarget;
    Coroutine idleToPatrol;
   


    private void Start()
    {
        ai = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        enemyState = GetComponent<EnemyState>();
        distanceToTarget = Mathf.Abs(Vector3.Distance(target.transform.position, transform.position));
       

    }
    IEnumerator SwitchToPatrol()
    {
        yield return new WaitForSeconds(5);
        enemyState = EnemyState.Potrol;
        idleToPatrol = null;
    }
    
    private void SwitchState(int newstate)
    {
        if (anim.GetInteger("State") != newstate)
            anim.SetInteger("State", newstate);
    }


    // Update is called once per frame
    void Update()
    {

       // if (isPlayerInRange){ ai.SetDestination(target.transform.position); } put code in case block
        
           
       
        
        distanceToTarget = Mathf.Abs(Vector3.Distance(target.transform.position, transform.position));
        switch (enemyState) 
        { 
            case EnemyState.Idle:
                switchState(0);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    private void OnDrawGizmos()
        // makes the radies of the colider of the enimies more clear
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 10f);
    }

   
    
}
