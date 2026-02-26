using TMPro;
using UnityEngine;
using UnityEngine.AI;
using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class BossLogic : MonoBehaviour
{
    public int health = 100;


    public Slider healthBar;

    public TMP_Text healthText;

    

    public int maxHealth = 0;
    public Animator animator;
    private Boss boss;
    private NavMeshAgent navMeshAgent;

    bool isDead;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = health;
        boss = GetComponent<Boss>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health + " / " + health;
        healthBar.value = (float)health / (float)maxHealth;
        if (health <= 0 && isDead == false)
        {
            isDead = true;
            animator.SetTrigger("IsDead");
            boss.enabled = false;
            navMeshAgent.SetDestination(transform.position);
            navMeshAgent.enabled = false;
            //Destroy(gameObject, 7f);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.name.Contains("Sword"))
        {
            health = health - 25;
        }
    }
}
