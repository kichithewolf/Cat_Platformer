using UnityEngine;
using System.Collections;

public class Splashscreen: MonoBehaviour
{
    public float time = 1;
    static bool playedOnce = false; //Splashscreen will only appear when game starts.

    void Start()
    {
        if (!playedOnce)
        {
            Destroy(gameObject, time);
            playedOnce = true;
        }
        else //If returning to mm from another screen/level, don't play it again.
        {
            Destroy(gameObject);
        }
    }
}