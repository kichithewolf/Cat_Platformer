using UnityEngine;
using System.Collections;

public class FinalBossScript : MonoBehaviour {
    int speed = 10;

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * speed;
    }
}
