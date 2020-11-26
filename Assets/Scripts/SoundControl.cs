using UnityEngine;

public class SoundControl : MonoBehaviour
{
    [SerializeField] private AudioClip[] backgroundMusic;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.volume = StaticMenagerSetings.volume;
        PlayRandomMusic();
    }

    public void PlayRandomMusic()
    {
        audioSource.clip = backgroundMusic[Random.Range(0, backgroundMusic.Length)];
        audioSource.Play();
    }
}
