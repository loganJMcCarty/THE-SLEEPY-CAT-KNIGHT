using UnityEngine;

public class HealthPickup : Interacable
{
    [SerializeField] private int health = (int)50f;

    public override void Interact(GameObject PlayerArmature)
    {
        PlayerArmature.GetComponent<PlayerControl>().Addhealth(health);
        
        base.Interact(PlayerArmature);
    }
}
