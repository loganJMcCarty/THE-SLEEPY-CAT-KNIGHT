using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : Interacable
    
{
    private NextStage nextS;

    public Vector3 Playerpos;
    public override void Interact(GameObject PlayerArmature)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        

        base.Interact(PlayerArmature);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nextS.Playerpos = transform.position;
        }
    }

     

    void Start()
    {
        nextS = GameObject.FindGameObjectWithTag("nextS").GetComponent<NextStage>();

        
    }
}
