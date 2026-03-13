using UnityEngine;

public class KeyPickup : Interacable
{
    [SerializeField] private GameObject key;
    
    public override void Interact(GameObject PlayerArmature)
    {
        PlayerArmature.GetComponent<PlayerControl>();
       
       base.Interact(PlayerArmature);
    }
}
