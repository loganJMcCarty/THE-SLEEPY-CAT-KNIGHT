using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Boss : MonoBehaviour
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
        enemyState = EnemyState.Idle;
        distanceToTarget = Mathf.Abs(Vector3.Distance(target.transform.position, transform.position));


    }
    IEnumerator SwitchToPatrol()
    {
        yield return new WaitForSeconds(3);
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


        distanceToTarget = Mathf.Abs(Vector3.Distance(target.transform.position, transform.position));
        switch (enemyState)
        {
            case EnemyState.Idle:
                SwitchState(0);

                ai.SetDestination(transform.position);

                if (idleToPatrol == null)
                {
                    idleToPatrol = StartCoroutine(SwitchToPatrol());
                }
                break;

            case EnemyState.Potrol:
                float distanceToPatrolPoint = Mathf.Abs(Vector3.Distance(patrolPoint.position, transform.position));
                if (distanceToPatrolPoint > 3)
                {
                    SwitchState(1);
                    ai.SetDestination(patrolPoint.position);
                }
                else
                {
                    SwitchState(0);
                }

                if (distanceToTarget <= 10)
                {

                    enemyState = EnemyState.Chase;
                }

                break;

            case EnemyState.Chase:


                SwitchState(2);
                ai.SetDestination(target.transform.position);

                if (distanceToTarget < 6)
                {
                    enemyState = EnemyState.Attack;
                }

                else if (distanceToTarget >= 15)
                {
                    enemyState = EnemyState.Idle;
                }
                break;

            case EnemyState.Attack:
                SwitchState(3);

                if (distanceToTarget > 15)
                {
                    enemyState = EnemyState.Idle;
                }
                break;
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
        Gizmos.DrawSphere(transform.position, 100f);
    }
}
