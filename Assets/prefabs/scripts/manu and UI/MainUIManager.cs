using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MainUIManager : MonoBehaviour
{
    public GameObject mainMenu;

    public GameObject setting;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startnew()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        
    }

    public void settings()
    {
        setting.gameObject.SetActive(true);

        mainMenu.gameObject.SetActive(false);
    }

    public void GOBACKDEARGOD()
    {
        mainMenu.gameObject.SetActive(true);

        setting.gameObject.SetActive(false);
    }

    public void ToBattle()
    {
        setting.gameObject.SetActive(true);

        mainMenu.gameObject.SetActive(false);
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nope()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        
#else
                Application.Quit();
#endif

    }
}
