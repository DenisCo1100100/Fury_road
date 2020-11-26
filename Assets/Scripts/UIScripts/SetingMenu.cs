using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetingMenu : MonoBehaviour
{
    Slider musicVolume;

    private void Awake()
    {
        musicVolume = gameObject.GetComponentInChildren<Slider>();
    }

    private void Update()
    {
        StaticMenagerSetings.volume = musicVolume.value;
    }
}
