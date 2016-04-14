using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToNextLevelOnTrigger : MonoBehaviour {

    [SerializeField]
    int nextLevel;

    [SerializeField]
    int loadMenu;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (SetReplayBool.replay)
        {
            SceneManager.LoadScene(loadMenu);
        }
        else
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
