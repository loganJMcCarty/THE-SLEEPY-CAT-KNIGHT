using UnityEngine;

public static class PreferencesManager
{
    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat("MusicVolume", 1);
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat("MasterVolume", 1);
    }

    public static float GetFpxVolume()
    {
        return PlayerPrefs.GetFloat("SfxVolume", 1);
    }

    public static void SetMusicVolume(float soundlevel)
    {
        PlayerPrefs.SetFloat("MusicVolume",soundlevel);
    }

    public static void SetMasterVolume(float soundlevel)
    {
        PlayerPrefs.SetFloat("MasterVolume", soundlevel);
    }

    public static void SetFpxVolume(float soundlevel)
    {
        PlayerPrefs.SetFloat("SfxVolume", soundlevel);
    }

    /*public static float GetSensStored()
    {
       return PlayerPrefs.GetFloat("SensStored", 1);
    }
    
    public static void SetSensStored(float sensitivity)
    {
        PlayerPrefs.SetFloat("SensStored", sensitivity);
    }*/
}
