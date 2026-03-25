using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : Interacable
    
{

    public Vector3 playerpos;
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
            playerpos = new Vector3(8.26849365f, 14.1883631f, -59.8207703f);
            Player.instance.level = 2;
            Player.instance.position[0] = playerpos.x;
            Player.instance.position[1] = playerpos.y;
            Player.instance.position[2] = playerpos.z;
            Player.instance.SavePlayer();
        }
    }

     

    void Start()
    {

        
    }
}
