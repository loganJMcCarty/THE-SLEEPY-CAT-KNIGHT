using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MainUIManager : MonoBehaviour
{
    public GameObject mainMenu;

    public GameObject setting;

    public GameObject assetsUsed;

    public GameObject youtubeTuttorial;

    public GameObject music;

    public GameObject people;

    public GameObject nextButton;

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

    // for the button settings not the in game settings
    public void settings()
    {
        setting.gameObject.SetActive(true);

        mainMenu.gameObject.SetActive(false);
    }

    public void credits()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
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

    public void skip()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void next()
    {
        assetsUsed.gameObject.SetActive(false);

        youtubeTuttorial.gameObject.SetActive(true);

        nextButton.gameObject.SetActive(false);
    }

    public void ytnext()
    {
        youtubeTuttorial.gameObject.SetActive(false);

        music.gameObject.SetActive(true);

        nextButton.gameObject.SetActive(false);
    }

    public void musicnext()
    {
        music.gameObject.SetActive(false);

        people.gameObject.SetActive(true);

        nextButton.gameObject.SetActive(false);
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
