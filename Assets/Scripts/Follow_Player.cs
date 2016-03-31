using UnityEngine;
using System.Collections;

/*
 * Follow Player camera script
 * Created by David Estes-Smargiassi
*/

public class Follow_Player : MonoBehaviour {
	//Attach to camera. Will follow the player GameObject using the interpolant value for the 'catch-up' speed

    public float interpolant;
    public Transform player;
    public Vector3 offset;

    private Vector3 targetPos;
    private float interpVelocity;

    void Start () {
        targetPos = transform.position;
	}
	
	void FixedUpdate () {
        if (player)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = player.position.z;

            Vector3 targetDirection = player.position - posNoZ;

            interpVelocity = targetDirection.magnitude * 5f;
            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, targetPos + offset, interpolant); 
        }
	}
}
