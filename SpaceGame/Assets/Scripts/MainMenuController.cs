using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene(1);
        //Debug.Log("Play button clicked");
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
        //Debug.Log("Exit button clicked");
    }
}
