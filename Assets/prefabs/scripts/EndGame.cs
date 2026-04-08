using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : Interacable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Interact(GameObject PlayerArmature)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);


        base.Interact(PlayerArmature);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
        }
    }
}
