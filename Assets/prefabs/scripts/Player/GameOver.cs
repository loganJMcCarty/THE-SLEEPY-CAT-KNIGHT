using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;

    private void OnEnable()
    {
        PlayerControl.OnPlayerDeath += EnableGameOverMenu;
        Debug.Log("LETS FRECKING GO!!!!!!!!");
    }

    private void OnDisable()
    {
        PlayerControl.OnPlayerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }
}   
