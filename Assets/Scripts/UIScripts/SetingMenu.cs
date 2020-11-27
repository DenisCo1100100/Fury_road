using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetingMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    private AudioSource menuSound;
    private Slider musicVolume;

    private void Awake()
    {
        musicVolume = gameObject.GetComponentInChildren<Slider>();
        menuSound = mainMenu.GetComponent<AudioSource>();
    }

    private void Update()
    {
        StaticMenagerSetings.volume = musicVolume.value;
        menuSound.volume = musicVolume.value;
    }
}
