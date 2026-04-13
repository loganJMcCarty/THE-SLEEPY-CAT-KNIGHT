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

        clip.gameObject.SetActive(true);
        
    }

    /*public void OnEnable()
    {
        Invoke(nameof(Deatevate), 5f);
    }

    public void Deatevate()
    {
        clip.gameObject.SetActive(false);
    }*/
}
