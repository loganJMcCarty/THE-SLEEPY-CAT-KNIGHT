using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static CheckPoint instance;
    public Vector3 lastCheckPointPos;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
        lastCheckPointPos = new Vector3(Player.instance.position[0], Player.instance.position[1], Player.instance.position[2]);
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
