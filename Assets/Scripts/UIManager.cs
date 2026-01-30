using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void RestartLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void pauseGame()
    {
        Time.timeScale = 0f;
    }
    public void resumeGame()
    {
        Time.timeScale = 1f;
    }
    public void HomeMenu()
    {
        SceneManager.LoadScene("HomeMenu");
    }





}
