using UnityEngine;
using System.Collections;

public class BasicEnemyWalk : MonoBehaviour {
    // http://answers.unity3d.com/questions/803920/how-to-move-an-object-backforth-on-a-set-path.html
    public float speed; //SET NEGATIVE
    public float distance;
    private float xStartPosition;
    private bool m_FacingRight = false;

    void Start()
    {
        xStartPosition = transform.position.x;
    }
    void Update()
    {
        if ((speed < 0 && transform.position.x < xStartPosition) || (speed > 0 && transform.position.x > xStartPosition + distance))
        {
            speed *= -1;
            Flip();

        }
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        
    }
}
