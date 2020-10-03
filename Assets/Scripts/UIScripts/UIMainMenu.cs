using UnityEngine.SceneManagement;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    public void PlayPressed()
    {

        GameState.CollectedСoins = 0;
        SceneManager.LoadScene("Game");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
