using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class YouDiedBox : MonoBehaviour {

    // Scene to load when lost life. (The Level, generally.)
    [SerializeField]
    int lifeLostScene;

    void OnTriggerEnter2D(Collider2D collided)
    {
        if (collided.gameObject.tag == "Player")
        {
            Debug.Log("You Died");
            LivesHealth.health = 0;
            SceneManager.LoadScene(lifeLostScene);
        }
    }
}
