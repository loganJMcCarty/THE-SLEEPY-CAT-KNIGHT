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
            check.lastCheckPointPos = transform.position;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        check = GameObject.FindGameObjectWithTag("Check").GetComponent<CheckPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
