using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LivesHealth : MonoBehaviour {

    // Lives given to player.
    public static int lives = 3;

    // Health per life.
    public static int health = 3;

    // I-frames cooldown bool
    private static bool iframed = false;

    // Number of iframes
    int iframedcounter = 0;

    // Scene to load when lost life. (The Level, generally.)
    [SerializeField]
    int lifeLostScene;

    // Game over screen.
    [SerializeField]
    int gameOverScene;

    // Make sure to move to enemy script if moving OnTriggerEnter2D.
    public float knockback = 10;

    // Update is called once per frame
    void Update () {
        if(iframed == true)
        {
            if(iframedcounter >= 9)
            {
                iframedcounter = 0;
                iframed = false;
            }
            else
            {
                iframedcounter++;
            }
        }
        if(health <= 0)
        {
            // Or play animation or whatever.
            // Play death animation here???
            // Reset health.
            ResetHealth();
            // Subtract life.
            lives--;
            // Reload level.
            SceneManager.LoadScene(lifeLostScene);
        }
        if(lives <= 0)
        {
            ResetLives();
            SceneManager.LoadScene(gameOverScene);
        }
	
	}

    // Optional, can move to enemy script instead if needed (change "Enemy" to "Player")
    void OnTriggerEnter2D(Collider2D collided)
    {
        // Must use tag to identify enemy!
        if (collided.gameObject.tag == "Enemy" || collided.gameObject.tag == "enemy")
        {
            //Debug.Log("Collided with enemy");
            //transform.Translate(Vector2.left * knockback);
            if (iframed == false)
            {
                health--;
                iframed = true;
            }
        }
    }

    // Display Lives/Health
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width - 10 * (Screen.width / 10), Screen.height - Screen.height, 100, 20), "Lives: " + lives.ToString());
        GUI.Label(new Rect(Screen.width - 10 * (Screen.width / 10), Screen.height - Screen.height + 15, 100, 20), "Health: " + health.ToString());
    }

    // Reset Health
    public void ResetHealth()
    {
        health = 3;
    }
    // Reset Lives
    public void ResetLives()
    {
        lives = 3;
    }
}
