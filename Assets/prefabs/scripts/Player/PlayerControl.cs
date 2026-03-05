using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    
    public Slider healthBar;

    public TMP_Text healthText;

    public int health = 100;

    public int maxHealth = 0;

    public Animator animator;

    private PlayerInput playerInput;

    private void OnEnable()
    {
        OnPlayerDeath += DisablePlayerMovement;
    }

    private void OnDisable()
    {
        OnPlayerDeath -= DisablePlayerMovement;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = health;
        playerInput = GetComponent<PlayerInput>();
        EnabledPlayerMovement();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health + " / " + health;
        healthBar.value = (float)health / (float)maxHealth;
        
        if (health <= 0)
        {
            healthBar.gameObject.SetActive(false);
            animator.SetBool("isDead" , true);

            //Destroy(gameObject, 7f);  //dont like this but keeping it just in case. 
            Debug.Log(" You are daed not big suprise");
            OnPlayerDeath?.Invoke();
        }
    }

    //to be able to take dammage
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hit")
        {
            health = health - 25;
        }
    }

    public void Addhealth(int addedHealth)
    {
        health += addedHealth;
    }

    private void DisablePlayerMovement()
    {
        
        
        playerInput.DeactivateInput();
        Cursor.lockState = CursorLockMode.None;
        
    }

    private void EnabledPlayerMovement()
    {
       
        
        playerInput.ActivateInput();
        Cursor.lockState = CursorLockMode.Locked;
    }
}
