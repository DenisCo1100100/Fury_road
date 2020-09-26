using UnityEngine.SceneManagement;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
