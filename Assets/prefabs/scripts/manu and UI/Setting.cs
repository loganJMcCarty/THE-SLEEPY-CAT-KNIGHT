using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public Slider masterSlider;

    public Slider musicSlider;

    public Slider fbxSlider;
 

    void Start()
    {
        if(masterSlider != null)
        {
            masterSlider.value = PreferencesManager.GetMasterVolume();
        }

        if(musicSlider != null)
        {
            musicSlider.value = PreferencesManager.GetMusicVolume();
                
        }

        if (fbxSlider != null)
        {
            fbxSlider.value = PreferencesManager.GetFpxVolume();
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
