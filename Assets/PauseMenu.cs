using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }

    private void Resume()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1;
            gameIsPaused = false;
        }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    private void Quit()
    {
        Application.Quit();
    }

    private void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
    