using UnityEngine;
using System.Collections;

public class BasicEnemyWalk : MonoBehaviour {
    // http://answers.unity3d.com/questions/803920/how-to-move-an-object-backforth-on-a-set-path.html
    public float speed;
    public float distance;
    private float xStartPosition;

    void Start()
    {
        xStartPosition = transform.position.x;
    }
    void Update()
    {
        if ((speed < 0 && transform.position.x < xStartPosition) || (speed > 0 && transform.position.x > xStartPosition + distance))
        {
            speed *= -1;
        }
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }
}
