using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class PlayMovieOnSpace : MonoBehaviour
{
    [SerializeField]
    int nextLevel;

    [SerializeField]
    float clipLength;

    public MovieTexture movie;

    void Start()
    {
        /*
        MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        AudioSource audio = GetComponent<AudioSource>();
        StartCoroutine("waitForEnd");
        movie.Play();
        audio.Play();
        */

        movie.Play();
        StartCoroutine(WaitAndLoad(clipLength));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(nextLevel);
        }

    }

    private IEnumerator WaitAndLoad(float value)
    {
        yield return new WaitForSeconds(value);
        SceneManager.LoadScene(nextLevel);
    }
}
