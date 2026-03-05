using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public AudioClip background;


    private void Start()
    {
        audioSource.clip = background;
        audioSource.Play();
    }
}
