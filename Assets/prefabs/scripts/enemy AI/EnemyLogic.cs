using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class EnemyLogic : MonoBehaviour
{
    public int health = 100;

    

    public Animator animator;
    private EnemyAI enemyAI;
    private NavMeshAgent navMeshAgent;
    private AudioSource audioSource;

    bool isDead;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyAI = GetComponent<EnemyAI>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && isDead == false)
        {
            isDead = true;
            animator.SetTrigger("IsDead");
            enemyAI.enabled = false;
            navMeshAgent.SetDestination(transform.position);
            navMeshAgent.enabled = false;
            //Destroy(gameObject, 7f);
           audioSource.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.name.Contains("Sword"))
        {
            health = health - 25;
        }
    }

    private void DisableEnemyMovement()
    {
       
    }
}
