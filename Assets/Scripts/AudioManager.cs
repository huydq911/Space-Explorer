using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------------ Audio Source ------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSrouce;

    [Header("------------ Audio Clip ------------")]
    public AudioClip background;
    public AudioClip explosion;
    public AudioClip shoot;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSrouce.PlayOneShot(clip);
    }
}
