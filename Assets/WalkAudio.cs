using UnityEngine;
using System.Collections;

public class WalkAudio : MonoBehaviour {
    AudioSource walkingSound;

    void Start()
    {
        //walkingSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            walkingSound.Play();
        }
        else if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            walkingSound.Stop();
        }
    }
}
