using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private CheckPoint check;
    private NextStage nextS;
    private EndGame endgame;
    private MainUIManager MainUIManager;
    bool retry;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        check =CheckPoint.instance;
        transform.position = check.lastCheckPointPos;
        
        nextS = GameObject.FindGameObjectWithTag("nextS").GetComponent<NextStage>();// prob tag
        //endgame = GameObject.FindGameObjectWithTag("endgame").GetComponent<EndGame>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MainUIManager && retry == true)
        {
            
        }
    }
}
