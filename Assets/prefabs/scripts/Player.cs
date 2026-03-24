using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int level = 3;

    public int health = 100;

    public float[] position;

    public bool hasstarted;

    public static Player instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;

        position[0] = data.position[0];
        position[1] = data.position[1];
        position[2] = data.position[2];
        
    }

    private void Start()
    {
        LoadPlayer();
    }
}
