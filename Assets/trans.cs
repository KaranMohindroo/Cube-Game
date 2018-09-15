using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trans : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    public void NextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                Application.Quit();
            }
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }
}
