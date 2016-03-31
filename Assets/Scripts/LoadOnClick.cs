using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Newer way of loading things.

public class LoadOnClick : MonoBehaviour
{
    //Code modified from https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/creating-a-scene-menu

    public GameObject loadingImage;

    public void LoadScene(int level)
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene(level); //Remove deprecated function.
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}