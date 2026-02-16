using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public int health = 100;

    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            animator.SetBool("Dead", true);
            Destroy(gameObject, 7f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            health = health - 25;
        }
    }
}
