using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    public static AudioManager Instance {  get { return instance; } }

    public AudioMixer masterMixer;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Start()
    {
        masterMixer.SetFloat("MasterVolume",PreferencesManager.GetMasterVolume());

        masterMixer.SetFloat("MusicVolume", PreferencesManager.GetMusicVolume());

        masterMixer.SetFloat("SfxVolume", PreferencesManager.GetFpxVolume());
    }
    
    public void ChangeSoundVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVolume",soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVolume", soundLevel);
        PreferencesManager.SetMusicVolume(soundLevel);
    }

    public void ChangeFpxVolume(float soundLevel)
    {
        masterMixer.SetFloat("SfxVolume", soundLevel);
        PreferencesManager.SetFpxVolume(soundLevel);
    }
}
