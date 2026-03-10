using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public Scrollbar masterSlider;

    public Scrollbar musicSlider;

    public Scrollbar fbxSlider;
 

    void Start()
    {
        if(masterSlider != null)
        {
            PreferencesManager.GetMasterVolume();
        }

        if(musicSlider != null)
        {
            PreferencesManager.GetMusicVolume();
        }

        if (fbxSlider != null)
        {
            PreferencesManager.GetFpxVolume();
        }
    }

   
    void Update()
    {
        
    }

    public void ChangeSoundVolume(float soundlevel)
    {
        if (AudioManager.Instance != null)

        AudioManager.Instance.ChangeSoundVolume(soundlevel);
    }

    public void ChangeMusicVolume(float soundlevel)
    {
        if (AudioManager.Instance != null)

            AudioManager.Instance.ChangeMusicVolume(soundlevel);
    }

    public void ChangeFpxVolume(float soundlevel)
    {
        if (AudioManager.Instance != null)

            AudioManager.Instance.ChangeFpxVolume(soundlevel);
    }

    public void startnew()
    {
       Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}
