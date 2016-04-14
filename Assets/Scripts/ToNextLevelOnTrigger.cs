using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToNextLevelOnTrigger : MonoBehaviour {

    [SerializeField]
    int nextLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(nextLevel);
    }
}
