using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayMovieOnSpace : MonoBehaviour
{
    [SerializeField]
    int nextLevel;

    void Start()
    {
        MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        AudioSource audio = GetComponent<AudioSource>();
        movie.Play();
        audio.Play();
        //SceneManager.LoadScene(nextLevel);

    }
}
