using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void PlayGame()
    {
        SceneManager.LoadScene("New Scene");
    }

    private void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}
