using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour {
    [SerializeField]
    float timeAlloted;

    [SerializeField]
    int gameOverScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeAlloted -= Time.deltaTime;
        if(timeAlloted <= 0)
        {
            SceneManager.LoadScene(gameOverScene);
        }
	}


    void OnGUI()
    {
        GUI.Label(new Rect(850, 10, 100, 20), timeAlloted.ToString());
        //GUILayout.Label("Time Remaining: " + timeAlloted);
    }
}
