using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CountDownTimer : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 30f;
    private Text timerSeconds;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {
            SceneManager.LoadScene(levelToLoad);    //When timer runs out this will bring the player to the next scene
        }
        
    }
}
