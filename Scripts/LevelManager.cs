using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");      //Loads Game Scene when button is pressed
    }
    public void QuitGame()
    {
        Application.Quit();                        //Allows player to exit game when Quit button is pressed
    }
}
