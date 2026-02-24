using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private CheckPoint check;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        check = GameObject.FindGameObjectWithTag("Check").GetComponent<CheckPoint>();
        transform.position = check.lastCheckPointPos;
    }

    // Update is called once per frame
    void Update()
    {
        //if()
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
