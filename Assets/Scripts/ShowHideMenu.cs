using UnityEngine;
using System.Collections;

public class ShowHideMenu : MonoBehaviour {
    public GameObject menuName;
    private bool isMenuShowing;

    // Use this for initialization
    void Start () {
        isMenuShowing = false;
        menuName.SetActive(isMenuShowing);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }

            isMenuShowing = !isMenuShowing;
            menuName.SetActive(isMenuShowing);

        }
    }
}
