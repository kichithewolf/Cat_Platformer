using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LivesHealth : MonoBehaviour {

    // Lives given to player.
    public static int lives = 3;

    // Health per life.
    [SerializeField]
    int health;

    // Scene to load when lost life.
    [SerializeField]
    int lifeLostScene;

    // Game over screen.
    [SerializeField]
    int gameOverScene;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(health <= 0)
        {
            // Or play animation or whatever.
            lives--;
            SceneManager.LoadScene(lifeLostScene);
        }
        if(lives <= 0)
        {
            SceneManager.LoadScene(gameOverScene);
        }
	
	}

    void OnTriggerEnter2D(Collider2D other) //TODO: Make on enemy only.
    {
        health--;
    }

    // Display Lives/Health
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width - 9 * (Screen.width / 10), Screen.height - 15 * (Screen.height / 15), 100, 20), lives.ToString());
        GUI.Label(new Rect(Screen.width - 9 * (Screen.width / 10), Screen.height - 14 * (Screen.height / 15), 100, 20), health.ToString());
    }
}
