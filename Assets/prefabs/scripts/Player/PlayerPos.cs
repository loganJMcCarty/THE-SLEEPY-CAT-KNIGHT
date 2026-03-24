using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private CheckPoint check;
    private NextStage nextS;
    private MainUIManager MainUIManager;
    bool retry;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        check = GameObject.FindGameObjectWithTag("Check").GetComponent<CheckPoint>();
        
        nextS = GameObject.FindGameObjectWithTag("nexts").GetComponent<NextStage>();
        transform.position = check.lastCheckPointPos;
    }

    // Update is called once per frame
    void Update()
    {
        if(MainUIManager && retry == true)
        {
            
        }
    }
}
