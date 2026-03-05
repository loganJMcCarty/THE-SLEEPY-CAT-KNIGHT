using UnityEngine;

public class Interacable : MonoBehaviour
{
    [Header("General")]
    [SerializeField] private bool destroyOnInteract;

    public virtual void Interact(GameObject PlayerArmature)
    {
        if (destroyOnInteract)
        {
            Destroy(gameObject);
        }
           
    }
}
