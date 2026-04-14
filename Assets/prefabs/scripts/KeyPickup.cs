using UnityEngine;

public class KeyPickup : Interacable
{
    public GameObject ow;
    [SerializeField] private GameObject key;
    [SerializeField] private int health = (int)-50f;
    public override void Interact(GameObject PlayerArmature)
    {
        PlayerArmature.GetComponent<PlayerControl>();
        PlayerArmature.GetComponent<PlayerControl>().Addhealth(health);

        base.Interact(PlayerArmature);
        ow.gameObject.SetActive(true);
    }
}
