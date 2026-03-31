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

    public static float sensitivity = 90f;
    public Transform playerBody;

    float xRotation = 0f;

    
 

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
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

    public void SensStored (float SensIndex)
    {
        sensitivity = SensIndex;
    }
   
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, 0f, 1f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
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
