using System;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public int level;
    public int health;
    public float[] position;
    public bool hasstarted;

    public PlayerData (Player player)
    {
        level = player.level;
        health = player.health;
        hasstarted = player.hasstarted;

        position = new float[3];
        position[0] = player.position[0];
        position[1] = player.position[1];
        position[2] = player.position[2];
    }

    public PlayerData()
    {
        level = 1;
        health = 250;
        hasstarted= false;
        position = new float[3];
        position[0] = 0;
        position[1] = 0;
        position[2] = 0;
    }


}
