using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Variant_button : MonoBehaviour
{
    public string LoadScene1 = "GameScene1";

    public void play()
    {
        Debug.Log("Play button clicked");
        SceneManager.LoadScene(LoadScene1);
    }
}
