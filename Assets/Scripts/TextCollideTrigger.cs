using UnityEngine;
using System.Collections;

public class TextCollideTrigger : MonoBehaviour
{
    void Start()
    {
        //Debug.Log("test");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(other.gameObject);
        GameObject.Destroy(gameObject);
        //Debug.Log("Hello", gameObject);
    }

    /*public float lifetime = 2;
    Color fade;
    float timer;
    //http://forum.unity3d.com/threads/fading-out-alpha-on-gameobject.371899/
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            //Transparency.
            fade = GetComponent<Renderer>().material.color;
            fade.a = fade.a / 1.1f;
            GetComponent<Renderer>().material.color = fade;
            //kill when faded
            if (fade.a <= .1)
            {
                Destroy(transform.parent.gameObject);
                Destroy(gameObject);
            }

        }
    }
    */

    }