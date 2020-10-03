using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private Text numberCoin;

    private void Update()
    {
        numberCoin.text = GameState.CollectedСoins.ToString();
    }

    public void LodingMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}