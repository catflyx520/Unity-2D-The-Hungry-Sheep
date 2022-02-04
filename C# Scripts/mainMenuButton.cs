using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuButton : MonoBehaviour
{
    public string LoadScene = "GameScene";

    void Start()
    {
        SoundManagerScript.playMusicDay();
    }
    

    public void play()
    {
        Debug.Log("Play button clicked");
        
        SceneManager.LoadScene(LoadScene);
    }
}
