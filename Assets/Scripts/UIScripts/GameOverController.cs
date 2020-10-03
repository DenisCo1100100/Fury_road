using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public static GameOverController Instance;

    private void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }
}
