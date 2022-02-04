using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int lives;
    public Text livesText;
    void Start()
    {
        lives = 5;
    }

    void Update()
    {
        livesText.text = "Lives:" + lives;
    }
   
}
