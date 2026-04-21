using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public Slider masterSlider;

    public Slider musicSlider;

    public Slider fbxSlider;

    public Slider senitivity;
   // public Transform playerBody;

    

    
 
   
    void Start()
    {
        //object value = SetFloat("SensStored", PreferencesManager.GetSensStored());
        if (senitivity != null)
        {
            senitivity.value = PreferencesManager.GetSenitivity();
        }

        if (masterSlider != null)
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
    //----------------------------------------
    
    public void ChangeSenitivity(float sensitivity)
    {
        
        PreferencesManager.SetSenitivity(sensitivity);
    }

    void Update()
    {
       
    }

    //------------------------------------------------------------
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

   //--------------------------------------------------------------------

    public void Retreat()
    {
       Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
        
    }
}
