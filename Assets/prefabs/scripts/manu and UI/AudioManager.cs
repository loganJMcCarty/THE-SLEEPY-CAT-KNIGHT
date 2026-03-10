using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    public static AudioManager Instance {  get { return instance; } }

    public AudioMixer masterMixer;

    public void ChangeSoundVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol",soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PreferencesManager.SetMusicVolume(soundLevel);
    }

    public void ChangeFpxVolume(float soundLevel)
    {
        masterMixer.SetFloat("FpxVol", soundLevel);
        PreferencesManager.SetFpxVolume(soundLevel);
    }

    public void Start()
    {
        masterMixer.SetFloat("MasterVol",PreferencesManager.GetMasterVolume());

        masterMixer.SetFloat("MusicVol", PreferencesManager.GetMusicVolume());

        masterMixer.SetFloat("FpxVol", PreferencesManager.GetFpxVolume());
    }
}
