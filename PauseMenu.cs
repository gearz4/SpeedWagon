using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public int onClick;
    string GooglePlay_ID = "3923065";
    bool TestMode = true;
    public GameObject pauseButton;


    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(GooglePlay_ID, TestMode);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(onClick == 1)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if(onClick == 2)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
            onClick = 0;
        }*/
    }

    public void OpenPause()
    {
        //onClick += 1;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        pauseButton.SetActive(false);

    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        //onClick = 0;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main");
    }

    public void RestartCurrentScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void CallAds()
    {
        Advertisement.Show();
    }
}
