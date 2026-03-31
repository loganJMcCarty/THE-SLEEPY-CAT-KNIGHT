using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject retry;
    

    private void OnEnable()
    {
        PlayerControl.OnPlayerDeath += EnableGameOverMenu;
        Debug.Log("LETS FREECKING GO!!!!!!!!");
    }

    private void OnDisable()
    {
        PlayerControl.OnPlayerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(retry);
       
    }
}   
