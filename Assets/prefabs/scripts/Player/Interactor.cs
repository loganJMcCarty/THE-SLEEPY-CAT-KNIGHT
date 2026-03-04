using UnityEngine;


[RequireComponent (typeof(PlayerControl))]
public class Interactor : MonoBehaviour
{
   private PlayerControl control;

   private Interacable interacable;

    [SerializeField] private KeyCode interactKey = KeyCode.E;
    [SerializeField] private GameObject interactText;

    private void Start()
    {
        control = GetComponent<PlayerControl> ();
    }

    private void Update()
    {
        interactText.SetActive(interacable != null);

        if (Input.GetKeyDown(interactKey) && control.healthText) //might fix
            Interact();
    }

    private void Interact()
    {
        if (interacable != null) 
            return;

        interacable.Interact(gameObject);// not working
    }

    private void OnTriggerEnter(Collider other)
    {
        Interacable foundInteracable = other.GetComponent<Interacable>();

        if (foundInteracable != null)
            interacable = foundInteracable;
    }

    private void OnTriggerExit(Collider other)
    {
        Interacable foundInteracable = other.GetComponent<Interacable>();

        if (foundInteracable == interacable)
            interacable = null;
    }
}
