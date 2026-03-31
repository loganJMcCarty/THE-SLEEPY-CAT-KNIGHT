using StarterAssets;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseManager : MonoBehaviour
{
    private StarterAssetsInputs inputs;
    private ThirdPersonController third;
    public GameObject settings;
    public GameObject apply;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputs = GetComponent<StarterAssetsInputs>();
        third = GetComponent<ThirdPersonController>();
    }


    // Update is called once per frame
    void Update()
    {
        
        if (inputs.pause == true && settings.activeInHierarchy == false)
        {
            EventSystem.current.SetSelectedGameObject(apply);
            settings.SetActive(true);
            Time.timeScale = 0;
            third.enabled = false;
        }
        else if(inputs.pause == false && settings.activeInHierarchy == true)
        {
            settings.SetActive(false);
            Time.timeScale = 1;
            third.enabled = true;
        }
    }
}
