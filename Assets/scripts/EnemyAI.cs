using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject target;
    private NavMeshAgent ai;
    bool isPlayerInRange;


    void Start()
    {
        ai = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        if (isPlayerInRange)
        {
            ai.SetDestination(target.transform.position);
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
}
