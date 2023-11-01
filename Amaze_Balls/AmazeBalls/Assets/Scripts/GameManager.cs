using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGameOver = false;

    public float restartDelay = 1f;

    public GameObject completeWinUI;
    public GameObject loseGameUI;

    public void CompleteLevel()
    {
       completeWinUI.SetActive(true);
       isGameOver = true;
    }

    public void EndGame()
    {
       if (!isGameOver)
        {
            isGameOver=true;
            loseGameUI.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Restart();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                print("Application Quit");
                Application.Quit();
            }
        }
    }
}
