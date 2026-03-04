using UnityEngine;

public class HealthPickup : Interacable
{
    [SerializeField] private float health = 50f;

    public override void Interact(GameObject Player)
    {
        Player.AddComponent<PlayerControl>().Addhealth(health);
        
        base.Interact(Player);
    }
}
