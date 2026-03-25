using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Rest : MonoBehaviour
{
    private CheckPoint check;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            check.lastCheckPointPos = transform.position; // prob intsance
            Player.instance.position[0] = transform.position.x;
            Player.instance.position[1] = transform.position.y;
            Player.instance.position[2] = transform.position.z;
            Player.instance.SavePlayer();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        check = CheckPoint.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
