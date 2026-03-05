using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent (typeof(PlayerControl))]
public class Interactor : MonoBehaviour
{
   private PlayerControl control;

   private Interacable interacable;

   public bool Interacting;

    [SerializeField] private KeyCode interactKey = KeyCode.E;
    [SerializeField] private GameObject interactText;

    private void Start()
    {
        control = GetComponent<PlayerControl> ();
    }

    private void Update()
    {
        interactText.SetActive(interacable != null);

        if (Interacting && control.healthText)
            Interact();
    }

    private void Interact()
    {
        if (interacable == null) 
            return;

        interacable.Interact(gameObject);// not working gives eorror sometimes
    }

    public void OnInteract(InputValue value)
    {
        Interacting = value.isPressed;
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
