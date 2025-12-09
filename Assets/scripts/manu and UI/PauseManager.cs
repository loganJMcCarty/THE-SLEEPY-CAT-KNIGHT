using StarterAssets;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private StarterAssetsInputs inputs;
    public GameObject settings;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputs = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inputs.pause == true && settings.activeInHierarchy == false)
        {
            settings.SetActive(true);
        }
        else if(inputs.pause == false && settings.activeInHierarchy == true)
        {
            settings.SetActive(false);
        }
    }
}
