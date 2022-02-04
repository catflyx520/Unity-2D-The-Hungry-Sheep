using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneButton : MonoBehaviour
{
    public string LoadScene = "MainMenu";

    public void play()
    {
        Debug.Log("Play button clicked");
        score.scores = 0;
        SceneManager.LoadScene(LoadScene);
    }
}
