using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5.0f;
    private Rigidbody objectrb;
    void Start()
    {
        objectrb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        objectrb.AddForce(Vector3.forward * -speed);
    }
}
