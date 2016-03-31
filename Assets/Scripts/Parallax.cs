using UnityEngine;
using System.Collections;

/*
 * Parallax camera script
 * Created by David Estes-Smargiassi
*/

public class Parallax : MonoBehaviour
{
    //This script should be attached to the object is being compared against for the parallax shift (generally the camera).
    // The other object (whose position will be changed relative to this object), must be a parameter of this script.

   	//This is the object that is being parallaxed against
    public Transform other;
	//This is the amount of parallaxing; it relates to the the speed that the 'other' will move
    public float scaleFactor;

	//Stores original position of 'other' in scene; will return 'other' to there when closed
    private Vector3 startPos;
	//Will be set to Vector2(scaleFactor, scaleFactor) in Start()
    private Vector2 scaleVec;


	//Initialization
    void Start()
    {
        startPos = other.position;
        scaleVec = new Vector2(scaleFactor, scaleFactor);
    }

	//Updates per time, not frame
    void FixedUpdate()
    {
        Vector3 newBkgPos = transform.position;
        newBkgPos.Scale(scaleVec);
        newBkgPos += startPos;
        other.position = newBkgPos;
    }

	//When script closes, return 'other' to its starting position in the scene
    void onDisable()
    {
        other.position = startPos;
    }
}
