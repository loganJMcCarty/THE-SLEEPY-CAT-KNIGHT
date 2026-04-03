using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

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

    public GameObject startButton;

    public GameObject journy;

    public GameObject reset;
//-------------------------------------
    public GameObject cutscene;
    public Image imageStart;
    public Image imagetextStart;
    public Image imageEnd;
    public Image imagetextEnd;
    public TMP_Text textStart;
    public TMP_Text textEnd;
    public GameObject startcut;

   // -------------------------------------

    private static CheckPoint instance;
    public Vector3 lastCheckPointPos;
    private CheckPoint check;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //check = GameObject.FindGameObjectWithTag("Check").GetComponent<CheckPoint>();
        if (Player.instance.hasstarted && journy != null && reset != null && startButton != null)
        {
            journy.gameObject.SetActive(true);

            reset.gameObject.SetActive(true);

            startButton.gameObject.SetActive(false);
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            check.lastCheckPointPos = transform.position;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        
        
        SaveSystem.DeletePlayerData();
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }

    public void Resume()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Player.instance.level);
    }
    
    public void Startnew()
    {
        Time.timeScale = 1;
        Player.instance.hasstarted = true;
        Player.instance.SavePlayer();
        SceneManager.LoadScene(1);
        journy.gameObject.SetActive(true);

        reset.gameObject.SetActive(true);

        startButton.gameObject.SetActive(false);
    }

    // for the button settings not the in game settings
    public void Settings()
    {
        setting.gameObject.SetActive(true);

        mainMenu.gameObject.SetActive(false);
    }

    public void Credits()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void Begin()
    {

    }
    //-----------------------------------------------------------
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
    //---------------------------------------------------------
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Nope()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
//----------------------------------------------------------
    public void Skip()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Next()
    {
        assetsUsed.gameObject.SetActive(false);

        youtubeTuttorial.gameObject.SetActive(true);

        nextButton.gameObject.SetActive(false);
    }
    
    public void Ytnext()
    {
        youtubeTuttorial.gameObject.SetActive(false);

        music.gameObject.SetActive(true);

        nextButton.gameObject.SetActive(false);
    }

    public void Musicnext()
    {
        music.gameObject.SetActive(false);

        people.gameObject.SetActive(true);

        nextButton.gameObject.SetActive(false);
    }
    //-----------------------------------------------------------
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        
#else
                Application.Quit();
#endif

    }
}
