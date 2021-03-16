
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void OnMouseDown()

    {
        SceneManager.LoadScene("GameScene");     //Brings player to Game Scene when the button it pressed
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT");                      //Exits the application when Quit button is pressed
            Application.Quit();
    }
}
