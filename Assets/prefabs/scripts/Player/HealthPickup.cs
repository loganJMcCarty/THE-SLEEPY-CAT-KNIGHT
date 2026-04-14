using Unity.VisualScripting;
using UnityEngine;

public class HealthPickup : Interacable
{
    [SerializeField] private int health = (int)50f;
    public GameObject clip;
    public override void Interact(GameObject PlayerArmature)
    {
        PlayerArmature.GetComponent<PlayerControl>().Addhealth(health);
        
        base.Interact(PlayerArmature);
        if(clip != null)   
            clip.gameObject.SetActive(true);

    }


}
