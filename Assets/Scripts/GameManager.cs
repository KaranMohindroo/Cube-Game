using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", 1);
		}
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
