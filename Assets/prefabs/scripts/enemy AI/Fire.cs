using UnityEngine;

public class Fire : MonoBehaviour
{
    private Transform player;
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((transform.position - player.position) * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        { 
            
            // need to removehealth from player

        }
        Destroy(gameObject);
    }

}
