using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sceneloader : MonoBehaviour
{ 
    public void LoadGame()
    {
        SceneManager.LoadScene("Lobby");
      
    }
    public void newScene(string sceneName)
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //SceneManager.LoadScene(sceneName);

        switch (sceneName)
        {
            case "Start":
                SceneManager.LoadScene("Character_Create");
                break;
            case "Lobby":
                SceneManager.LoadScene("Lobby");
                //currentRoom = SceneManager.GetSceneByName("Lobby");
                break;
            case "Training Room":
                SceneManager.LoadScene("Training_room");
                break;
            case "Cafe":
                SceneManager.LoadScene("Cafe");
                break;
            case "Debut Stage":
                SceneManager.LoadScene("Results");
                break;
        }
    }

    public void Back()
    {
        SceneManager.LoadScene("Lobby");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
