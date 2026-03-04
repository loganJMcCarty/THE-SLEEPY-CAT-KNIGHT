using UnityEngine;

public class Interacable : MonoBehaviour
{
    [Header("General")]
    [SerializeField] private bool destroyOnInteract;

    public virtual void Interact(GameObject Player)
    {
        if (destroyOnInteract)
            Destroy(gameObject);
    }
}
