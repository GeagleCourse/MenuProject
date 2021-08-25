using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame(int level)
    {
        Debug.Log("Start the game!");
        SceneManager.LoadScene(level); 
    }

    public void ExitGame()
    {
        Debug.Log("Exit the game!");
        Application.Quit();
    }


}
