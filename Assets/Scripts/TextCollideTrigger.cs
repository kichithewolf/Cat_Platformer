using UnityEngine;
using System.Collections;

public class TextCollideTrigger : MonoBehaviour
{
    void Start()
    {
        Debug.Log("test");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(other.gameObject);
        GameObject.Destroy(gameObject);
        Debug.Log("Hello", gameObject);
    }
}